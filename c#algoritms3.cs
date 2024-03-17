//int temp = 19;
//if (temp < 15) 
//{
//    Console.WriteLine("Whater is cold");
//}
//else
//{
//    Console.WriteLine("Whater is hot");
//}


//string month = "march";
//switch (month)
//{
//	case "january":
//		Console.WriteLine(31);
//		break;

//	case "february":
//		Console.WriteLine(29);
//    break;

//	case "march":
//		Console.WriteLine(31);
//    break;

//    case "april":
//        Console.WriteLine(30);
//        break;

//    case "may":
//        Console.WriteLine(31);
//        break;

//    case "june":
//        Console.WriteLine(30);
//        break;

//    case "july":
//        Console.WriteLine(31);
//        break;

//    case "august":
//        Console.WriteLine(31);
//        break;

//    case "september":
//        Console.WriteLine(30);
//        break;

//    case "october":
//        Console.WriteLine(31);
//        break;

//    case "november":
//        Console.WriteLine(30);
//        break;

//    case "december":
//        Console.WriteLine(31);
//        break;
//}


//int num = 1;
//int fac = 6;
//int total = 1;
//while (num<=fac)
//{
//    total=total*num;
//    num++;
//}
//Console.WriteLine(total);


//int num = 37;
//bool simple = true;
//for (int i = 2; i < num; i++) 
//{
//    if (num % i == 0) 
//    {
//        simple= false ;
//        break;
//    }
//}
//if (simple)
//{
//    Console.WriteLine("simple");
//}
//else
//{
//    Console.WriteLine("complex");
//}


//int[] arr = { 4, 15, 24, 11, 17, 19 };
//int sum = 0;
//for (int i = 0; i <arr.Length; i++)
//{
//    if (arr[i] % 2 != 0)
//        sum += arr[i];
//}
//Console.WriteLine(sum);


//int[] arr = { 11, 41, 14, 36, 27 };
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++) 
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//    Console.WriteLine(max);


//int num = 347;
//int solitude = num % 10;
//int decima= (num / 10) % 10;
//int hundred = num / 100;
//if (solitude != decima && solitude != hundred && decima != hundred)
//{
//    Console.WriteLine("not all numbers are equal");
//}
//else
//{ 
//    Console.WriteLine("there are repeating numbers");
//}


//int num = 325;
//int count = 0;
//while (num > 0) 
//{
//    int a = num % 10;
//    count += a;
//    num /= 10;
//}
//Console.WriteLine(count);



//int[] arr = { 71, 34, 32, 25, 457, 112, 23 };
//int min = arr[0];
//for (int i =0 ; i < arr.Length; i++)
//{
//	if (arr[i] < min) 
//	{
//		min = arr[i];
//	}
//}
//Console.WriteLine(min);



//int[] arr = { 2, 23, 4, 67, 3, 5, };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//	if (arr[i]<10)
//	{
//		count++;
//	}
//}
//Console.WriteLine(count);


//int num = 47;
//int solitude = num % 10;
//int decima=num / 10;
//if (decima > solitude)
//{
//    Console.WriteLine("decima is great");
//    }
//    else
//{ Console.WriteLine("solitude is great");
//}



//int num = 954;
//int count = 0;
//if (num == 0)
//{
//	count = 1;
//}
//	while (num % 10 != 0)
//	{
//	num/= 10;
//	count++;

//	}
//Console.WriteLine(count);
 




//int num = 44;
//if (num%10==0)
//{
//    Console.WriteLine("number is even");
//}
//else
//{
//    Console.WriteLine("number is odd");
//}

//int num = 32;
//if (num %21!=0)
//{
//    Console.WriteLine("number is not divisible by 3 and 7");
//}


//int num1 = 13;
//int num2 = 14;
//if (num1 > num2)
//    {
//    Console.WriteLine(num1);
//}
//else
//{
//    Console.WriteLine(num2);
//}






//int[] arr1 ={2, 35, 7, 14, 23};
//int[] arr2 = { 12, 7, 23, 56, 20, 5 };
//foreach(int a in arr1)
//{
//	foreach (int b in arr2)
//	{
//		if (a==b)
//		{
//			Console.WriteLine(a);
//		}
//	}
//}



//int[] arr = { 4, 3, 8, 1, 9, 5 };
//int n = array.Length;
//do
//{
//    int i = 0;
//    while (i < n - 1)
//    {
//        if (array[i] > array[i + 1])
//        {
//            int temp = array[i];
//            array[i] = array[i + 1];
//            array[i + 1] = temp;
//        }
//        i++;
//    }
//    c