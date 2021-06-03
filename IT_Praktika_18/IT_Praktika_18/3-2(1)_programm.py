import math as m
a, b, c = 3, -10, 1
D = b**2-4*a*c
x_1 = (-b-m.sqrt(D))/(2*a)
x_2 = (-b+m.sqrt(D))/(2*a)
print(x_1, x_2)
