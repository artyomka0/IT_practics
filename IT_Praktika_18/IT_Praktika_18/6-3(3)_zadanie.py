flag=1
a=int(input())
for x in range(2,a):
    if(a%x==0):
        flag=0
        break    
if(flag==1):
    print("простое число")
else:
    print("не простое число")
