"""
A pangram is a sentence that contains all the letters of the English alphabet at least once, for example: The quick brown fox jumps over the lazy dog. Your task here is to write a function to check a sentence to see if it is a pangram or not.
"""
def pangram(str):
    punctuations = '''!()-[]{};:'"\,<>./?@#$%^&*_~'''
    chars = "abcdefghijklmnopqrstuvwxyz"
    b = []
    #1. Remove punctuations from the string
    no_punc = ""
    for ch in str:
       if ch not in punctuations:
           no_punc+=ch
    
    #2. Remove Spacing & Numbers - Indirect String Concatenation
    no_punc=no_punc.replace(" ","")
    no_punc=''.join(i for i in no_punc if not i.isdigit())

    #3. Converting All into Small Letters
    no_punc=no_punc.casefold()

    #4. Our Main Logic to Check for Pangram of Sentence
    for char in chars:
        count = no_punc.count(char)
        # Fails the Test - Negation Statement Checking in IF condition
        if count < 1 :
            b.append(char)

    #5. Checking if list is empty or not to give final Answer
    if not b:
        return True
    else:
        False
        
def main():
    a = input("Enter the Sentence: ")
    if pangram(a) == True:
        print("The String is Pangram")
    else:
        print("The String is not Pangram")

if __name__ == "__main__":
	main()
