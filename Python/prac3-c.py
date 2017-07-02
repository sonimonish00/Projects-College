"""
Define a simple "spelling correction" function correct() that takes a string and sees to it that
1) two or more occurrences of the space character is compressed into one, and
2) inserts an extra space after a period if the period is directly followed by a letter.
E.g. correct("This is very funny and cool.Indeed!") should return "This is very funny and cool. Indeed!"

"""
import string
import re

def correct(str):
    str = ' '.join(str.split())
    # r'expression' = 1.Search Pattern 2. New Pattern 3. String
    # \1 is Backreference to match the remaining portion after period
    #sub is to match and replace
    str = re.sub(r'\.([a-zA-Z])', r'. \1', str)
    print(str)
def main():
    a = input("Enter the Sentence : ")
    correct(a)
    
if __name__ == "__main__":
	main()

