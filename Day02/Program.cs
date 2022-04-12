//while(true)
//{ 
//    Console.WriteLine("hello");
//}
//int a = 1;
//while (a <= 20)
//{
//    string res = a % 2 == 0 ? "= even" : "= odd";
//    Console.WriteLine(a + res);
//    a++;
//}

//int num = 0;
//while(num<=100)
//{
//    if (num % 5 == 0 && num % 2 == 0)
//    {
//        Console.WriteLine(num);

//    }

//    num+=10;
//}

//prime number 
//Console.WriteLine("Enter number: ");
//int num=int.Parse(Console.ReadLine());
//bool flag = true;
//int i = 2;
//while(i<num/2)
//{
//    if(num%i==0)
//    {
//        flag = false;
//        break;
//    } 
//    i++;
//}
//if (flag)
//    Console.WriteLine(num +" prime number");
//else
//    Console.WriteLine(num+" not Prime number");

//for(int i=0;i<=10;i++)
//{
//    Console.WriteLine("hello");
//}
//Console.WriteLine("Odd Numbers between 1 to 100");
//for(int i=0;i<=100;i++)
//{
//   if(i%2!=0)
//        Console.WriteLine(i);
//}

//Console.WriteLine("Divisible by 5 and 2");
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 5 == 0 && i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}



////for (int i = 1; i <= 3; i++)
////{
////    for (int j = 1; j <= i; j++)
////    {
////        Console.Write(j + "\t");
////    }
////    Console.WriteLine();
////}


//for(int i=1;i<=3;i++)
//{
//    for(int j = 1; j <= 4; j++)
//    {

//        if(i==2)
//        {
//            Console.Write("2\t");
//        }
//        else
//            Console.Write("0\t");
//    }
//    Console.WriteLine();
//}


//Console.WriteLine("Enter row number: ");
//int rows=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter column number: ");
//int cols=int.Parse(Console.ReadLine());
//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= cols; j++)
//    {

//        if (i==j)
//        {

//                Console.Write("1\t");
//        }
//       else
//            Console.Write("0\t");
//    }
//    Console.WriteLine();
//}


Console.WriteLine("Enter row number: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter column number: ");
int cols = int.Parse(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= cols; j++)
    {

        if (i == j)
        {

            Console.Write("1\t");
        }
        else
            Console.Write("0\t");
        if (i == cols)
        {
            Console.Write("1\t");
        }
        else
            Console.Write("0\t");
    }
    Console.WriteLine();
}



//Console.WriteLine("Enter row number: ");
//int rows = int.Parse(Console.ReadLine());
//int a = 1;
//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {

//        Console.Write(a + "\t");
//        a++;

//    }
//    Console.WriteLine();
//}

