int[] notas = { 18, 20, 15, 12 };

Console.WriteLine("Notas de los estudiantes:");
for (int i = 0; i < notas.Length; i++) {
    Console.WriteLine($"Nota #{i+1}: {notas[i]}");
}

// Calculando el promedio
int suma = 0;

foreach (int nota in notas) {
    suma += nota;
}

double promedio = (double) suma / notas.Length;
Console.WriteLine($"Promedio: {promedio:F2}");

// Calculando nota más alta y más baja

int notaAlta = notas[0];
int notaBaja = notas[0];

for (int i = 1; i < notas.Length; i++) {
    int nota = notas[i];

    if (nota > notaAlta) {
        notaAlta = nota;
    }
    if (nota < notaBaja) {
        notaBaja = nota;
    }
}

Console.WriteLine($"Nota más alta: {notaAlta}");
Console.WriteLine($"Nota más baja: {notaBaja}");