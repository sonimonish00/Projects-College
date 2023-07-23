import random

#setup required variables 

lower_letters = "abcdefghijklmnopqrstuvwxyz"
upper_letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
symbols = "!@_$%^&"

pass_len = int(input("The required password length is: "))
upper_len = int(input("The required number of upper case letters is: "))
symb_len = int(input("The required number of symbols is: "))
num_len = int(input("The required number of numbers is: "))

num_lower = pass_len - upper_len - symb_len - num_len

pw_list = []

if num_lower < 0:
	print("Sorry, the numbers you entered don't match up! Please try again ...")
	exit()
	
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
	
#print password	
print("Your generated password is: " + str(''.join(pw_list)))
#==================================================================================================
"""
		upper = list(string.ascii_uppercase)
		lower = list(string.ascii_lowercase)
		chars = list(string.punctuation)
		numbers = list(string.digits)
		len = 0
		while (len < 6):
			len = input("length password required (minimum 6 characters) : ")

	def pwd_gen(length):
		u = random.randint(1, len-3) #4-3 = 1 uppercase
		l = random.randint(1, len-2-u) #4-2-1 =1 lowecase
		c = random.randint(1, len-1-u-l) # 4-1-1-1 = 1 special case
		n = len-u-l-c # 4-1-1-1 = 1 Number ==> ratanlal27081995 + 4 =ratanlal27081995+Ab$5
		password = random.sample(upper,u)+random.sample(lower,l)+random.sample(chars,c)+random.sample(numbers,n)
		random.shuffle(password)
		return "".join(password)

	Your_PWD = pwd_gen(len)
	print Your_PWD
"""
