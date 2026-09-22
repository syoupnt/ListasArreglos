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

