Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintAVG(array);
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

void PrintAVG(int[,] array){
    int[] avg_array = new int[array.GetLength(0)];
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){    
            avg_array[i] += array[j,i];
        }
        Console.Write($"{avg_array[i]} | " );
    }
}