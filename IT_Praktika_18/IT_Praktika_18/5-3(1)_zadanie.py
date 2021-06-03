from math import * 
a=int(input('Введите число: '))
flag=0
while(a!=0):
    c=a % 10
    if(c==3):
        flag=1
        break
    a=a//10
if (flag==1):
    print("тройка входит")
else:
    print("тройка не входит")
