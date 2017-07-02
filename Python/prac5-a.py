"""
Extract the enrolment number of the students having “Patel” surname and store it in new file.
"""
import re

list1 = []
with open('E:\sample.txt') as f,open('E:\output.txt','w+') as f1:
	for line in f:
		if 'PATEL' in line:
			name = re.findall(r'[a-z]\w+',line,re.I)
			#Here we make a string of name
			name = ' '.join(name)
			# Now we remove what we dont need  - $ indicates end of string
			name = re.sub(' gmail com$', '', name)
			# Our Main Task to Find the Enrollment Number
			enroll = re.findall(r'\d{12}', line)[0]
			f1.write("{0}\n".format(enroll))

