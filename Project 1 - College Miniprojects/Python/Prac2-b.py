"""
Define a function overlapping() that takes two Strings and returns True if they have at least one member in common, False otherwise. Achieve the task without using inbuilt function.
"""
def overlapping(a,b):
    for i in a:
        for j in b:
            if i==j:
                return True
    return False 

def main():
    a = input("Enter the String 1: ")
    b = input("Enter the String 2: ")
    if (overlapping(a,b) == True):
        print("Yes At least One Member is Found Matching")

if __name__ == "__main__":
	main()
    
