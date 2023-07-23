odoo.define('mail.PDFEditor', function(require) {
    "use strict";   

    var core = require('web.core');
    var Widget = require('web.Widget');
    var Model = require('web.Model');
    var session = require('web.session');
    var utils = require('web.utils');

    var QWeb = core.qweb;
    var _t = core._t;
    var followers = "";

    var PDFEditor = Widget.extend({
        template: 'mail.ChatThread.ImageEditor',
        events: {
            'click .o_close_editor': 'on_editor_close_click',
            'click .share_image': 'share_image_click',
            'click .o-comment-card': 'o_comment_card_click',
            'click .o_editor_hide_annotation_btn': 'btn_show_hide_click',
            'click .color_picker_all_menubar': 'color_picker_all_menubar_click',
            'click .hide_comments_area': 'hide_comments_area_click',
            'mouseover .o-comment-card': 'o_comment_card_hover',
            'mouseout .o-comment-card': 'o_comment_card_mouseout',
        },
        init: function(parent, att_id, att_name,att_type) {
            this.att_id = att_id;
            this.att_name = att_name;
            this.att_type = att_type;

            this.download_link = "/web/image/" + att_id + "?download=true";
            this.messagetile_child = {};
            
            this.chatter_child = {};
            this.chatter_child_object = {};
            
            this.partner_id = session.partner_id;

            this.comment_num = 1;
            this.pointer_color = 1;

            this.annotation_state = "show_annotation";
            this.modified_date = moment.utc('1981-01-01').local();
            return this._super();
        },
        start: function() {

            var circle_color = utils.get_cookie("image_editor_circle_color");
            if (circle_color > 1) {
                this.pointer_color = circle_color;
                this.set_color_picker();
            }

            this.$iframe = $('#pdfs');
            this.waitForPDF();
            this.fatch_db_data();
            return this._super().then(function() {
                //self.$('[data-toggle="tooltip"]').tooltip();
            });
        },
        waitForPDF: function() {
            var nbPages = this.$iframe.contents().find('.page').length;
            var nbLayers = this.$iframe.contents().find('.textLayer').length;
            if(nbPages > 0 && nbLayers > 0) {
                this.nbPages = nbPages;
                this.init_annotations();
            } else {
                var self = this;
                setTimeout(function() { self.waitForPDF(); }, 50);
            }
        },

        fatch_db_data: function(){
            this.image_editor_circle_model = new Model('mail.imageeditor.circle');
            var domain = [
                ['attachment_id', '=', this.att_id]
            ];
            var self = this;
            this.comment_num = 1;
            this.image_editor_circle_model.call('search_read', [domain]).then(function(result) {
                _.each(result, function(circle) {
                    var circle_values = {
                        'circle_db_id': circle.id,
                        'circle_top': circle.top_cord ,
                        'circle_left': circle.left_cord,
                        'circle_color': circle.color,
                        'resolve': circle.resolve,
                        'author_id': circle.author_id,
                        'subject': circle.subject,
                        'hide_state': true,
                        'page_number' : circle.page_number,
                        'message' : [],
                        'div_width' : circle.div_width,
                        'div_height' : circle.div_height,
                        'comment_num' : self.comment_num,
                    };
                    self.chatter_child[circle.id] = circle_values;
                    self.messagetile_child[circle.id] = {
                            'id' : circle.id,
                            'color': "circle_color_" +circle.color,
                            'author_name': circle.author_id[1],
                            'messsage': circle.subject,
                            'comment_num': self.comment_num,
                            'create_date': moment.utc(circle.create_date).local().fromNow(),
                            'resolve': circle.resolve,
                            'utc_time': moment.utc(circle.create_date).format(),
                            'unread': false,
                            'comment_num' : self.comment_num,
                    };
                    self.comment_num++;
                });
            }).done(function(){
                self.image_editor_message_model = new Model('mail.imageeditor.message');
                
                _.each(_.values(self.chatter_child),function(chatter){
                    var domain = [
                        ['circle_id', '=', chatter.circle_db_id]
                    ];
                    self.image_editor_message_model.call('search_read', [domain]).then(function(result) {
                        _.each(result, function(message) {
                            var message_create_date = moment.utc(message.create_date).local();
                            var value = {
                                'message': message.body,
                                'author' : message.author_id[1],
                                'create_date' : message_create_date.fromNow(),
                                'photo_link' : "/web/image?model=res.partner&id="+message.author_id[0]+"&field=image_small",
                                'utc_time' : moment(message.create_date).format(),
                                'id' : message.id
                            };
                            self.chatter_child[chatter.circle_db_id].message.push(value);
                            var message_create_date = moment.utc(message.create_date).local();

                            if (self.modified_date < message_create_date) {
                               self.modified_date = message_create_date;
                        }
                        });
                    }).done(function(){
                        var temp = "Last Modified at " + self.modified_date.fromNow();
                        self.$(".last_modified_time").text(temp);
                    });
                });
            });
        },
        init_annotations: function(e){
            var $cssLink = $("<link/>", {
                rel: "stylesheet", type: "text/css",
                href: "/mail/static/src/less/pdf_editor.css"
            });

            var $bootLink = $("<link/>", {
                rel: "stylesheet", type: "text/css",
                href: "/web/static/lib/bootstrap/css/bootstrap.css"
            });

            var $jqueryLink = $("<link/>", {
                rel: "stylesheet", type: "text/css",
                href: "/web/static/lib/jquery.ui/jquery-ui.css"
            });
            var $jqueryScript = $("<script></script>", {
                type: "text/javascript",
                src: "/web/static/lib/jquery.ui/jquery-ui.js"
            });

            var $fontawesome = $("<link/>", {
                rel: "stylesheet", type: "text/css",
                href: "/web/static/lib/fontawesome/css/font-awesome.css"
            });

            var self =this;
            this.pdfFrame = $('#pdfs');
            this.pdfFrame.contents().find('head').append($cssLink , $bootLink , $jqueryLink , $jqueryScript , $fontawesome);

            _.each(_.range(1,self.nbPages+1),function(pageNum){
                var currentPageNum = pageNum;
                var currentPage = $('#pdfs').contents().find("#pageContainer"+currentPageNum);
                $(currentPage).on('click',function(e){
                    
                    if(self.annotation_state == "hide_annotation"){
                        return;
                    }

                    _.each(_.values(self.chatter_child_object),function(chatter){
                        chatter.$('.o_comment_box_root').css({
                            'display' : 'none',
                        });
                        if(self.chatter_child[chatter.chatter_Values.circle_db_id])
                            self.chatter_child[chatter.chatter_Values.circle_db_id].hide_state = true;
                    });
                    
                    e.stopPropagation();
                    var offset = currentPage.offset();
                    var left = e.pageX - offset.left;
                    var top = e.pageY - offset.top;

                    var chatter_value = {
                        'circle_db_id': 0,
                        'circle_top': top - 17,
                        'circle_left': left - 17,
                        'circle_color': self.pointer_color,
                        'resolve': false,
                        'author_id': self.partner_id,
                        'subject': '',
                        'hide_state': false,
                        'page_number' : currentPageNum,
                        'message' : [],
                        'div_width' : currentPage.innerWidth(),
                        'div_height' : currentPage.innerHeight(),
                        'comment_num' : self.comment_num,
                    };
                    if(!self.chatter_child[0]){
                        var chatter = new Chatter(chatter_value);
                        chatter.appendTo(currentPage);
                        chatter.$('.o_annoted_circle').addClass("circle_color_"+chatter.chatter_Values.circle_color);
                        chatter.$('.resolve_btn').addClass('o_hidden');
                        self.init_chatter(chatter);
                        self.chatter_child[0] = chatter_value;
                        self.chatter_temp = chatter;
                    }else{
                        self.chatter_temp.$('.o_comment_box_close').trigger('click');
                        delete self.chatter_child[0];
                    }
                });
            });
            
            refresh_interval();
            function refresh_interval() {
                try { // if an error occurs it means the iframe has been detach and will be reinitialized anyway (so the interval must stop)
                    self.refreshChatterItems();
                    self.refresh_timer = setTimeout(refresh_interval, 2000);
                } catch (e) {}
            }
        },

        render_messagetile: function() {
            this.$('.o-comments-area').empty();
            var messagetile_template = QWeb.render("mail.ChatThread.ImageEditor.MessageTile", { 'messagetiles': _.values(this.messagetile_child) });
            this.$('.o-comments-area').append(messagetile_template);
        },
        render_message: function(chatter){
            chatter.$(".o_comment_box_chatter_div").empty();
            var message_template = QWeb.render("mail.imageeditor.message_template", {
                'messages': chatter.chatter_Values.message,
            });
            chatter.$(".o_comment_box_chatter_div").append(message_template);
        },
        create_chatter: function(chatter_value){
            var currentPage = this.pdfFrame.contents().find("#pageContainer"+chatter_value.page_number);
            var chatter = new Chatter(chatter_value);
            chatter.appendTo(currentPage);

            if(chatter_value.circle_db_id == 0)
                this.chatter_temp = chatter;
            else
                this.chatter_child_object[chatter_value.circle_db_id] = chatter;
                
            chatter.$('.o_annoted_circle').addClass("circle_color_"+chatter_value.circle_color);
            if(chatter_value.hide_state){
                chatter.$('.o_comment_box_root').css({
                        'display' : 'none',
                });
            }

            if (chatter.chatter_Values.resolve) {
                    chatter.$('.resolve_btn').css({ 'color': '#21b799' });
                    chatter.$('.o_annoted_circle').css({ 'opacity': 0.5 });
                    chatter.$('.panel-footer').addClass('o_hidden');
                    chatter.$('.resolved_text').removeClass('o_hidden');
            }

            this.o_image_annoted_div_resize(chatter);
            this.render_message(chatter);
            this.render_messagetile();
            this.init_chatter(chatter);
        },
        refreshChatterItems : function(e){
            var self = this;
            _.each(_.values(this.chatter_child),function(chatter){
                var currentPage = $('#pdfs').contents().find("#pageContainer"+chatter.page_number);
                var ele = _.filter(currentPage.find( ".o_annoted_circle" ), function(element){ return ($(element).attr('id') == chatter.circle_db_id) /*&& ($(element).attr('id') != 0)*/ });
                if(ele.length == 0){
                    try{
                        self.create_chatter(chatter);
                    }catch(e){}
                }
            });
        },
        init_chatter: function(chatter){
            var self = this;
            chatter.$('.o_comment_box_close').on('click',function(e){
                if(self.chatter_child[chatter.chatter_Values.circle_db_id])
                    self.chatter_child[chatter.chatter_Values.circle_db_id].hide_state = true;
                
                if(chatter.chatter_Values.circle_db_id != 0){
                    chatter.$('.o_comment_box_root').css({
                        'display' : 'none',
                    });
                }else{
                    e.stopPropagation();
                    chatter.$('.o_comment_box_root').css({
                        'display' : 'none',
                    });
                    chatter.$('.o_annoted_circle').css({
                        'display' : 'none',
                    });
                    delete self.chatter_child[0];
                }
            });

            chatter.$('.o_comment_box_root').on('click',function(e){
                e.stopPropagation();
            });

            chatter.$('.o_annoted_circle').on('click',function(e){
                if(self.chatter_temp)
                    self.chatter_temp.$('.o_comment_box_close').trigger('click');
                
                _.each(_.values(self.chatter_child_object),function(chatter){
                    chatter.$('.o_comment_box_root').css({
                        'display' : 'none',
                    });
                    if(self.chatter_child[chatter.chatter_Values.circle_db_id])
                        self.chatter_child[chatter.chatter_Values.circle_db_id].hide_state = true;
                });

                chatter.$('.o_comment_box_root').css({
                    'display' : 'block',
                });

                chatter.$('.o_composer_text_field').focus();
                e.stopPropagation();
            });
            
            chatter.$('.resolve_btn').on('click',function(e){
                chatter.chatter_Values.resolve = !(chatter.chatter_Values.resolve);
               
                if (chatter.chatter_Values.resolve) {
                    chatter.$('.resolve_btn').css({ 'color': '#21b799' });
                    chatter.$('.o_annoted_circle').css({ 'opacity': 0.5 });
                    chatter.$('.panel-footer').addClass('o_hidden');
                    chatter.$('.resolved_text').removeClass('o_hidden');
                } else {
                    chatter.$('.resolve_btn').css({ 'color': '#afafaf' });
                    chatter.$('.o_annoted_circle').css({ 'opacity': 1 });
                    chatter.$('.resolved_text').addClass('o_hidden');
                    chatter.$('.panel-footer').removeClass('o_hidden');
                }
                self.messagetile_child[chatter.chatter_Values.circle_db_id].resolve = chatter.chatter_Values.resolve;
                self.render_messagetile();
                var Model_save_state = new Model('mail.imageeditor.circle');
                Model_save_state.call('write', [
                    [chatter.chatter_Values.circle_db_id], { 'resolve': chatter.chatter_Values.resolve }
                ]);
            });

            chatter.$('.color_picker_comment').on('click',function(e){
                self.color_picker_temp = !self.color_picker_temp;
                if(self.color_picker_temp){
                    chatter.$('.color-picker-dropdown-menu').css({
                        'display' : 'block'
                    });
                }else{
                    chatter.$('.color-picker-dropdown-menu').css({
                        'display' : 'none'
                    });
                }
            });     

            chatter.$('.color_picker_all').on('click',function(e){
                var color = chatter.$(e.target).data("color");
                var newcolor = "circle_color_" + color;
                var oldcolor =  "circle_color_" + chatter.chatter_Values.circle_color;
                chatter.$('.o_annoted_circle').removeClass(oldcolor).addClass(newcolor);
                chatter.$(".color_picker_selected").removeClass(oldcolor).addClass(newcolor);
                
                chatter.chatter_Values.circle_color = color;
                var Model_save_color = new Model('mail.imageeditor.circle');
                Model_save_color.call('write', [
                    [chatter.chatter_Values.circle_db_id], { 'color': color }
                ]);

                if (chatter.chatter_Values.circle_db_id != 0) {
                    self.messagetile_child[chatter.chatter_Values.circle_db_id].color = newcolor;
                    self.render_messagetile();
                }
                self.color_picker_temp = !self.color_picker_temp;
                chatter.$('.color-picker-dropdown-menu').css({
                    'display' : 'none'
                });
            });

            chatter.$('.o_composer_text_field').on('keyup',function(e){
                if (e.currentTarget.value.length != 0)
                    chatter.$('.o_comment_box_send').attr('disabled', false);
                else
                    chatter.$('.o_comment_box_send').attr('disabled', true);
                var text = chatter.$(".o_composer_text_field");
                text.css({ 'height': '1px' });
                text.css({ 'height': e.currentTarget.scrollHeight + "px" });
            });

            chatter.$('.o_comment_box_send').on('click',function(e){
                var chatbox = chatter.$('.o_composer_text_field');
                var message = chatbox.val().trim();
                chatbox.val('');
              
                chatter.$('.o_comment_box_send').attr('disabled', true);
                chatter.$('.o_composer_text_field').focus();
                chatter.$('.o_composer_text_field').css({ "height": "22px" });

                if(message == ""){return}
                self.image_editor_message_model = new Model('mail.imageeditor.message');

                var temp = "Last Modified at " + moment(new Date()).fromNow();
                self.$(".last_modified_time").text(temp);

                if(chatter.chatter_Values.circle_db_id == 0){
                    self.image_editor_model_circle = new Model('mail.imageeditor.circle');
                    var values = {
                        "attachment_id": self.att_id,
                        "top_cord": chatter.chatter_Values.circle_top,
                        "left_cord": chatter.chatter_Values.circle_left,
                        "color": chatter.chatter_Values.circle_color,
                        "subject": message,
                        "div_height": chatter.chatter_Values.div_height,
                        "div_width": chatter.chatter_Values.div_width,
                        "author_id": self.partner_id,
                        "page_number" : chatter.chatter_Values.page_number,
                    };

                    self.image_editor_model_circle.call('create', [values]).then(function(res) {
                        chatter.chatter_Values.circle_db_id = res;
                        self.chatter_child_object[res] = chatter;
                        chatter.$('.resolve_btn').removeClass('o_hidden');
                        delete self.chatter_child[0];
                        self.chatter_child[res] = chatter.chatter_Values;
                        chatter.$('.o_annoted_circle').attr('id',res);

                        var value = {
                            'body' : message,
                            'author_id' : self.partner_id,
                            'circle_id' : res,
                        };
                        self.image_editor_message_model.call('create', [value]).then(function(res) {});
                        
                        self.messagetile_child[chatter.chatter_Values.circle_db_id] = {
                            'id' : chatter.chatter_Values.circle_db_id,
                            'color': "circle_color_"+chatter.chatter_Values.circle_color,
                            'author_name': session.name,
                            'messsage': message,
                            'comment_num': 1,
                            'create_date': moment(new Date()).fromNow(),
                            'resolve': false,
                            'utc_time': moment.utc(new Date()).format(),
                            'unread': false,
                            'comment_num' : self.comment_num,
                        };
                        self.comment_num++;
                        self.render_messagetile();

                        var message_value = {
                            'message': message,
                            'author': session.name,
                            'create_date': moment(new Date()).fromNow(),
                            'photo_link': "/web/image?model=res.partner&id=" + self.partner_id + "&field=image_small",
                            'utc_time': moment.utc(new Date()).format(),
                        };
                        self.chatter_child[res].message.push(message_value);
                        chatter.chatter_Values = self.chatter_child[res];
                        self.render_message(chatter);
                    });
                }else{
                    var message_value = {
                            'body' : message,
                            'author_id' : self.partner_id,
                            'circle_id' : chatter.chatter_Values.circle_db_id,
                    };
                    self.image_editor_message_model.call('create', [message_value]).then(function(res) {});

                    var message_value = {
                        'message': message,
                        'author': session.name,
                        'create_date': moment(new Date()).fromNow(),
                        'photo_link': "/web/image?model=res.partner&id=" + self.partner_id + "&field=image_small",
                        'utc_time': moment.utc(new Date()).format(),
                    };
                    self.chatter_child[chatter.chatter_Values.circle_db_id].message.push(message_value);
                    chatter.chatter_Values = self.chatter_child[chatter.chatter_Values.circle_db_id];
                    self.render_message(chatter);
                }
            });
        },
        o_image_annoted_div_resize: function(chatter) {
            var currentPage = $('#pdfs').contents().find("#pageContainer"+chatter.chatter_Values.page_number);
            var current_div_height = currentPage.innerHeight();
            var current_div_width = currentPage.innerWidth();
            
            var new_top = (current_div_height * chatter.chatter_Values.circle_top) / (chatter.chatter_Values.div_height);
            var new_left = (current_div_width * chatter.chatter_Values.circle_left) / (chatter.chatter_Values.div_width);


            chatter.$('.o_annoted_circle').css({ 'top': new_top, 'left': new_left });
            chatter.$('.o_comment_box_root').css({ 'top': new_top - 20, 'left': new_left + 35 });
        },
        on_editor_close_click: function() {
            clearTimeout(this.refresh_timer);
            this.destroy();
        },
        share_image_click: function(e){
            var link = document.createElement("input");
            document.body.appendChild(link);
            link.setAttribute("id", "image_link");
            document.getElementById("image_link").value = window.location.href + "&pdf_id=" + this.att_id;
            link.select();
            document.execCommand("copy");
            document.body.removeChild(link);

            this.$(".link_notify").fadeIn("show");

            setTimeout(function() {
                $(".link_notify").fadeOut();
            }, 2000);
        },
        color_picker_all_menubar_click: function(e) {
            this.pointer_color = this.$(e.target).data("color");
            utils.set_cookie('image_editor_circle_color', this.pointer_color, 30 * 24 * 60 * 60);
            this.set_color_picker();
        },
        set_color_picker: function() {
            var oldclass = this.$(".color_picker_selected_menubar").attr("class").split(' ')[1];
            var newclass = "circle_color_" + this.pointer_color;
            this.$(".color_picker_selected_menubar").removeClass(oldclass).addClass(newclass);
        },
        o_comment_card_click: function(e){

            if(this.annotation_state == "hide_annotation"){
                return;
            }

            var chatter_id = $(e.currentTarget).data('id');
            var self = this;
            _.each(_.values(self.chatter_child_object),function(chatter){
                chatter.$('.o_comment_box_root').css({
                    'display' : 'none',
                });
                if(self.chatter_child[chatter.chatter_Values.circle_db_id])
                    self.chatter_child[chatter.chatter_Values.circle_db_id].hide_state = true;
            });

            self.chatter_child_object[chatter_id].$('.o_comment_box_root').css({
                    'display' : 'block',
            });
            var src = $('#pdfs').attr('src');

            var str = src.substring( 0, src.indexOf( "page=" ) ); //Remove page=1 segment
            str = str+'page='+self.chatter_child[chatter_id].page_number; //Add new page=x segment
            $('#pdfs').attr('src', str); //Set new iframe src
        },
        o_comment_card_hover: function(e) {
            this.chatter_hover_id = $(e.currentTarget).data('id');
            this.chatter_child_object[this.chatter_hover_id].$('.o_annoted_circle').addClass("o_annoted_circle_card_hover");
        },
        o_comment_card_mouseout: function() {
            this.chatter_child_object[this.chatter_hover_id].$('.o_annoted_circle').removeClass("o_annoted_circle_card_hover");
        },
        hide_comments_area_click: function(){
            var title;
            this.hide_comment_area_temp ? title = "Hide Comments" : title = "Show Comments";
            this.hide_comment_area_temp = !(this.hide_comment_area_temp);

           // this.$("#hide_comments_area_icon").attr('title', title).tooltip('fixTitle').tooltip('show');
            this.$("#hide_comment_icon").toggleClass("fa-angle-up fa-angle-down");
            this.$('#o-sidebar_id').slideToggle();
            setTimeout(function() {
                this.$('#o-image-editor_id').toggleClass('col-md-12 col-md-9');
            }, 200);
        },
        hide_all: function(){
            var self = this;
            if(self.chatter_temp){
                    self.chatter_child_object[0] = self.chatter_temp;
                    delete self.chatter_child[0];
                    self.chatter_temp = null;
            }
            _.each(_.values(this.chatter_child_object),function(chatter){
                chatter.$('.o_comment_box_root').css({
                    'display' : 'none',
                });
                chatter.$('.o_annoted_circle').css({
                    'display' : 'none',
                });
                if(self.chatter_child[chatter.chatter_Values.circle_db_id])
                    self.chatter_child[chatter.chatter_Values.circle_db_id].hide_state = true;
            });
            clearTimeout(this.refresh_timer);
        },
        show_all: function(){
            var self = this;
            _.each(_.values(self.chatter_child_object),function(chatter){
                if(chatter.chatter_Values.circle_db_id != 0){
                    chatter.$('.o_comment_box_root').css({
                        'display' : 'none',
                    });
                    chatter.$('.o_annoted_circle').css({
                        'display' : 'block',
                    });
                }
            });
            refresh_interval();
            function refresh_interval() {
                try {
                    self.refreshChatterItems();
                    self.refresh_timer = setTimeout(refresh_interval, 2000);
                } catch (e) {}
            }
        },
        btn_show_hide_click: function(){
            var self = this;
            if(!this.hide_annotation_temp){
                self.annotation_state = "hide_annotation"
                self.hide_all();
            }else{
                self.annotation_state = "show_annotation"
                self.show_all();
            }
            this.hide_annotation_temp = !this.hide_annotation_temp;
        },
    });

    var Chatter = Widget.extend({
        template: 'mail.ChatThread.PDFEditor.Chatter',
        init: function(chatter_value) {
           this.chatter_Values = chatter_value;
        },
        start: function() {

        },
    });
    return PDFEditor;
});