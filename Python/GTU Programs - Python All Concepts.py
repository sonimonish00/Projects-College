###########################################################################################
"""
				1. BASICS - Recusrsions,Patterns,Files,Data Types,Exceptions
"""
###########################################################################################


"""
										BREAK 		
"""
###########################################################################################

number = 0
for number in range(10):
   number = number + 1
   if number == 5:
      break    # break here
   print('Number is ' + str(number))
print('Out of loop')

"""
										CONTINUE 		
"""
###########################################################################################
number = 0
for number in range(10):
   number = number + 1
   if number == 5:
      continue    # continue here
   print('Number is ' + str(number))
print('Out of loop')

"""
										LAMBDA - ANONYMOUS Function 		
"""
###########################################################################################

double = lambda x: x * 2
# Output: 10
print(double(5))

"""
										Fibonacci and Factorial 		
"""
###########################################################################################

def Fibonacci(n):
    if n == 0: 
    	return 0
    elif n == 1: 
    	return 1
    else: 
    	return Fibonacci(n-1)+Fibonacci(n-2)

#---------------------------------------------
def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n-1)

"""
										List Comprehension 		
"""
###########################################################################################
[double(x) for x in range(10)]
print double
[0, 2, 4, 6, 8, 10, 12, 14, 16, 18]# You can put in conditions:

>>> [double(x) for x in range(10) if x%2==0]
[0, 4, 8, 12, 16]
# You can add more arguments:
>>> [x+y for x in [10,30,50] for y in [20,40,60]]
[30, 50, 70, 50, 70, 90, 70, 90, 110]

"""
										Simple Exceptions 		
"""
###########################################################################################

try:
   fh = open("testfile", "r")
   fh.write("This is my test file for exception handling!!")
except IOError:
   print "Error: can\'t find file or read data"
else:
   print "Written content in the file successfully"

#----------------------------------------------------------------
try:
   # do something
   pass

except ValueError:
   # handle ValueError exception
   pass

except (TypeError, ZeroDivisionError):
   # handle multiple exceptions
   # TypeError and ZeroDivisionError
   pass

except:
   # handle all other exceptions
   pass


"""
										Manual Raising Exceptions 		
"""
###########################################################################################

if 0 < distance <= RADIUS:
    #Do something.
elif RADIUS < distance:
    #Do something.
else:
    raise AssertionError("Unexpected value of 'distance'!", distance)

"""
							User Defined Exceptions (Two Types - Built In/Custom)	
"""
###########################################################################################

class Error(Exception):
   """Base class for other exceptions"""
   pass
class ValueTooSmallError(Error):
   """Raised when the input value is too small"""
   pass
class ValueTooLargeError(Error):
   """Raised when the input value is too large"""
   pass
# our main program- user guesses a number until he/she gets it right- you need to guess this number

number = 10
while True:
   try:
       i_num = int(input("Enter a number: "))
       if i_num < number:
           raise ValueTooSmallError
       elif i_num > number:
           raise ValueTooLargeError
       break
   except ValueTooSmallError:
       print("This value is too small, try again!")
       print()
   except ValueTooLargeError:
       print("This value is too large, try again!")
       print()
print("Congratulations! You guessed it correctly.")

######################################################################################################
"""
		2. OOPS - Inheritance/Encapsulation/Abstraction/Polymorphism - Overloading/Overiding
"""
######################################################################################################


"""
										Inheritance - Simple 		
"""
###########################################################################################
class Polygon:
    def __init__(self, no_of_sides):
        self.n = no_of_sides
        self.sides = [0 for i in range(no_of_sides)]

    def inputSides(self):
        self.sides = [float(input("Enter side "+str(i+1)+" : ")) for i in range(self.n)]

    def dispSides(self):
        for i in range(self.n):
            print("Side",i+1,"is",self.sides[i])

class Triangle(Polygon):
    def __init__(self):
        Polygon.__init__(self,3)

    def findArea(self):
        a, b, c = self.sides
        # calculate the semi-perimeter
        s = (a + b + c) / 2
        area = (s*(s-a)*(s-b)*(s-c)) ** 0.5
        print('The area of the triangle is %0.2f' %area)

