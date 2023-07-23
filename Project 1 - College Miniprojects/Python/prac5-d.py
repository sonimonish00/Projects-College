"""
Extract the list of students having length of name is exactly 6.
"""
import re

list1 = []
with open('E:\sample.txt') as f,open('E:\output3.txt','w+') as f1:
	for line in f:
		matchobj = re.search(r'\d{12}', line)
		if (matchobj):
			name6 = re.search(r'\b[A-Z]{6}\b', line,re.I)
			if (name6):
				print(name6.group())

