"""
Extract list of enrolment number, sort it in descending order and store it in a new file
"""
import re

list1 = []
with open('E:\sample.txt') as f,open('E:\output1.txt','w+') as f1:
	for line in f:
		enroll = re.findall(r'\d{12}', line)
		if not enroll:
			continue
		else:
			list1.append(enroll[0])

	#Descending Order
	list1.sort(reverse=True)
	for i in list1:
		f1.write("{0}\n".format(i))

