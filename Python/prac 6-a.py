"""
Demonstrate the concept of class and object using python.
"""
class Person:
	def __init__(self):
		print("This is a Constructor method")

	def show(self):
		print("This is a Person Class")

def main():
	p = Person()
	p.show()
if __name__ == '__main__':
	main()