>>> t = Triangle()
>>> t.inputSides()
Enter side 1 : 3
Enter side 2 : 5
Enter side 3 : 4
>>> t.dispSides()
Side 1 is 3.0
Side 2 is 5.0
Side 3 is 4.0
>>> t.findArea()
The area of the triangle is 6.00

>>> issubclass(Polygon,Triangle)
False
>>> issubclass(Triangle,Polygon)
True
>>> issubclass(bool,int)
True
>>> isinstance(t,Triangle)
True
>>> isinstance(t,Polygon)
True
>>> isinstance(t,int)
False
>>> isinstance(t,object)
True

"""
										Inheritance - Multilevel 		
"""
###########################################################################################
class Animal:
	def eat(self):
	print 'Eating...'
class Dog(Animal):
	def bark(self):
	print 'Barking...'
class BabyDog(Dog):
	def weep(self):
	print 'Weeping...'
d=BabyDog()
d.eat()
d.bark()
d.weep()

"""
										Inheritance - Multiple 		
"""
###########################################################################################

class MySuperClass1():
    def method_super1(self):
        print("method_super1 method called")

class MySuperClass2():
    def method_super2(self):
        print("method_super2 method called")
 
class ChildClass(MySuperClass1, MySuperClass2): 
    def child_method(self):
        print("child method")

c = ChildClass()
c.method_super1()
c.method_super2()

"""
										Encapsulation/Abstraction 		
"""
###########################################################################################
class Car:
 
    __maxspeed = 0
    __name = ""
 
    def __init__(self):
        self.__maxspeed = 200
        self.__name = "Supercar"
 
    def drive(self):
        print 'driving. maxspeed ' + str(self.__maxspeed)
 
    def setMaxSpeed(self,speed):
        self.__maxspeed = speed

    def __updateSoftware(self):
    	print 'updating software'

redcar = Car()
redcar.drive()
redcar.__maxspeed = 10  # will not change variable because its private
redcar.__updateSoftware() # not accesible from object - Private
redcar.setMaxSpeed(320) #Use Setters to modify private Variable

"""
								Polymorphism 	
"""
###########################################################################################

class Bear(object):
    def sound(self):
        print "Groarrr"
 
class Dog(object):
    def sound(self):
        print "Woof woof!"

def makeSound(animalType):
    animalType.sound()
bearObj = Bear()
dogObj = Dog()
makeSound(bearObj)
makeSound(dogObj)

#-------------------------------------------------------------------------------

class Document:
    def __init__(self, name):    
        self.name = name
    def show(self):             
        raise NotImplementedError("Subclass must implement abstract method")
class Pdf(Document):
    def show(self):
        return 'Show pdf contents!'
class Word(Document):
    def show(self):
        return 'Show word contents!'
 
documents = [Pdf('Document1'),
             Pdf('Document2'),
             Word('Document3')]
 
for document in documents:
    print document.name + ': ' + document.show()

"""
								Overloading - Method / Operator(Uses Special Function) 	
"""
###########################################################################################

class Human:
	def sayHello(self, name=None):
		if name is not None:
			print 'Hello ' + name
		else:
			print 'Hello '
# Create instance
obj = Human()
# Call the method
obj.sayHello()
# Call the method with a parameter
obj.sayHello('Monish')

#---------------------------------------------------------------------

class Point:
    def __init__(self, x = 0, y = 0):
        self.x = x
        self.y = y
    def __str__(self):
        return "({0},{1})".format(self.x,self.y)

    def __add__(self,other):
        x = self.x + other.x
        y = self.y + other.y
        return Point(x,y)

>>> p1 = Point(2,3)
>>> p2 = Point(-1,2)
>>> print(p1 + p2)
(1,5)

"""
								Overiding - Method(Function) 	
"""
###########################################################################################

class Parent(object):
    def __init__(self):
        self.value = 5

    def get_value(self):
        return self.value

class Child(Parent):
    def get_value(self):
        return self.value + 1

>>> c = Child()
>>> c.get_value()
6

