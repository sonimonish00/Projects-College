def Addition(a,b):
    """
	This Program Will Take Two Arguments And will do Addition.
    """
    return a+b

def Substraction(a,b):
    """
	This Program Will Take Two Arguments And will do Substraction.
    """
    return a-b

def Multiplication(a,b):
    """
	This Program Will Take Two Arguments And will do Multiplication.
    """
    return a*b

def passmein(fun):
    def Self_Describing_Function(*args):
        return fun(fun,*args)
    return Self_Describing_Function
    
@passmein
def sdf(*args):
    for i in args:
        print(i.__doc__)


def main():
    """ THE MAIN """
    a,b = 15,5
    print(sdf(Addition,Substraction))
    
if __name__ == "__main__":
	main()
    
