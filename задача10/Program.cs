Console.WriteLine ("Введите трехзначное чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
int b = a % 100 / 10;
if (a>99&&a<1000||a<-99&&a>-1000)
    Console.WriteLine ("Второе число" +b);
else
    Console.WriteLine("Не трехзначное число");