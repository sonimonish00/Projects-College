"""
Companywise Min Salary

In the previous section, you wrote a program to read an input file and do some computation on the salary numbers 
contained in it. In this section, you have to modify your program so that for each company, 
it figures out what is the minimum salary in that company. Your program should then write the
 ”company-name min-salary” pairs to the output, one per line.

Thus, if input.txt contained:

Vineel Phatak, 520, Amkart, NOBODY
Ajay Joshi, 250, Amkart, Vineel Phatak
Abhishek Chauhan, 120, Amkart, Ajay Joshi
Jayesh Godse, 500, Airflix, NOBODY
Vijaya Mundada, 60, Amkart, Abhishek Chauhan
Shital Tuteja, 45, Airflix, Jayesh Godse
Rajan Gawli, 700, Amkart, Vineel Phatak
Sheila Rodrigues, 35, Amkart, Vineel Phatak
Zeba Khan, 300, Airflix, Jayesh Godse
Chaitali Sood, 100, Airflix, Zeba Khan

then, after your program runs, output.txt should contain:

Amkart 35
Airflix 45

"""
def main():
	list1 = []
	list2 = []
	list3 = []

	with open('E:\input.txt','r+') as f:
		for line in f:
			currentline = line.split(',')[2]
			list1.append(currentline) 
		list1 = list(set([x.strip(' ') for x in list1]))

	with open('E:\input.txt','r+')as f3:
		for line1 in f3:
			if list1[0] in line1:
				currsal = line1.split(',')[1]
				list2.append(int(currsal))
			elif list1[1] in line1:
				currsal = line1.split(',')[1]
				list3.append(int(currsal))
	list2.sort()
	list3.sort()

	with open('E:\output.txt','w+') as f1:
		f1.write("%s %d\n"%(list1[0],list2[0]))
		f1.write("%s %d"%(list1[1],list3[0]))

if __name__ == '__main__':
    main()
