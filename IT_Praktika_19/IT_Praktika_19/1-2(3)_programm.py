import math
xn = float(input('Введите xn '))
xk = float(input('Введите xk '))
hx = float(input('Введите hx '))
x = xn #устанавливаем x в начало отрезка в xn
while x <= xk: #пока не дойдем до конца отрезка xk
 f = math.sin(x + math.exp(2)) + math.pow(3, x)
 print('x = ', x, ' f = ', f)
 x = x + hx #прибавляем к аргументу шаг
