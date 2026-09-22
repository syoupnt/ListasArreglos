notas = [18, 20, 15, 12]

print('Notas de los estudiantes:')
for i in range(len(notas)):
    print(f'Nota #{i+1}: {notas[i]}')

# Calculando el promedio
suma = 0

for nota in notas:
    suma += nota

promedio = suma / len(notas)
print(f'Promedio: {promedio:2}')

