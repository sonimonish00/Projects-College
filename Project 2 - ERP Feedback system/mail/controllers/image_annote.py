import json
# from openerp import http
from odoo import api, http
from odoo.http import request

@http.route('/mail/imageeditor', type='json', auth='user')
def imageeditor(self):
    return "{ name : 'Hello' }"