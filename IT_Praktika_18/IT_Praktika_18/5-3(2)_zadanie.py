a=int(input('Введите число: '))
if(a%10>a//10):
    print("правая цифра больше")
elif(a%10==a//10):
      print("цифры равны")
else:
     print("левая цифра больше")