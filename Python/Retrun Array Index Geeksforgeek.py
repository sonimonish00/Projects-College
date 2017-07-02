def search(arr,x):
    n = len(arr)
    for j in range(0,n):
        if(x==arr[j]):
            return j
    return -1

t = eval(input())
for i in range(0,t):
    n= eval(input())
    arr = list(map(int,input().split()))
    x = eval(input())
    print(search(arr,x))
    
