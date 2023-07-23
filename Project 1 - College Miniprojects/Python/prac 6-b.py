"""
Implement the python program to demonstrate the concept of class member and static member using associated decorator.
"""
"""
	Links :- 
	http://www.pythonabc.com/best-way-count-instances-python-class/
	http://radek.io/2011/07/21/static-variables-and-methods-in-python/
	
	Program to Demonstrate Static Method & Class Method using Decorator 
"""

"""
		Static Method Definition Here
"""

class books:
	numofbooks = 0
	def __init__(self):
		books.numofbooks +=1

	@staticmethod
	def howmany():
		print("The Total Number of Objects using Static Method are: "+str(books.numofbooks))

class author(books):
	def __init__(self):
		books.__init__(self)

"""
		Class Method Definition Here
"""
class Base:
	numobj = 0

	@classmethod
	def countobj(cls):
		cls.numobj +=1
	
	@classmethod
	def howmany(cls):
		print("The Total Number of Object using Class Method  are : "+str(cls.numobj))

	def  __init__(self):
		self.countobj()

class Derived(Base):
	numobj = 0

	def __init__(self):
		Base.__init__(self)

def main():
	# Static Method - To Count Number of Instances and instances of all it’s subclass too.
	database = books()
	ram = author()
	shyam = author()
	database.howmany()

	# Class Method -  To Count Number of Instances of Base Class Different and Derived Class Different
	b1 = Base()
	b2 = Base()
	d1 = Derived()
	d2 = Derived()
	d3 = Derived()

	b1.howmany()
	d1.howmany()

if __name__ == '__main__':
	main()
