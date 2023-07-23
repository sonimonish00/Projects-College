"""
Write a program to print the processor detail and memory detail using file handling.
"""
import re

with open('/proc/cpuinfo') as f,open('/proc/meminfo') as f1:
	for line in f:
		if 'model name' in line:
			print(line)
			break
	for line1 in f1:
		if 'MemTotal' in line1:
			num1 = re.findall('\d+',line1)
			num1 = int(''.join(map(str,num1)))
			num2 = num1/1024
			print("MemTotal : {:.5f} GB".format(num2))
			break
