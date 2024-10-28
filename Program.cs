// See https://aka.ms/new-console-template for more information

using sort_algorithms;

Console.WriteLine("Hello, World!");
var sorting = new Sorting();

Random random = new Random();
var anyNumbers = Enumerable.Range(1, 999)
                           .OrderBy(x => random.Next())
                           .Take(42)
                           .ToArray();
                           
int[] inversedOrder = new int[] { 117, 90, 88, 83, 81, 77, 74, 69, 64, 63, 51, 
                                50, 49, 42, 41, 34, 32, 29, 28, 22, 16, 8,
                                6, 5, 3, 1};

int[] repeatedNumbers = new int[] { 7, 7, 7, 7, 7, 1, 1, 9, 9, 0, 4, 4, 4, 5, 4, 5, 7, 1 };             

Console.WriteLine("------ Sem Ordenar ------");
Console.Write("-> ");
foreach (int number in anyNumbers)
    Console.Write(number + " ");
Console.Write("\n-> ");
foreach (int number in inversedOrder)
    Console.Write(number + " ");
Console.Write("\n-> ");
foreach (int number in repeatedNumbers)
    Console.Write(number + " ");

// Merge Sorting
/*
Console.WriteLine("\n------ Com Merge Sort ------");
sorting.MergeSort(anyNumbers);
sorting.MergeSort(inversedOrder);
sorting.MergeSort(repeatedNumbers);
// Números Aleatórios
Console.Write("-> ");
foreach (int number in anyNumbers)
    Console.Write(number + " ");
Console.WriteLine();
// Números ordenados em ordem decrescente
Console.Write("-> ");
foreach (int number in inversedOrder)
    Console.Write(number + " ");
// Números repetidos
Console.Write("\n-> ");
foreach (int number in repeatedNumbers)
    Console.Write(number + " "); */

// Quick Sorting
Console.WriteLine("\n------ Com Quick Sort ------");
sorting.QuickSort(repeatedNumbers);
foreach (int num in repeatedNumbers)
    Console.Write(num + " ");
    