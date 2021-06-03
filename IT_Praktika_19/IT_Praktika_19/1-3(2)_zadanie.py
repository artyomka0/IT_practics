import math
x=int(input())
y=int(input())
if(math.sin(x+y)<=-0.5):
    print((pow(math.arctg(math.sqrt(abs(x-y))),3))*(x*pow(y,math.e)))
elif(math.sin(x+y)<0.5):
    print(3.*math.log(abs(x*y),3.))
elif(math.sin(x+y)>=0.5):
    print((pow(x,3.)+pow(y,1.5)))
