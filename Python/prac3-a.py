"""
Write a function filter_long_words() that takes a list of words and an integer n and returns the list of words that are longer than n
"""

def filter_long_words(str,num):
    b = []
    for i in str:
        if len(i) > num :
            b.append(i)
    print(b)
def main():
    print("Enter the list of words by giving space between: ")
    a = [str(x) for x in input().split()]
    b = eval(input("Enter the Length of Integer: "))
    filter_long_words(a,b)

if __name__ == "__main__":
	main()