"""
								Variable - Instance/Class(Static)
"""
###########################################################################################
class Shark:
    # Class variables
    animal_type = "fish"
    location = "ocean"
    # Constructor method with instance variables name and age
    def __init__(self, name, age):
        self.name = name
        self.age = age
    # Method with instance variable followers
    def set_followers(self, followers):
        print("This user has " + str(followers) + " followers")


def main():
    # First object, set up instance variables of constructor method
    sammy = Shark("Sammy", 5)
    # Print out instance variable name
    print(sammy.name)
    # Print out class variable location
    print(sammy.location)
    # Second object
    stevie = Shark("Stevie", 8)
    # Print out instance variable name
    print(stevie.name)
    # Use set_followers method and pass followers instance variable
    stevie.set_followers(77)
    # Print out class variable animal_type
    print(stevie.animal_type)

if __name__ == "__main__":
    main()

"""
								 Class Method | Instance Method | Static Method
"""
###########################################################################################
class Methods:
  def i_method(self,x):
    print(self,x)
  
  @classmethod
  def c_method(cls,x):
    print(cls,x)

  @staticmethod
  def s_method(x):
    print(x)

obj = Methods()

#Instance Method
obj.i_method(1)
Methods.i_method(obj, 2)

#Static Method
obj.s_method(3)
Methods.s_method(4)

#Class Method
obj.c_method(5)
Methods.c_method(6)

(<__main__.Methods instance at 0x7f7052d75950>, 1)
(<__main__.Methods instance at 0x7f7052d75950>, 2)
3
4
(<class __main__.Methods at 0x7f7052d6d598>, 5)
(<class __main__.Methods at 0x7f7052d6d598>, 6)


#######################################################################################################
"""
				3. R.E. | Encryption/Decryption | Searching/Sorting
"""
#######################################################################################################


"""
										REGULAR EXPRESSION 		
"""
#######################################################################################################

    # matchobj = re.match() --> matchobj.group(0),(1) | matchobj.start()/end()
    # re.search() --> match.group(0),(1)
    # re.findall() --> Returns List
    # re.split() --> result=re.split(r'y','Manytada') = ['Man' 'tada']
    # re.sub() --> Substitute result=re.sub(r'India','the World','I am of India') = I am the World
    # re.compile() --> pattern=re.compile('AV') ; result=pattern.findall('AV xkm AV') = ['AV', 'AV']

import re

# RE for Username - Alphanumeric and password also - length of 8 to 25
if re.match("^[a-zA-Z0-9_.-]{8-25}+$", username):
	print(r"Correct username")

# RE for HEX Value
if re.match(r"#?([a-f0-9]{6}|[a-f0-9]{3})+$", hexa):
	print("Correct HEX")

# RE for Slug
if re.match(r"^[a-z0-9-]+$", slug):
	print("Correct Slug")

# RE for Email
if re.match(r"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)", email):
	print("Correct Email")

# RE for URL Checking
url = '<p>Hello</p><a href="http://example.com">More Examples</a><a href="http://example2.com">Even More Examples</a>'
urls = re.findall(r'http[s]?://(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+$', url)

# RE for IP Address
if re.match(r"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$", IP):
	print("Correct IP")

# RE for HTML Tag
if re.match(r"^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$", html):
	print("Correct html")


"""
									ENCRYPTION/DECRYPTION  		
"""
#######################################################################################################

from simplecrypt import encrypt, decrypt
ciphertext = encrypt('password', plaintext)
plaintext = decrypt('password', ciphertext)

#For Python 3
mystring = decrypt('password', ciphertext).decode('utf8')

"""
									Searching/Sorting		
"""
#######################################################################################################

# LINEAR SEARCH

def linear_search(obj, item, start=0):
    for i in range(start, len(obj)):
        if obj[i] == item:
            return i
return -1

# BINARY SEARCH

def binarySearch(theList, value, low, high):
	    if high < low:
	        return -1 # indicates the value isn't in array
	    mid = (low + high)/2

	    if theList[mid] > value:
	        return binarySearch(theList, value, low, mid-1)

	    elif theList[mid] < value:
	        return binarySearch(theList, value, mid+1, high)
	    
	    else:
	        return mid

# SELECTION SORT

