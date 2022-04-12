//int[] arr = new int[5];
//arr[0] = 13;
//arr[1] = 14;
//arr[2] = 15;
//arr[3] = 16;
//arr[4] = 17;

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


//int[] arr = new int[5];
//Console.WriteLine("Enter 5 values: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Entered value of array are: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


//dynamic size declaration

//Console.WriteLine("Enter size of array: ");
//int size=int.Parse(Console.ReadLine());
//int[] arr=new int[size];
//Console.WriteLine("Enter "+size+" values: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Entered value of array are: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Console.WriteLine("Enter values: ");
//int[,] arr = new int[3, 3];
//for(int i=0;i<3;i++)
//{
//    for(int j=0;j<3;j++)
//    {

//        arr[i,j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine("entered values are: ");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(arr[i,j]+"\t");
//    }
//    Console.WriteLine();
//}


//Console.WriteLine("Enter values: ");
//int[,] arr = new int[3, 4];
//for(int i = 0; i < 3; i++)
//{
//    for(int j = 0; j < 4; j++)
//    {
//        arr[i, j] = int.Parse(Console.ReadLine());
//    }
//}
//for(int i = 0; i < 3; i++)
//{
//    for(int j=0; j < 4; j++)
//    {
//        if(arr[i, j] %5==0)
//        {
//            Console.Write("*\t");
//        }
//        else
//        {
//            Console.Write(arr[i, j]+"\t");
//        }
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <= 3; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + "\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Enter rows and column value: ");
//int rows=int.Parse(Console.ReadLine());
//int cols=int.Parse(Console.ReadLine());
//Console.WriteLine("entered values are: ");
//int[,] arr = new int[rows, cols];
//int a = 0;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        if(j<i)
//            Console.Write("\t");
//        else
//            Console.Write("*\t");

//    }
//    Console.WriteLine();
//}


//Console.WriteLine("Enter rows number: ");
//int rows=int.Parse(Console.ReadLine());
//int cols = rows;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        if (i == 0 || i == rows - 1 || j == 0 || j == rows - 1)
//            Console.Write("*\t");       
//        else
//            Console.Write("\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Enter row number: ");
//int row = int.Parse(Console.ReadLine());

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < row; j++)
//    {
//        if (j == 0 || i == row - 1)
//            Console.Write("*\t");
//        else
//            Console.Write("\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Enter row number: ");
//int row = int.Parse(Console.ReadLine());

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < row; j++)
//    {
//        if (i == row - 1 || j == row - 1)
//            Console.Write("*\t");
//        else
//            Console.Write("\t");
//    }
//    Console.WriteLine();
//}
Console.WriteLine("Enter row number: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter row number: ");
int col = int.Parse(Console.ReadLine());
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        if ((i == 0 || i == (row / 2) || j == 0  )||(j==col-1)&&i<(row/2))
            Console.Write("*\t");
        else
            Console.Write("\t");
    }
    Console.WriteLine();
}



























