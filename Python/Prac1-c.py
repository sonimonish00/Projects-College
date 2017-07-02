"""
Define a procedure histogram() that takes a list of integers and prints a histogram to the screen. For example, histogram([4, 9, 7]) should print the following:

****
*********
*******

"""
# args used to pass a non-keyworded, variable-length argument list,
def histogram(myList = [], *args):
    """
	This Definition Will Print Histogram on Screen based on the input of list Given
	in the program.
    """
    for x in myList:
        for j in range(0,x):
            print("*",end="")
        print()
        
# Our Main Function Calling Histogram Function by passing list as an Argument
def main():
	arr = list(map(int,input().split()))
	histogram(arr)

if __name__ == "__main__":
	main()
    
