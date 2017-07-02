"""
Implement operator overloading to overload addition (+) operator using python.
"""
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

p1 = Point(2,3)
p2 = Point(5,-4)
print(p1+p2)
