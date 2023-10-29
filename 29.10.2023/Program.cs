#region task1

//// 1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int num1=int.Parse(Console.ReadLine());
//bool NumberDivision(int num)
//{
//    return num % 21 == 0 ? true : false;
//}
//Console.WriteLine(NumberDivision(num1));

#endregion


#region task2

////n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//string MultiplicationofThem(int num1, int num2)
//{
//    if (num1 % 2 == 0 && num2 % 2==0) 

//    {
//        int result= num1+ num2;
//        return ($"bu ededin cemi {result}");
//    }
//    return "cut deyil";
//}
//Console.WriteLine(MultiplicationofThem(n, m));
#endregion

#region task3
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int num1 = 11;
//int num2 = 19;

//string cemle(int num, int num1)
//{
//	int count = 0;

//	for (int i = num; i <= num1; i++)
//	{
//		if (num < num1)
//		{
//			if (i % 2 == 1)
//			{
//				count++;
//			}
//		}

//	}
//	return ($"arasindaki tek reqem sayi{count}");
//}
//Console.WriteLine(cemle(num1,num2));
#endregion

#region task4
//Verilmis n ve m (n>m) ededleri arasindaki tek ededlerin cemini tapin.
//string OddSum(int n, int m)
//{
//    int oddSum = default(int);
//    if (m > n)
//    {
//        for (int i = n; i <= m; i++)
//        {
//            if (i % 2 == 1)
//            {
//                oddSum += i;
//            }
//        }
//        return $"{n} ve {m} ededleri arasindaki tek ededlerin cemi {oddSum} olur";
//    }
//    return $"1-ci eded 2-ci ededden kicikdir";
//}
//string oddSumResult = OddSum(10, 15);
//Console.WriteLine(oddSumResult);

#endregion
