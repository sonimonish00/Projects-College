"""
Extract email addresses from the sample.txt file , and store it in new file.
"""
import re

list1 = []
with open('E:\sample.txt') as f,open('E:\output2.txt','w+') as f1:
	for line in f:
		email = re.findall(r'[\w\.-]+@[\w\.-]+', line)
		if not email:
			continue
		else:
			list1.append(email[0])

	for i in list1:
		f1.write("{0}\n".format(i))

