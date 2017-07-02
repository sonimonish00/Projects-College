""" 
Write a program that asks the user to enter an integer and prints power of the same.
"""
def main():
    a = eval(input("Enter an Integer :"))
    print("The Power of {} is {}".format(a,a**a))
    
if __name__ == "__main__":
    main()
