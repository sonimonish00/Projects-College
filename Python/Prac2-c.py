"""
Write a version of a palindrome recognizer that also accepts phrase palindromes such as "Go hang a salami I'm a lasagna hog.", "Was it a rat I saw?", "Step on no pets", "Sit on a potato pan, Otis", "Lisa Bonet ate no basil", "Satan, oscillate my metallic sonatas", "I roamed under it as a tired nude Maori", "Rise to vote sir", or the exclamation "Dammit, I'm mad!". Note that punctuation, capitalization, and spacing are usually ignored.

"""
import string

def ispalindrome(str):
    punctuations = '''!()-[]{};:'"\,<>./?@#$%^&*_~'''

    #1. Remove punctuation from the string
    no_punc = ""
    for ch in str:
       if ch not in punctuations:
           no_punc+=ch
    
    #2. Remove Spacing - Indirect String Concatenation
    no_punc=no_punc.replace(" ","")

    #3. Converting All into Small Letters
    no_punc=no_punc.casefold()

    #4. Now Checking For Plaindrome or Not !!
    rev_str = reversed(no_punc)
    if list(no_punc) == list(rev_str):
        return True
    else:
        print("It is not palindrome")

def main():
    a = input("Enter the String 1: ")
    if (ispalindrome(a) == True):
        print("Yes!! The String is Palindrome")   

if __name__ == "__main__":
	main()

