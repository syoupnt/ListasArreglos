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

# Calculando nota más alta y más baja
nota_alta = notas[0]
nota_baja = notas[0]

for i in range(1, len(notas)):
    nota = notas[i]
    if nota > nota_alta:
        nota_alta = nota
    if nota < nota_baja:
        nota_baja = nota

print(f'Nota más alta: {nota_alta}')
print(f'Nota más baja: {nota_baja}')