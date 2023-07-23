"""
Write a function translate() that will translate a text into "rövarspråket" (Swedish for "robber's language"). That is, double every consonant and place an occurrence of "o" in between. For example, translate("this is fun") should return the string "tothohisos isos fofunon".
"""
def translate(str):
    c = ""
    for first in str:
        if first in ('a', 'e', 'i', 'o', 'u',' '):
            c+=first
        else:
            c+=first+'o'+first
    print("The String is: "+c)

def main():
    a = input("Enter the String: ")
    translate(a)

if __name__ == "__main__":
	main()
    