def sort_selection(my_list):
    for pos_upper in xrange( len(my_list)-1, 0, -1):
        max_pos = 0
        for i in xrange(1, pos_upper + 1):
            if(my_list[i] > my_list[max_pos]):
                max_pos = i
                print "resetting max_pos = " + str(max_pos)
        my_list[pos_upper], my_list[max_pos] = my_list[max_pos], my_list[pos_upper]
        print "pos_upper: " + str(pos_upper) + " max_pos: " + str(max_pos) + " my_list: " + str(my_list)
    return my_list

if __name__ == "__main__":
    my_list = [54,26,93,17,77,31,44,55,20]
    print "my_list: " + str(my_list)
    print sort_selection(my_list)


# MERGE SORT
def merge_sort(lst):
    """Sorts the input list using the merge sort algorithm.

    >>> lst = [4, 5, 1, 6, 3]
    >>> merge_sort(lst)
    [1, 3, 4, 5, 6]
    """
    if len(lst) <= 1:
        return lst
    mid = len(lst) // 2
    left = merge_sort(lst[:mid])
    right = merge_sort(lst[mid:])
    return merge(left, right)

def merge(left, right):
    """Takes two sorted lists and returns a single sorted list by comparing the
    elements one at a time.

    >>> left = [1, 5, 6]
    >>> right = [2, 3, 4]
    >>> merge(left, right)
    [1, 2, 3, 4, 5, 6]
    """
    if not left:
        return right
    if not right:
        return left
    if left[0] < right[0]:
        return [left[0]] + merge(left[1:], right)
    return [right[0]] + merge(left, right[1:])

#######################################################################################################
"""
								4. MultiThreading & Socket Programming
"""
#######################################################################################################


"""
							MultiThreading	(we will use threading module instead of thread module)	
"""
#######################################################################################################
import threading

def worker(num):
    """thread worker function"""
    print 'Worker: %s' % num
    return

threads = []
for i in range(5):
    t = threading.Thread(target=worker, args=(i,))
    threads.append(t)
    t.start()

Worker: 0
Worker: 1
Worker: 2
Worker: 3
Worker: 4

"""
					Socket Programming - Echo Server and Echo Client in One Program - TCP/UDP	
"""
#######################################################################################################

								# Echo Server - TCP
from socket import * 
import sys

HOST = 'localhost' # Symbolic name meaning all available interfaces
PORT = 8888 # Arbitrary non-privileged port

# Step 1-2-3 
s = socket(AF_INET,SOCK_STREAM) #create socket - For UDP - SOCK_DGRAM
s.bind((HOST, PORT))   #binding port
s.listen(3) #listening for  3 client - For UDP - No Listens

# Step 4
while 1:
	# Receive data from client in Form of Tuple -> (data, addr)
	
	#accept the connection- Only in TCP
	# For UDP - No Accept
	data, address = s.accept() 
	
	#For UDP - d = s.recvfrom(1024) ; data = d[0].decode() ; addr = d[1]	
	dat = data.recv(size) 
    if dat: 
    	#For UDP - s.sendto(reply.encode() , addr)
        dat.send(data) 
    data.close()

								# Echo Client - TCP 
from socket import * 
import sys

HOST = 'localhost' # Symbolic name meaning all available interfaces
PORT = 9999 # Arbitrary non-privileged port


s = socket(AF_INET,SOCK_STREAM) #create socket - For UDP - SOCK_DGRAM

# connection to hostname on the port.
s.connect((host, port))    

#For UDP - d = s.recvfrom(1024) ; data = d[0].decode() ; addr = d[1]
# Receive no more than 1024 bytes
data = s.recv(1024)   

s.close()
print("The Data we got from the server is %s" % data)

"""
		Socket Programming - Chat App - TCP/UDP - Without MultiThreading (For Multiple Clients)
"""
#######################################################################################################

									# Server.py

from socket import *
from select import *

# Use these for binding our server
HOST = "127.0.0.1"
PORT = 1993
server = socket(AF_INET, SOCK_STREAM)
server.bind((HOST, PORT))
server.listen(5)
clients = []

# Create a list of clients to use on select
def getClients():
    to_use = []
    for client in clients:
        to_use.append(client[0])
    return to_use
       
