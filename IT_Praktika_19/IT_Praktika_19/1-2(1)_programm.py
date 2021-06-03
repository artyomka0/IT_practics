import math
x = float(input('Введите x '))
y = float(input('Введите y '))
f = 2 * math.pow(y, x) + math.log(math.fabs(x + y ** 3))
print('f = ', f)
