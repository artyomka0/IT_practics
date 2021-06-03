import math
a=int(input())
b=int(input())
hx=int(input())
for i in range(a,(b+1),hx):
    f = pow(math.cos(math.e*i),3)+math.sin(abs(i))
    f = str(f)
    i = str(i)
    print('x = ' + i + ' f = ' + f)
    i = int(i)
