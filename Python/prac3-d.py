"""
In English, the present participle is formed by adding the suffix -ing to the infinite form: go -> going. A simple set of heuristic rules can be given as follows:
• If the verb ends in e, drop the e and add ing (if not exception: be, see, flee, knee, etc.)
• If the verb ends in ie, change ie to y and add ing
• For words consisting of consonant-vowel-consonant, double the final letter before adding ing
• By default just add ing
Your task in this exercise is to define a function make_ing_form() which given a verb in infinitive form returns its present participle form. Test your function with words such as lie, see, move and hug. However, you must not expect such simple rules to work for all cases.

"""
def make_ing_form(str1):
	""" First of All Check infinitve form  : So we will check for If Else for This
		so in IF Condition it will simply do the ing function and and in else(exception)
		will simply let it go and print that this cant be converted to present participle
	"""
	exchar = ['be','see','flee','knee']
	consonant = "qwrtzpsdfghjklyxcvbnm"
	vowel = "aeiuo"
	
	one   = str1[-3:-2]
	two   = str1[-2:-1]
	three = str1[-1:0]
	
	if str1.endswith('ie'):
		str1 = str1[:-2]
		str1 += 'y' + 'ing'
		print("The Present Participle Form of verb is : "+str1)
	elif str1.endswith('e'):
		if str1 not in exchar:
			str1 = str1[:-1]
			str1 += 'ing'
			print("The Present Participle Form of verb is : "+str1)
		else:
			print("This Word is Exception : "+str1)

	# This one Remains to Understand
	elif one in consonant and two in vowel and three in consonant:
		last = str1[-1]
		str1 = str1[0:len(str1)-1] + last + last + "ing"
		print("The Present Participle Form of verb is : "+str1)
	
	else:
		str1 += 'ing'
		print("The Present Participle Form of verb is : "+str1)
		
def main():
    a = input("Enter the Word (Verb) : ")
    make_ing_form(a)
    
if __name__ == "__main__":
	main()

