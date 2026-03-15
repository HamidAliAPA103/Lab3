
// 1ci mesele

//int num1 = 2;
//int num2 = 3;
//static void Add(ref int num1 , ref int num2)
//{
//    int resoult = num1;
//    num1 = num2;
//    num2 = resoult;
//}
//Add(ref num1, ref num2);

//Console.WriteLine(" num1 =" + num1); 
//Console.WriteLine(" num2 =" + num2);


//2ci mesele

//int num1 = 5;
//static void Plus(ref int num1)
//{
//    int eded = 10;
//    eded += num1;
//Console.WriteLine("cem :" + eded);
//}
//Plus(ref num1);


//3cu mesele

//Plus(out int resoult);
//static void Plus(out int result)
//{

//    int num1 = 50;
//    result = num1 / 10;

//    Console.WriteLine("bolunen :" + result);
//}

//4cu mesele

//static void FindMinMax(int a, int b, int c, out int min, out int max)
//{
//     min = a;
//     max = a;
//    if (b < a) min = b;
//    if (c < a) min = c;
//    if (b > a) max = b;
//    if (c > a) max = c;
//    Console.WriteLine($"{min} {max}");

//}
//int min = 0;
//int max = 0;
//FindMinMax(35, 5, 4,out  min, out max);


//7ci mesele

//double[] prices = { 50,100,150, 200 };

//Endirim( prices);
//static void Endirim( double[] prices)
//{

//    for (int i = 0; i < prices.Length; i++)
//    {
//        prices[i] = prices[i] * 0.6;
//    }

//    for (int i = 0; i < prices.Length; i++)
//    {
//        Console.WriteLine(prices[i]); ;
//    }


//}

//5ci mesele

//Console.WriteLine("bal daxil edin : ");
//int score =int.Parse(Console.ReadLine());
//Console.WriteLine(" artacaq bal daxil edin : ");
//int score2 =int.Parse(Console.ReadLine());
//Console.WriteLine("umumi bal : ");


//IncreaseScore(ref score,score2);
//static void IncreaseScore(ref int score,int score2)
//{
//  ;
//  int num =score2 + score;
//    Console.WriteLine(num);
//}


//6ci mesele


//Console.WriteLine("ad daxil et");
//string name = Console.ReadLine();

//AdYas(out int years);
//static void AdYas(out int years)
//{
//    Console.WriteLine(" yas daxil et");
//     years = int.Parse(Console.ReadLine());
//    if (years < 18)
//    {
//        Console.WriteLine("yetkin deil" + years);
//    }
//    else
//    {
//        Console.WriteLine("yetkindir" + years);
//    }
//}