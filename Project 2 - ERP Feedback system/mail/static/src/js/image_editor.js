odoo.define('mail.ImageEditor', function(require) {
    "use strict";

    var core = require('web.core');
    var Widget = require('web.Widget');
    var Model = require('web.Model');
    var session = require('web.session');
    var utils = require('web.utils');

    var QWeb = core.qweb;
    var _t = core._t;
    var followers = "";

    var ImageEditor = Widget.extend({
        template: 'mail.ChatThread.ImageEditor',
        events: {
            'click .o_close_editor': 'on_editor_close_click',
            'mousedown .o_editor_image': 'o_editor_image_mousedown',
            'click .o_editor_hide_annotation_btn': 'btn_show_hide_click',
            'click .color_picker_all_menubar': 'color_picker_all_menubar_click',
            'click .o-comment-card': 'o_comment_card_click',
            'mouseover .o-comment-card': 'o_comment_card_hover',
            'mouseout .o-comment-card': 'o_comment_card_mouseout',
            'click .hide_comments_area': 'hide_comments_area_click',
            'click .share_image': 'share_image_click',
            'click .addversion' : 'addversion_click',
        },
        init: function(parent, att_id, att_name,att_type) {
            this.att_id = att_id;
            this.att_name = att_name;
            this.att_type = att_type;
            this.download_link = "/web/image/" + att_id + "?download=true";

            this.circle_color_class = "circle_color_";
            this.rectangle_color_class = "rectangle_color_";

            this.annotation_state = "show_annotation";

            this.comment_num = 1;
            this.pointer_color = 1;

            this.chatter_child = {};
            this.messagetile_child = {};

            this.modified_date = moment.utc('1981-01-01').local();

            var self = this;
            $(window).resize(function() {
                self.o_image_annoted_div_resize();
            });
            $(document).keyup(function(e) {
                if (e.keyCode == 27) {
                    if (self.dialog_temp == 1)
                        self.clear_all(-1);
                    else
                        self.destroy();
                }
            });

            return this._super();
        },
        //////////////////////////////////////////////////////////////////////
        willStart: function() {

            var ir_att_model = new Model('ir.attachment');
            var ir_domain = [
                ['id', '=', this.att_id]
            ];
            ir_att_model.call('search_read', [ir_domain]).then(function(result) {

                this.res_id = result[0].res_id;
                this.res_model = result[0].res_model;

                var follower_domain = [
                    ['res_id', '=', this.res_id]
                ];

                var follower_model = new Model('mail.followers');
                var self = this;
                follower_model.call('search_read', [follower_domain]).then(function(result1) {

                    //Now inserting the values 
                    followers = "";
                    _.each(result1, function(res_ids) {

                        if (res_ids.partner_id != false && res_ids.res_model == self.res_model) {
                            followers += " " + (res_ids.partner_id[0]);
                        }
                    });
                });
            });
            return $.when();
        },
        //////////////////////////////////////////////////////////////////////////
        start: function() {
            this.$annoted_div = this.$(".o_image_annoted_div");
            this.color_picker_menubar_ele = this.$(".color_picker_selected_menubar");
            this.comment_area_div = this.$('.o-comments-area');

            var circle_color = utils.get_cookie("image_editor_circle_color");
            if (circle_color > 1) {
                this.pointer_color = circle_color;
                this.set_color_picker();
            }

            this.$("img.o_editor_image").on('load', function() {
                self.o_image_annoted_div_resize();
            });

            var self = this;
            this.image_editor_circle_model = new Model('mail.imageeditor.circle');
            var domain = [
                ['attachment_id', '=', this.att_id]
            ];
            this.image_editor_circle_model.call('search_read', [domain]).then(function(result) {

                _.each(result, function(circle) {

                    /////////////////////////////////////////////////////////
                    var circle_followers = " ";

                    if (circle.who_read != " ") {
                        circle_followers = circle.who_read.split(" ");
                    }

                    var res = $.inArray(String(session.partner_id), circle_followers);

                    if (res == -1) {
                        self.is_unread = 1;
                    } else {
                        self.is_unread = 0;
                    }
                    ////////////////////////////////////////////////////////
                    var circle_values = {
                        'circle_db_id': circle.id,
                        'circle_top': circle.top_cord,
                        'circle_left': circle.left_cord,
                        'rectangle_top': circle.rectangle_top,
                        'rectangle_left': circle.rectangle_left,
                        'rectangle_height': circle.rectangle_height,
                        'rectangle_width': circle.rectangle_width,
                        'circle_color': circle.color,
                        'resolve': circle.resolve,
                        'author_id': circle.author_id,
                        'subject': circle.subject,
                        'div_height': circle.div_height,
                        'div_width': circle.div_width,
                        'hide_state': true,
                        'comment_num': self.comment_num,
                    };
                    var chatter = new Chatter(circle_values, self);
                    chatter.appendTo(self.$annoted_div);
                    self.chatter_child[circle.id] = chatter;

                    

                    var author_name = circle.author_id[1];
                    if(circle.author_id[1].indexOf(',') != -1)
                        author_name = circle.author_id[1].split(',')[1].trim();

                    self.messagetile_child[circle.id] = {
                        'id' : circle.id,
                        'comment_num' : self.comment_num,
                        'color' : self.circle_color_class+circle.color,
                        'author_name' : author_name,
                        'messsage' : circle.subject,
                        'create_date' : moment.utc(circle.create_date).local().fromNow(),
                        'resolve' : circle.resolve,
                        'utc_time' : moment(circle.create_date).format(),
                        'unread': self.is_unread
                    };
                    
                    self.$('.num_of_comments').text(self.comment_num + " Comments");
                    self.comment_num++;
                });
            }).done(function() {
                self.o_image_annoted_div_resize();
                self.render_messagetile();
            });
            return this._super().then(function() {
                //self.$('[data-toggle="tooltip"]').tooltip();
            });
        },
        share_image_click: function(e) {
            var link = document.createElement("input");
            document.body.appendChild(link);
            link.setAttribute("id", "image_link");
            document.getElementById("image_link").value = window.location.href + "&image_id=" + this.att_id;
            link.select();
            document.execCommand("copy");
            document.body.removeChild(link);

            this.$(".link_notify").fadeIn("show");

            setTimeout(function() {
                $(".link_notify").fadeOut();
            }, 2000);
        },
        render_messagetile: function() {
            this.comment_area_div.empty();
            var messagetile_template = QWeb.render("mail.ChatThread.ImageEditor.MessageTile", { 'messagetiles': _.values(this.messagetile_child) });
            this.comment_area_div.append(messagetile_template);
        },
        o_comment_card_click: function(e) {
            var chatter_id = $(e.currentTarget).data('id');
            this.chatter_child[chatter_id].o_annoted_circle_click();
        },
        o_comment_card_hover: function(e) {
            this.chatter_hover_id = $(e.currentTarget).data('id');
            this.chatter_child[this.chatter_hover_id].circle_ele.addClass("o_annoted_circle_card_hover");
            this.chatter_child[this.chatter_hover_id].rectangle_ele.addClass("o_image_editor_rectangle_card_hover");
        },
        o_comment_card_mouseout: function() {
            this.chatter_child[this.chatter_hover_id].circle_ele.removeClass("o_annoted_circle_card_hover");
            this.chatter_child[this.chatter_hover_id].rectangle_ele.removeClass("o_image_editor_rectangle_card_hover");
        },
        create_chatter: function(new_chatter_value) {

            if (new_chatter_value.rectangle_height != 0) {
                new_chatter_value.circle_top = new_chatter_value.rectangle_top + new_chatter_value.rectangle_height - 10;
                new_chatter_value.circle_left = new_chatter_value.rectangle_left + new_chatter_value.rectangle_width - 10;
            }

            var chatter_values = {
                'circle_db_id': 0,
                'circle_top': new_chatter_value.circle_top,
                'circle_left': new_chatter_value.circle_left,
                'rectangle_top': new_chatter_value.rectangle_top,
                'rectangle_left': new_chatter_value.rectangle_left,
                'rectangle_height': new_chatter_value.rectangle_height,
                'rectangle_width': new_chatter_value.rectangle_width,
                'circle_color': this.pointer_color,
                'resolve': false,
                'author_id': session.partner_id,
                'subject': '',
                'div_height': new_chatter_value.current_div_height,
                'div_width': new_chatter_value.current_div_width,
                'hide_state': false,
                'comment_num': this.comment_num,
            };

            if (!this.chatter_child[0]) {
                var chatter = new Chatter(chatter_values, this);
                chatter.appendTo(this.$annoted_div);
                this.dialog_temp = 1;
                this.chatter_child[0] = chatter;
                this.comment_box_position(chatter);
            }
        },
        o_editor_image_mousedown: function(e) {
            e.preventDefault();

            if (this.annotation_state == "hide_annotation") {
                return; }

            if (this.dialog_temp == 1) { this.clear_all();
                return; }

            this.clear_all();
            var offset = $(this.$annoted_div).offset();
            var click_x = e.pageX - offset.left;
            var click_y = e.pageY - offset.top;
            var current_div_height = this.$annoted_div.innerHeight();
            var current_div_width = this.$annoted_div.innerWidth();

            var rect = $("<div>").addClass('o_image_editor_rectangle').addClass(this.rectangle_color_class + this.pointer_color);
            this.$annoted_div.append(rect);

            var self = this;
            var move_x = 0,
                move_y = 0,
                rect_width = 0,
                rect_height = 0,
                new_x = 0,
                new_y = 0;
            $(self.$annoted_div).mousemove(function(e) {

                move_x = e.pageX - offset.left;
                move_y = e.pageY - offset.top;
                rect_width = Math.abs(move_x - click_x);
                rect_height = Math.abs(move_y - click_y);

                new_y = (move_y < click_y) ? (click_y - rect_height) : click_y;
                new_x = (move_x < click_x) ? (click_x - rect_width) : click_x;

                rect.css({ 'width': rect_width, 'height': rect_height, 'top': new_y, 'left': new_x });
            }).mouseup(function() {
                $(self.$annoted_div).off('mousemove');
                $(self.$annoted_div).off('mouseup');
                var circle_left = e.pageX - offset.left - 10,
                    circle_top = e.pageY - offset.top - 10;
                var new_chatter_value = {
                    'circle_top': circle_top,
                    'circle_left': circle_left,
                    'rectangle_top': new_y,
                    'rectangle_left': new_x,
                    'rectangle_height': rect_height,
                    'rectangle_width': rect_width,
                    'current_div_width': current_div_width,
                    'current_div_height': current_div_height,
                };
                self.create_chatter(new_chatter_value);
                rect.remove();
            });
        },
        color_picker_all_menubar_click: function(e) {
            this.pointer_color = this.$(e.target).data("color");
            utils.set_cookie('image_editor_circle_color', this.pointer_color, 30 * 24 * 60 * 60);
            this.set_color_picker();
        },
        set_color_picker: function() {
            var oldclass = this.color_picker_menubar_ele.attr("class").split(' ')[1];
            var newclass = this.circle_color_class + this.pointer_color;
            this.color_picker_menubar_ele.removeClass(oldclass).addClass(newclass);
        },
        btn_show_hide_click: function(e) {
            this.$("#hide_annotation_icon").toggleClass("fa-eye-slash fa-eye");
            this.$('#color_picker_menubar_id').toggleClass('o_hidden');
            if (this.hide_annotation_temp) {
                this.show_all();
                this.annotation_state = "show_annotation";
                this.$("#hide_annotation_icon").css({ 'color': '#21b799' });
                this.$("#hide_annotation_tooltip").attr('title', 'Hide Annotation');
            } else {
                this.hide_all();
                this.annotation_state = "hide_annotation";
                this.$("#hide_annotation_icon").css({ 'color': '#d9534f' });
                this.$("#hide_annotation_tooltip").attr('title', 'Show Annotation');
            }
            this.hide_annotation_temp = !(this.hide_annotation_temp);
        },
        hide_all: function() {
            _.each(_.values(this.chatter_child), function(chatter) {
                chatter.do_hide();
            });
        },
        show_all: function() {
            _.each(_.values(this.chatter_child), function(chatter) {
                chatter.do_show();
            });
        },
        clear_all: function(id) {
            this.dialog_temp = 0;
            if (this.chatter_child[0]) {
                this.chatter_child[0].$el.remove();
                delete this.chatter_child[0];
            }
            _.each(_.values(this.chatter_child), function(chatter) {
                if (chatter.chatter_Values.circle_db_id != id)
                    chatter.commentbox_ele.addClass('o_hidden');
            });
        },
        on_editor_close_click: function() {
            this.destroy();
        },
        comment_box_position: function(chatter) {
            var root_div_width = $('.o-image-editor').width();

            if (chatter.commentbox_ele.width() + chatter.chatter_Values.circle_left + 35 > root_div_width) {
                $('.o-image-editor').animate({
                    scrollLeft: $('.o-image-editor').get(0).scrollWidth
                }, 200);
            }
            if (chatter.commentbox_ele.height() + chatter.chatter_Values.circle_top + 15 > $('.o-image-editor').height()) {
                $('.o-image-editor').animate({
                    scrollTop: $('.o-image-editor').get(0).scrollHeight
                }, 200);
            }
        },
        o_annoted_rectangle_resize: function(rectangle, current_div_height, current_div_width, new_circle_top, new_circle_left, chatter_values) {
            var new_top = (current_div_height * chatter_values.rectangle_top) / (chatter_values.div_height);
            var new_left = (current_div_width * chatter_values.rectangle_left) / (chatter_values.div_width);

            rectangle.css({
                'top': new_top,
                'left': new_left,
                'height': new_circle_top - new_top + 10,
                'width': new_circle_left - new_left + 10,
            });
        },
        o_image_annoted_div_resize: function() {

            var current_div_height = this.$annoted_div.innerHeight();
            var current_div_width = this.$annoted_div.innerWidth();
            var chatters = _.values(this.chatter_child);
            var self = this;
            _.each(chatters, function(chatter) {
                var new_top = (current_div_height * chatter.chatter_Values.circle_top) / (chatter.chatter_Values.div_height);
                var new_left = (current_div_width * chatter.chatter_Values.circle_left) / (chatter.chatter_Values.div_width);

                chatter.circle_ele.css({ 'top': new_top, 'left': new_left });
                chatter.commentbox_ele.css({ 'top': new_top - 20, 'left': new_left + 35 });

                if (chatter.$('.o_image_editor_rectangle'))
                    self.o_annoted_rectangle_resize(chatter.rectangle_ele, current_div_height, current_div_width, new_top, new_left, chatter.chatter_Values);
            });
        },

        hide_comments_area_click: function() {
            var title;
            this.hide_comment_area_temp ? title = "Hide Comments" : title = "Show Comments";
            this.hide_comment_area_temp = !(this.hide_comment_area_temp);

            this.$("#hide_comments_area_icon").attr('title', title);
            this.$("#hide_comment_icon").toggleClass("fa-angle-up fa-angle-down");
            this.$('#o-sidebar_id').slideToggle();
            setTimeout(function() {
                this.$('#o-image-editor_id').toggleClass('col-md-12 col-md-9');
            }, 200);
            var self = this;
            setTimeout(function() {
                self.o_image_annoted_div_resize();
            }, 301);
        },
        addversion_click: function(){
            var addverison = new Versions();
            addverison.appendTo('body');
        },
    });

    var Versions = Widget.extend({
        template: 'mail.ChatThread.ImageEditor.AddVersion',
        events: {
            'click .closeVersion' : 'closeVersion_click',
            'click .addatt' : 'on_click_add_attachment'
        },
        init: function() {
            
        },
        closeVersion_click: function(){
            this.destroy();
        },
        on_click_add_attachment: function () {
            console.log("click");
            this.$('input.o_form_input_file').click();
        },
    });

    var Chatter = Widget.extend({
        template: 'mail.ChatThread.ImageEditor.Chatter',
        events: {
            'click .o_image_editor_rectangle': 'o_image_editor_rectangle_click',
            'click .o_annoted_circle': 'o_annoted_circle_click',
            'click .resolve_btn': 'resolve_btn_click',
            'click .o_comment_box_close': 'o_comment_box_close_click',
            'click .o_comment_box_send': 'o_comment_box_send_click',
            'click .color_picker_all': 'color_picker_all_click',
            'keyup .o_composer_text_field': 'o_composer_text_field_keyup',
        },
        init: function(chatter_Values, parent) {
            this.chatter_Values = chatter_Values;
            this.parent = parent;
            this.chatter_message_child = {};
        },
        start: function() {
            this.chatter_div = this.$(".o_comment_box_chatter_div");
            this.circle_ele = this.$(".o_annoted_circle");
            this.rectangle_ele = this.$(".o_image_editor_rectangle");
            this.commentbox_ele = this.$('.o_comment_box_root');

            this.$('.o_composer_text_field').focus();

            if (this.chatter_Values.circle_db_id == 0)
                this.$('.resolve_btn').addClass('o_hidden');

            this.circle_ele.addClass(this.parent.circle_color_class + this.chatter_Values.circle_color);
            this.rectangle_ele.addClass(this.parent.rectangle_color_class + this.chatter_Values.circle_color);
            this.$(".color_picker_selected").addClass(this.parent.circle_color_class + this.chatter_Values.circle_color);
            this.resolve_state();

            if (this.chatter_Values.hide_state) {
                this.do_toggle(this.commentbox_ele);
                this.image_editor_message_model = new Model('mail.imageeditor.message');

                var self = this;
                var domain = [
                    ['circle_id', '=', self.chatter_Values.circle_db_id]
                ]
                this.image_editor_message_model.call('search_read', [domain]).then(function(result) {
                    _.each(result, function(message) {
                        var message_create_date = moment.utc(message.create_date).local();
                        var author_name = message.author_id[1];
                        if(message.author_id[1].indexOf(',') != -1)
                            author_name = message.author_id[1].split(',')[1].trim();
                        
                        var value = {
                            'message': message.body,
                            'author' : author_name,
                            'create_date' : message_create_date.fromNow(),
                            'photo_link' : "/web/image?model=res.partner&id="+message.author_id[0]+"&field=image_small",
                            'utc_time' : moment(message.create_date).format(),
                            'id' : message.id
                        };
                        self.append_message(value);

                        if (self.parent.modified_date < message_create_date) {
                            self.parent.modified_date = message_create_date;
                        }
                    });
                }).done(function() {
                    var temp = "Last Modified at " + self.parent.modified_date.fromNow();
                    self.parent.$(".last_modified_time").text(temp);
                });
            }
        },
        o_composer_text_field_keyup: function(e) {
            if (e.currentTarget.value.length != 0)
                this.$('.o_comment_box_send').attr('disabled', false);
            else
                this.$('.o_comment_box_send').attr('disabled', true);
            var text = this.$(".o_composer_text_field");
            text.css({ 'height': '1px' });
            text.css({ 'height': e.currentTarget.scrollHeight + "px" });
        },
        do_toggle: function(el) {
            el.hasClass("o_hidden") ? this.parent.dialog_temp = 1 : this.parent.dialog_temp = 0;
            el.hasClass("o_hidden") ? el.removeClass('o_hidden') : el.addClass('o_hidden');
        },
        o_annoted_circle_click: function() {
            this.parent.clear_all(this.chatter_Values.circle_db_id);
            this.do_toggle(this.commentbox_ele);
            this.parent.comment_box_position(this);
            this.$('.o_composer_text_field').focus();

            //////////////// Adding user (Follower only) to Read List if not.

            var read_object = $("div[data-id=" + this.chatter_Values.circle_db_id + "]").find('i');
            var followers_list = followers.split(" ");
            var res = $.inArray(String(session.partner_id), followers_list);

            if (read_object[0] != undefined && res > 0) {

                var circle_model = new Model('mail.imageeditor.circle');
                var domain = [
                    ['id', '=', this.chatter_Values.circle_db_id]
                ]
                var current_followers = "";
                var self = this;
                circle_model.call('search_read', [domain]).then(function(result) {
                    current_followers = result[0].who_read;
                }).done(function() {
                    circle_model.call('write', [
                        [self.chatter_Values.circle_db_id], { 'who_read': current_followers + " " + session.partner_id }
                    ]);
                });
                read_object.addClass('o_hidden');
                self.parent.messagetile_child[self.chatter_Values.circle_db_id].unread = false;
            }
            ///////////////////////////////////////////////////////////////////
        },
        o_image_editor_rectangle_click: function() {
            this.o_annoted_circle_click();
        },
        o_comment_box_close_click: function() {
            if (this.chatter_Values.circle_db_id != 0)
                this.commentbox_ele.addClass('o_hidden');
            else {
                delete this.parent.chatter_child[0];
                this.$el.remove();
            }
            this.parent.dialog_temp = 0;
        },
        render_message: function() {
            this.chatter_div.empty();
            var message_template = QWeb.render("mail.imageeditor.message_template", {
                'messages': _.values(this.chatter_message_child)
            });
            this.chatter_div.append(message_template);
        },
        append_message: function(message_value) {
            this.chatter_message_child[message_value.id] = message_value;
            this.render_message();
        },
        save_message: function(circle_id, message_value) {
            this.mess_values = {
                "circle_id": circle_id,
                "body": message_value.message,
                "author_id": session.partner_id
            };
            this.image_editor_model_message = new Model('mail.imageeditor.message');
            var self = this;
            self.image_editor_model_message.call('create', [self.mess_values]).then(function(res) {
                message_value.id = res;
                self.append_message(message_value);
            });
        },
        o_comment_box_send_click: function(e) {
            var chatbox = this.$(".o_composer_text_field");
            var message = chatbox.val().trim();
            if (message == "") return;

            chatbox.val('');
            this.$('.o_comment_box_send').attr('disabled', true);
            this.o_composer_text_field_keyup(e);
            this.$('.o_composer_text_field').focus();
            this.$('.o_composer_text_field').css({ "height": "22px" });

            var message_value = {
                'message': message,
                'author': session.name,
                'create_date': moment(new Date()).fromNow(),
                'photo_link': "/web/image?model=res.partner&id=" + session.partner_id + "&field=image_small",
                'utc_time': moment.utc(new Date()).format(),
            };

            var temp = "Last Modified at " + moment(new Date()).fromNow();
            this.parent.$(".last_modified_time").text(temp);

            if (this.chatter_Values.circle_db_id == 0) {
                this.image_editor_model_circle = new Model('mail.imageeditor.circle');
                this.chatter_Values.author_id = session.partner_id;
                this.chatter_Values.subject = message;

                var values = {
                    "attachment_id": this.parent.att_id,
                    "top_cord": this.chatter_Values.circle_top,
                    "left_cord": this.chatter_Values.circle_left,
                    "color": this.chatter_Values.circle_color,
                    "subject": this.chatter_Values.subject,
                    "div_height": this.chatter_Values.div_height,
                    "div_width": this.chatter_Values.div_width,
                    "author_id": session.partner_id,
                    "rectangle_top": this.chatter_Values.rectangle_top,
                    "rectangle_left": this.chatter_Values.rectangle_left,
                    "rectangle_width": this.chatter_Values.rectangle_width,
                    "rectangle_height": this.chatter_Values.rectangle_height,
                };
                var self = this;

                this.image_editor_model_circle.call('create', [values]).then(function(res) {
                    self.chatter_Values.circle_db_id = res;
                    self.parent.chatter_child[res] = self;
                    self.save_message(self.chatter_Values.circle_db_id, message_value);
                }).done(function() {
                    self.parent.messagetile_child[self.chatter_Values.circle_db_id] = {
                        'id': self.chatter_Values.circle_db_id,
                        'color': self.parent.circle_color_class + self.chatter_Values.circle_color,
                        'author_name': session.name,
                        'messsage': self.chatter_Values.subject,
                        'comment_num': self.parent.comment_num,
                        'create_date': moment(new Date()).fromNow(),
                        'resolve': false,
                        'utc_time': moment.utc(new Date()).format(),
                        'unread': false,
                    };

                    //////////// writing default Read User / Creator.
                    var circle_model = new Model('mail.imageeditor.circle');
                    circle_model.call('write', [
                        [self.chatter_Values.circle_db_id],
                        { 'who_read': session.partner_id }
                    ]);
                    ////////////////////////////////////////////////// 

                    self.parent.$('.num_of_comments').text(self.parent.comment_num + " Comments");
                    self.parent.comment_num++;
                    self.parent.render_messagetile();
                    self.parent.comment_area_div.animate({
                        scrollTop: self.parent.comment_area_div.get(0).scrollHeight
                    }, 300);
                    self.$('.resolve_btn').removeClass('o_hidden');
                    delete self.parent.chatter_child[0];
                });
            } else {
                this.save_message(this.chatter_Values.circle_db_id, message_value);
                //////////// writing default Read User / Creator.
                    var circle_model = new Model('mail.imageeditor.circle');
                    circle_model.call('write', [
                        [this.chatter_Values.circle_db_id],
                        { 'who_read': session.partner_id }
                    ]);
                ////////////////////////////////////////////////// 

            }
            this.parent.comment_box_position(this);
            this.$('.panel-body').animate({
                scrollTop: this.chatter_div.get(0).scrollHeight
            }, 300);
        },
        resolve_btn_click: function() {
            this.chatter_Values.resolve = !(this.chatter_Values.resolve);
            this.resolve_state();
            this.parent.messagetile_child[this.chatter_Values.circle_db_id].resolve = this.chatter_Values.resolve;
            this.parent.render_messagetile();
            var Model_save_state = new Model('mail.imageeditor.circle');
            Model_save_state.call('write', [
                [this.chatter_Values.circle_db_id], { 'resolve': this.chatter_Values.resolve }
            ]);
        },
        resolve_state: function() {
            if (this.chatter_Values.resolve) {
                this.$('.resolve_btn').css({ 'color': '#21b799' });
                this.circle_ele.css({ 'opacity': 0.5 });
                this.rectangle_ele.css({ 'opacity': 0.5 });
                this.$('.panel-footer').addClass('o_hidden');
                this.$('.resolved_text').removeClass('o_hidden');
            } else {
                this.$('.resolve_btn').css({ 'color': '#afafaf' });
                this.circle_ele.css({ 'opacity': 1 });
                this.rectangle_ele.css({ 'opacity': 1 });
                this.$('.resolved_text').addClass('o_hidden');
                this.$('.panel-footer').removeClass('o_hidden');
            }
        },
        color_picker_all_click: function(e) {
            var color = this.$(e.target).data("color");
            var newcolor = this.parent.circle_color_class + color;
            var oldcolor = this.parent.circle_color_class + this.chatter_Values.circle_color;
            this.circle_ele.removeClass(oldcolor).addClass(newcolor);
            this.$(".color_picker_selected").removeClass(oldcolor).addClass(newcolor);
            this.rectangle_ele.removeClass(this.parent.rectangle_color_class + this.chatter_Values.circle_color).addClass(this.parent.rectangle_color_class + color);
            this.chatter_Values.circle_color = color;
            var Model_save_color = new Model('mail.imageeditor.circle');
            Model_save_color.call('write', [
                [this.chatter_Values.circle_db_id], { 'color': color }
            ]);

            if (this.chatter_Values.circle_db_id != 0) {
                this.parent.messagetile_child[this.chatter_Values.circle_db_id].color = newcolor;
                this.parent.render_messagetile();
            }
        },
    });
    return ImageEditor;
});