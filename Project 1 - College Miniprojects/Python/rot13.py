""" 
The Following Program is Implemetation of ROT13 Symmetric Cipher Algo.
This is an Improved version of Ceaser Cipher  
"""

def rot13(msg):

	dictionary = {'a':'n', 'b':'o', 'c':'p',
	             'd':'q', 'e':'r', 'f':'s',
	             'g':'t','h':'u','i':'v',
	             'j':'w', 'k':'x','l':'y',
	             'm':'z','n':'a','o':'b',
	             'p':'c','q':'d','r':'e',
	             's':'f','t':'g','u':'h',
	             'v':'i', 'w':'j','x':'k',
	             'y':'l','z':'m'}
	rot13 = ''
	for c in msg:
		if c.islower():
			rot13 += dictionary.get(c)
		if c.isupper():
			c = c.lower()
			rot13 += dictionary.get(c).capitalize()
		if c not in dictionary:
			rot13 += c 
	return rot13

def main():
    plaintext = input("Enter The plain Text: ")
    cipher = rot13(plaintext)
    print("Rotted Cipher is : "+cipher) 

if __name__ == "__main__":
    main()
