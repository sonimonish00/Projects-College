"""
	Write a program which will find all such numbers which are divisible by 3 but are not a multiple of 6, between 100 and 1000 (both included).The numbers obtained should be printed in a comma-separated sequence on a single line.
	
"""

def main():
    print("Printing Numbers between 100 to 1000 which are divisible by 3 but not multiple of 6")
    for i in range(100,1001):
        if i%3==0 and i%2!=0:
            print("{},".format(i),end='')
        
if __name__ == "__main__":
    main()
