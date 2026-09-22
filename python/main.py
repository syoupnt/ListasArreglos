def imprimir_notas(notas):
    print('Notas de los estudiantes:')
    for i in range(len(notas)):
        print(f'Nota #{i+1}: {notas[i]}')

def calcular_promedio(notas):
    suma = 0

    for nota in notas:
        suma += nota

    promedio = suma / len(notas)
    return promedio

def obtener_nota_alta(notas):
    nota_alta = notas[0]

    for i in range(1, len(notas)):
        if notas[i] > nota_alta:
            nota_alta = notas[i]

    return nota_alta

def obtener_nota_baja(notas):
    nota_baja = notas[0]

    for i in range(1, len(notas)):
        if notas[i] < nota_baja:
            nota_baja = notas[i]

    return nota_baja

notas = [18, 20, 15, 12]

imprimir_notas(notas)
print(f'Promedio: {calcular_promedio(notas)}')
print(f'Nota más alta: {obtener_nota_alta(notas)}')
print(f'Nota más baja: {obtener_nota_baja(notas)}')