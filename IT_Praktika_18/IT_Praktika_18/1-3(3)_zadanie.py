x = input('Введите х: ') # возвращается строка, не число
x=float(x) # преобразуем строку в вещественное число
y=x**5-2*x**3+1
y=str(y)
print('y = ' + y)
