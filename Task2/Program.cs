

void MatrixPrinr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}


void MatrixFill( int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 20);
        }
    }
}

int[,] matrix = new int[3, 4];
MatrixPrinr(matrix);
MatrixFill(matrix);
System.Console.WriteLine();
MatrixPrinr(matrix);

