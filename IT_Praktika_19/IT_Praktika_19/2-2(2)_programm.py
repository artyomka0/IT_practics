number = int(input('Input number: '))
# фильтр на 4,5,6 биты
number &= 0b1110000
# сдвинуть на 4 разряда вправо
number >>= 4
print('number = ', number)
