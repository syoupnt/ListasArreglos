void imprimirNotas(int[] notas) {
    Console.WriteLine("Notas de los estudiantes:");

    for (int i = 0; i < notas.Length; i++) {
        Console.WriteLine($"Nota #{i+1}: {notas[i]}");
    }
}

double calcularPromedio(int[] notas) {
    int suma = 0;

    foreach (int nota in notas) {
        suma += nota;
    }

    double promedio = (double) suma / notas.Length;
    return promedio;
}

int conseguirNotaAlta(int[] notas) {
    int notaAlta = notas[0];

    for (int i = 1; i < notas.Length; i++) {
        if (notas[i] > notaAlta) {
            notaAlta = notas[i];
        }
    }

    return notaAlta;
}

int conseguirNotaBaja(int[] notas) {
    int notaBaja = notas[0];

    for (int i = 1; i < notas.Length; i++) {
        if (notas[i] < notaBaja) {
            notaBaja = notas[i];
        }
    }

    return notaBaja;
}

int[] notas = { 18, 20, 15, 12 };

imprimirNotas(notas);
Console.WriteLine($"Promedio: {calcularPromedio(notas)}");
Console.WriteLine($"Nota más alta: {conseguirNotaAlta(notas)}");
Console.WriteLine($"Nota más baja: {conseguirNotaBaja(notas)}");