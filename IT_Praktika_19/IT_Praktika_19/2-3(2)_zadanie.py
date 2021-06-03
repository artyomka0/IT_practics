import math
x=int(input())
if(x>1):
    d=ceil(math.log(x,2))
    print(2<<d-1)
    if((2<<d-1)&(x)):
        print("Yes")
    else:
        print("No")
else:
    print("No")