# Server loop
while(True):
    # Check for connection but not block
    read, write, error = select([server],[],[],0)
    # Check if any connections
    if(len(read)):
        client, address = server.accept()
        clients.append([client, address, []])
    to_use = getClients()

    # Try and read any data from the clients
    try:
        read, write,error = select(to_use,[],[],0)
        if(len(read)):
            for client in read:
                # Get the data from the client
                data = client.recv(1024)
                # Print the data so the server gets to see it
                print(bytes.decode(data))
                if(data == 0):
                    for c in clients:
                        if c[0] == client:
                            clients.remove(c)
                            break
                else:
                    # Add the data to every client's queue
                    for c in clients:
                        c[2].append(data)
    except:
        pass

    # Try and write data from the clients queue to the client
    try:
        to_use = getClients()
        read, write, error = select([], to_use, [], 0)

        if(len(write)):
            for client in write:
                for c in clients:
                    if c[0] == client:
                        # Send the data from the client quoue to the client
                        for data in c[2]:
                            sent = client.send(data)
                            if(sent == len(data)):
                               c[2].remove(data)
                        break
    except:
        pass

											# Client.py
from socket import *
from select import *

# Information of our server to connect to - You Could Use UDP also
HOST = "127.0.0.1"
PORT = 1993
sock = socket(AF_INET, SOCK_STREAM)
sock.connect((HOST, PORT))

# Client loop
while(True):
    # Let the user enter some data to send
    data = input("&gt;&gt; ")
    read, write, error = select([],[sock],[],0)
    if(len(write)):
        # Send the data to the server
        b = sock.send(str.encode(data))

    # The receiving loop
    while(True):
        # When receiving, use the timeout of 1 to receive more data
        read, write, error = select([sock],[],[],1)
        # If there is data, print it
        if(len(read)):
            data = bytes.decode(sock.recv(1024))
            print(data)
        # Exit the loop if no more data
        else:
            break

"""
		Socket Programming - Chat App - TCP/UDP - With MultiThreading (For Multiple Clients)
"""
#######################################################################################################

									# Server.py

from socket import *
import threading

def accept_client():
    while True:
        #accept    
        cli_sock, cli_add = ser_sock.accept()
        uname = cli_sock.recv(1024)
        CONNECTION_LIST.append((uname, cli_sock))
        print('%s is now connected' %uname)
        thread_client = threading.Thread(target = broadcast_usr, args=[uname, cli_sock])
        thread_client.start()

def broadcast_usr(uname, cli_sock):
    while True:
        try:
            data = cli_sock.recv(1024)
            if data:
                print (("{0} spoke").format(uname))
                b_usr(cli_sock, uname, data)
        except Exception as x:
            print(x.message)
            break

def b_usr(cs_sock, sen_name, msg):
    for client in CONNECTION_LIST:
        if client[1] != cs_sock:
            client[1].send(sen_name)
            client[1].send(msg)

if __name__ == "__main__":    
    CONNECTION_LIST = []
    # socket
    s = socket(socket.AF_INET, socket.SOCK_STREAM)
    HOST = 'localhost'
    PORT = 50243
    s.bind((HOST, PORT))
    s.listen(1)
    print('Chat server started on port : ' + str(PORT))

    thread_ac = threading.Thread(target = accept_client)
    thread_ac.start()
    #thread_bs = threading.Thread(target = broadcast_usr)
    #thread_bs.start()

									# Client.py
from socket import *
import threading

def send():
    while True:
        msg = input('\nMe > ')
        c.send(msg.encode('utf-8'))

def receive():
    while True:
        sen_name = c.recv(1024)
        data = c.recv(1024)
        print('\n' + str(sen_name) + ' > ' + str(data))

if __name__ == "__main__":   
    # socket
    c = socket(socket.AF_INET, socket.SOCK_STREAM)
    HOST = 'localhost'
    PORT = 50243
    c.connect((HOST, PORT))     
    print('Connected to remote host...')
    uname = input('Enter your name to enter the chat > ')    
    c.send(uname.encode('utf-8'))

    thread_send = threading.Thread(target = send)
    thread_send.start()
    thread_receive = threading.Thread(target = receive)
    thread_receive.start()

################################# FINISH ###################################################################################
