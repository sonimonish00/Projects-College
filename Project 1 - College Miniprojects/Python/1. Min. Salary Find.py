"""
To find Minimum Salary 
INPUT:- 
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

OUTPUT :-
35
"""
def main():
	list1 = []
	#Ignore input.txt and output.txt path..i have already correcte those..but still got error
	with open('E:\input.txt','r+') as f,open('E:\output.txt','w+') as f1:
		for line in f:
			currentline = line.split(',')[1]
			list1.append(int(currentline))
		list1.sort()
		f1.write("%d"%list1[0])
		
if __name__ == '__main__':
    main()