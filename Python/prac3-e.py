"""
Write a program to test the strength of a password using function, where function accepts the string as a password from user. Your function would check the strength of password, and would print the message accordingly. You function should suggest the strong password to the user in the case if entered password is having weak or medium strength. Password can only be considered as Strong if it meets following criteria
i. Minimum length of password should be 8 character
ii. Password should contain at least 2 special symbol
iii. Pasword should have at least 2 letters in capital
iv. Password should not contains only alphabets or numbers or special symbol, it should be combination of all.

"""
import string
from string import punctuation
import random

def strongpass(str1):
	capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	small = "abcdefghijklmnopqrstuvwxyz"
	numbers = "0123456789"
	
	num_of_spcl_sym = 0
	num_of_capital = 0
	num_of_small = 0
	num_of_digits = 0

	#Password Should be a combination of all so 0-False and 1-True
	combination = False 

	#Checking for Minimum 2 Special Symbols and 2 Number of Capitals		
	for i in str1:
		if i in set(punctuation):
			num_of_spcl_sym += 1
		if i in capital:
			num_of_capital += 1
		if i in small:
			num_of_small +=1
		if i in numbers:
			num_of_digits +=1

	#Checking for combination
	if num_of_spcl_sym >=2 and num_of_capital >=2 :
		#Check Remains for Small Alphabets and Numbers.
		if num_of_small >=1 and num_of_digits >=1 :
			combination = True

	if len(str1) >=8 and combination == True:
		#Here Password Become Strong.Still its not really bit Entropy(information Entropy) Kind of Scene.
		return True
	else:
		#Suggestions to user on how to make strong password based on the nums it had forgotten.
		print("Your Password is Weak or Medium Strength Password !!")
		#Checking the Missing Logic
		print("The Length of Your Password is (Recommended is >=8) : "+str(len(str1)))
		print("No. of Special symbol in Your Passwords are (Recommended is >=2) : "+str(num_of_spcl_sym))
		print("No. of Capital Letters in Your Passwords are (Recommended is >=2) : "+str(num_of_capital))
		print("No. of Small Letters in Your Passwords are (Recommended is >=1) : "+str(num_of_small))
		print("No. of Digits in Your Passwords are (Recommended is >=1) : "+str(num_of_digits)+"\n")
		
		#Trying to Give Suggestion based on Users Input(Only 1 Suggestion as of now).Randomized
		#Later This process of Suggestion could be automatized and randomized
		chars = string.ascii_letters + string.digits + string.punctuation
		
		"""Your Password Should not Exceed 20 Length.
		Else will Hit Recursion Depth.If Needed to Modify.Modify this Constant 20 Below."""

		str1 =  str1[:len(str1) //2] #Getting First Half For Suggestion (16/2 = 8).Probablity Gets High 
		remaining_size = 20 - len(str1) #So For EX:- 20 - 8 = 12

		lower_letters = string.ascii_lowercase
		upper_letters = string.ascii_uppercase
		symbols = string.punctuation
		
		pass_len = remaining_size #RemainingSize - 12
		upper_len = 2 #2
		symb_len = 2 #2
		num_len = 2 #2

		num_lower = pass_len - upper_len - symb_len - num_len 
		pw_list = []

		if num_lower < 0:
			print("Sorry !! Something Went Wrong Here.Pls Try Again")
			return
		#insert lowercase letters
		i = 0
		while i < num_lower:
			pw_list.append(str(''.join(random.sample(lower_letters, 1))))
			i += 1
	
		#insert uppercase 
		j = 0
		upper_inc = num_lower - 1
		while j < upper_len:
			pw_list.insert(random.randint(0, upper_inc), str(''.join(random.sample(upper_letters, 1))))
			j += 1
			upper_inc += 1

		#insert symbols 
		k = 0
		symbol_inc = num_lower + upper_len - 1
		while k < symb_len:
			pw_list.insert(random.randint(0, symbol_inc), str(''.join(random.sample(symbols, 1))))
			k += 1
			symbol_inc += 1

		#insert numbers 
		l = 0
		num_inc = num_lower + upper_len + symb_len - 1
		while l < num_len:
			pw_list.insert(random.randint(0, num_inc), str(random.randint(0, 9)))
			l += 1
			symbol_inc += 1
		
		str2 = ''.join(pw_list)
		str1 +=str2
		#Recursively Calling our Own Function to Check Whether this Random Password is Strong
		if strongpass(str1) == True:
			print("Suggestion: Strong Password based on your input is (Total Length-> 20) : "+str1)
		else:
			"""If Comes Here Remove All the Logic in the Else part and Simply Print Strong 
			static Passwords or Try to Solve it.
			"""
			print("Something Went Wrong !! Exiting the System")

def passwdstrength(str2):
	""" First of all we will check for Strong Password. After that we will give suggestions!!"""
	#Checks for Strong password Recusrviley calling the function
	if strongpass(str2) == True:
		print("Your Password is Strong !!")

def main():
	print("=========================================")
	print("  PSEUDO PASSWORD CHECKER -- By Monish :P")
	print("=========================================")
	a = input("Enter the Password (Max. Length : 20) : ")
	if(len(a) <= 20):
		passwdstrength(a)
	else:
		print("Told You.Enter Less Than 20.Else Modify the Code Accordingly and Dynamic.")
if __name__ == "__main__":
	main()

