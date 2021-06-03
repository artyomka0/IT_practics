x = int(input('x = '))
y = int(input('y = '))
# фильтр на 0-5 биты
x &= 0b11111
# фильтр на 0-7 биты
y &= 0b1111111
# умножить
z = x*y
print('x = ', x)
print('y = ', y)
print('z = ', z)
