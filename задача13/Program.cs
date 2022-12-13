Console.WriteLine ("Введите трехзначное чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
int b = a % 10 ;
if (a>99&&a<1000||a<-99&&a>-1000)
    Console.WriteLine ("Третье число " +b);
else
    Console.WriteLine("Ччисло не трехзначное.");
 