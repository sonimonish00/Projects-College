from odoo import _, api, fields, models
from odoo import tools

class Circle(models.Model):
	_name = "mail.imageeditor.circle"	

	attachment_id = fields.Many2one('ir.attachment');
	
	top_cord = fields.Integer()
	left_cord = fields.Integer()
	rectangle_top = fields.Integer()
	rectangle_left = fields.Integer()
	rectangle_width = fields.Integer()
	rectangle_height = fields.Integer()
	
	color = fields.Integer()
	resolve = fields.Boolean()
	author_id = fields.Many2one('res.partner')
	subject = fields.Char()
	message_ids = fields.One2many("mail.imageeditor.message",'circle_id')
	div_height = fields.Integer()
	div_width = fields.Integer()
	
	page_number = fields.Integer()

	who_read = fields.Char()

class Message(models.Model):
	_name = "mail.imageeditor.message"
	
	author_id = fields.Many2one('res.partner')
	body = fields.Char()
	circle_id = fields.Many2one('mail.imageeditor.circle');

class ImageFollowers(models.Model):
	_name = "mail.imageeditor.followers"
	_inherit = "mail.thread"

	followers_id = fields.Char();