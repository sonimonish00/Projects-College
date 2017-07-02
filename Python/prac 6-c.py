"""
Declare member as base class, and derive student and teacher as derived class from member base class to demonstrate the concept of Inheritance.
"""
class member:
    def __init__(self,Name,Age):
        self.Name = Name
        self.Age = Age

class student(member):
    def __init__(self,Name,Age,mobileno):
        member.__init__(self,Name,Age)
        self.mobileno = mobileno
    def display(self):
        print ("Student Class: ")
        print ("Name = "+ self.Name +" " + "Age = "+ self.Age +" "+ "Mobile No = "+ self.mobileno + "\n")

class teacher(member):
    def __init__(self,Name,Age,Designation):
        member.__init__(self,Name,Age)
        self.Designation = Designation
    def display(self):
        print ("Teacher Class: ")
        print ("Name = "+ self.Name +" " + "Age = "+ self.Age +" "+ "Designation = "+ self.Designation)

s = student("Monish","21","9426934999")
t = teacher("Abc","45","Assistatnt Professor")

s.display()
t.display()
