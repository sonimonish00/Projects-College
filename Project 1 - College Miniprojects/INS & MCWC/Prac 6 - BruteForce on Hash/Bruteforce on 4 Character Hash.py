import string
import itertools
import sys
import hashlib

# def brute(string, length, charset):
#     if len(string) == length:
#         return
#     for char in charset:
#         temp = string + char
#         hash_obj = hashlib.sha1(temp.encode('utf-8')).hexdigest()
#         # print(temp)
#         if(hash_obj!=value):
#             brute(temp, length, charset)
#         else:
#             print("The Cracked password is: ==> "+temp)
#             sys.exit(0)

# value = input("Enter your Hash Value : ")
# brute("",4,"!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~")
# #brute("",4,"abcdefgh")
# print("Finally Cracked")

def bruteforce(charset, maxlength):
    return (''.join(candidate)
        for candidate in itertools.chain.from_iterable(itertools.product(charset, repeat=i)
        for i in range(1, maxlength + 1)))

value = input("Enter your Hash Value : ")
for attempt in bruteforce("!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~", 5):
	# string.digits or ascii_lowercase
    # match it against your password, or whatever
    hash_obj = hashlib.sha1(attempt.encode('utf-8')).hexdigest()
    if hash_obj =='25c568a0950a04692af1afaff2944ed8f0769dc5':
    	print("password SUCCESS FULYL CRACKED--------->>>>"+attempt)
    	break
print("FINALLLY CRACKED")