Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
double [,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
// ------------------Методы-----------------------

// Метод создания двумерного массива
double[,] GetArray(int m, int n, int minValue, int maxValue){
    double [,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)/10.0);
        }
    }
    return result;
}

// Метод печати двумерного массси
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}