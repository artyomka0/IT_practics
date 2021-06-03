
a=float(input('Введите коэфицент a: '))
b=float(input('Введите коэфицент b: '))
c=float(input('Введите коэфицент c: '))
D=(pow(b,2)-(4*a*c))
if(D>0):
    print("x12="+str((-b-sqrt(D))/(2*a))+" "+str((-b+sqrt(D))/(2*a)))
elif(D==0):
    print("x="+str((-b)/(2*a)))
else:
    print("корней нет")
