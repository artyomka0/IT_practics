x=int(input('Введите число: '))
y=int(input('Введите основание СС: '))
while(x!=0):
    print(x%y,end='')
    x=x//y
