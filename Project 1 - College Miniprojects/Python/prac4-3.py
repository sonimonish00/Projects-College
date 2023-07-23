"""
Extract password hash from /etc/passwd file
"""
import getpass
import crypt

def gethash(your_ans):
	'''
		References :
		http://www.slashroot.in/how-are-passwords-stored-linux-understanding-hashing-shadow-utils
		http://serverfault.com/questions/330069/how-to-create-an-sha-512-hashed-password-for-shadow
		https://sandilands.info/sgordon/calculate-sha-hash-of-linux-password-in-shadow-file
		http://unix.stackexchange.com/questions/52108/how-to-create-sha512-password-hashes-on-command-line
		http://berndknows.blogspot.in/2012/09/generate-md5-sha-1-or-sha-512-unix.html
		https://www.aychedee.com/2012/03/14/etc_shadow-password-hash-formats/
	'''

	username = getpass.getuser()

	with open("/etc/shadow") as f:
		for line in f:
			if username in line:
				hashing = line.split(':')[1]

	#Getting the Hash Algorithm Used - In our Case SHA 512 (No. - 6)
	hashalgo = hashing.split('$')[1]

	#Getting the Salt Value Used
	saltvalue = hashing.split('$')[2]

	#Getting SHA-512 Hash Value of Users answer
	your_ans = str(your_ans)
	second_para = "$"+hashalgo+"$"+saltvalue
	
	# This Could be varied depending upon the OS..but as of now we are keeping SHA-512 ($6 - For SHA-512 Hashing)
	if int(hashalgo) == 6:

		#Means SHA-512 is used.Now we mix user input + our Salt to produce hash and compare it with our original hash.
		crypted = crypt.crypt(your_ans, second_para)
		if crypted == hashing:
			print("The Original Hash Value is: \n"+hashing)
			print("The Hash Value calculated from User Input is: \n"+crypted)
			print("\nHash of Password Succesfully Cracked!!..The Password is Cracked\n")
		else:
			print("Sorry Wrong Password..Pls Try Again!!")

def main():
	'''
	Below Will Return Always Root - Because /etc/shadow is only accesible when you run sudo python hash.py 
	which means you are chaging from local username to root user by launching in sudo.If You want to specify
	username then --> sudo -u monish python hash.py -> but this will not work as monish do not have right
	to read /etc/shadow files.So Right Now there is no Solution For this.
	'''

	userid = getpass.getuser()
	print("The Username is: "+userid)
	your_ans = input("Enter Password for this User: ")
	print("Checking if You Could Crack the Password or Not !!..\n")
	gethash(your_ans)

if __name__ == '__main__':
	main()

