import math
ax, bx, hx = 0.0, 1.0, 0.2
ay, by, hy = 1.0, 2.0, 0.5
x = ax #устанавливаем x в начало отрезка в xn
while x <= bx: #пока не дойдем до xk
 y = ay #устанавливаем y в начало отрезка в yn
 while y <= by: #пока не дойдем до yk
  if x + y <= 2:
     f = math.pow(x + y, 1.0 / 5.0)
 else:
     f = math.pow(math.fabs(math.sin(x)), y)
 print('x: = ', x, 'y = ', y, 'f = ', f) # выводим результат
 # или print('x = {:.3}, y = {:.3}, f = {:.3}'.format(x,y,f))
 # или print(f'x = {x:.3}, y = {y:.3}, f = {f:.3}')
 y = y + hy #прибавляем к y шаг
 x = x + hx #прибавляем к x шаг
