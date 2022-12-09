﻿Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер строки: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца: ");
int b = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintChislo(array,a,b);
// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

// Метод печати двумерного массси
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintChislo(int[,] array,int a, int b){
    int m = array.GetLength(0);
    int m = array.GetLength(1);
    if (a < m && b < n){
        Console.WriteLine($"i = {a}; j = {b} -> {array[a,b]}");
    }
    else{
        Console.WriteLine("такого числа в массиве нет");
    }

}