import math
x = float(input('Введите x '))
y = float(input('Введите y '))
if x * y <= -1:
 f = math.sin(x * math.exp(y))
elif x * y >= 5:
 f = x * x + math.tan(y)
else:
 f = math.sqrt(math.fabs(math.cos(x * y)))
print('f = ', f)
