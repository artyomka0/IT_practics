import math
x=int(input())
y=int(input())
while(x<=2.5):
    while(y<=4):
        if(x+y<=2.):
            print(pow((math.sin(x*pow(math.e,(0.1*y)))),(1./3)))
        else:
            print(math.log(x+y,2))
        y=y+1
    x=x+0.5
