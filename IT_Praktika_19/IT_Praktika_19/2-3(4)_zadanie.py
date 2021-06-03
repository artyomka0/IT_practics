import math
x=int(input())
n=int(input())
d= math.ceil(math.log(x,2))
n=(2<<d)+((2<<d-n-1)-1)
print(n)
print(x&n)
