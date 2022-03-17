// See https://aka.ms/new-console-template for more information
using CodilitySolutions;

int[] A = new int[] { 1, 2, 3, 4 };
int k = 4;

A = CyclicRotation.Solution(A, k);

foreach (var item in A)
    Console.Write(item + ", ");