using System;

namespace LambdaExpressionsLesson
{
    class Program
    {
        // пример синтексиса лямбда-выражений
        //(список параметров) => выражение
        // пример лямбда-выражения без параметров
        private delegate void Hello();

        //  в этом выражениии в качестве параметра мы пеедаем string
        private delegate void Welcome(string str);

        // выражение будет возвращать нам int
        private delegate int Operation(int x, int y); 

        static void Main(string[] args)
        {
            Hello hello1 = () => Console.WriteLine("\nHello"); // выражение без параметров пустые скобки обязательны!!!
            Hello hello2 = () => Console.WriteLine("\nArtsiom");
            hello1();
            hello2();
            // в этом выражениии в качестве параметра мы пеедаем string

            Welcome  welcome1 = (string s) => Console.WriteLine("\nWelcome");
            Welcome welcome2 = (string s) => Console.WriteLine("\nArtsiom");
            welcome1("");
            welcome2("");

            // выражение которое нам будет возвращать int значение переменной

            Operation operation1 = (x, y) => x * y;
            Console.WriteLine(operation1(20,136));

            Operation operation2 = (x, y) => x + y;
            Console.WriteLine(operation2(111,888));

            Console.Read();
        }
    }
}
