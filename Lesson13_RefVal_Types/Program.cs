using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Lesson 13. Value and Reference types.");
        // Value type. Разметный(Значимый) тип. Копирование по значению. Переменная не меняется. С помощью  ref - это работа с копией памяти, а не с самой переменной(можно менять).
        // Они внутри себя хрянат непосредственно значение.

        // Refference type. Копирование по ссылке. 2 части: Значение (лежит в папяти) и ССЫЛКА на это значение  Переменная меняется, так как работает с копией пямяти (ссылка указывает на ячейку в памяти)
        //****************************************

        /*
        int x = 1;
        int y = x; // y переносит в себя непосредственно значение, и сохраняет в себе, не зависимо что дальше произойдет с x.
        Console.WriteLine("x = 1, y = x");
        Console.WriteLine(x);   // 1
        Console.WriteLine(y);   // 1

        x = 2;
        Console.WriteLine("x = 2, y = x");
        Console.WriteLine(x);   // 2
        Console.WriteLine(y);   // 1. Т.К. в начале он в себя скопировал начальный х=1.
        */

        //*** Refference type. Ссылка одинаковая , а значит поменяется переменная, если ее изменить ЛЮБОМУ массиву.

        // массивы
        /*
        int[] arr = new int[] { 1, 2, 21 };
        int[] arrBBB = arr;
        Console.WriteLine(arr[2]);    //21
        Console.WriteLine(arrBBB[2]);   //21

        arrBBB[0] = 30;                   // Меняем значение в первой ячейке на 30. 
        Console.WriteLine(arr[0]);    //30  Т.К. ссылка на ячейку памяти у обоих массивов оддинакова, то и нзначение первой ячеки ИЗМЕНЕНО.
        */

        // *1 классы - тоже ссылочный тип.
        /*
        var personAlex = new Person() { Name = "Alex" };
        var personJon = personAlex;         // скопировали ссылку на само значение в памяти.
        Console.WriteLine(personAlex.Name); // Alex
        Console.WriteLine(personJon.Name);  // Alex
        
        personJon.Name = "Jon";             // По тойже ссылке в тойже ячейке памяти сменили на Jon.
        Console.WriteLine(personAlex.Name); // Jon Т.К. ссыла и ячейка одна и таже, а ее ИЗМЕНИЛИ.
        Console.WriteLine(personJon.Name);  // Jon
        */

        // *2 Методы.
        /*
                // Value type. int a = 3;
        static void Add(int x)   // Метод Увеличивает значение на +1
        {
            x = x + 1;
        }

        int a = 3;        
        Add(a);     //******В МЕТОД передается копия значения а. Происходит увеличение на +1, но ОРИГИНАЛ не поменялся.
        Console.WriteLine(a);   // 3. Т.К. в метод было передано копия значения а.
        
                // Reffereebce type.              
        static void AddArray(int[] array) { array[0] = array[0] + 1; } 

        int[] baceArray= new int[] {1, 2, 21};
        AddArray(baceArray);
        Console.WriteLine(baceArray[0]);    // [0] = 2. Метод AddArray - Успешен и первое значение увеличилось на +1. Т.К. массивы это ссылочный тип.

        int[] caceArray = baceArray;
        caceArray[0] = 7;               // Заменяем первое значение ДРУГИМ массивом наш Базовый массив на 7.
        AddArray(caceArray);        //***** В МЕТОД БЫЛ ПЕРЕДАНА ССЫЛКА НА ЯЧЕЙКУ ПАМЯТИ, Поэтому переменная в памяти и меняется.
        Console.WriteLine(caceArray[0]);    //[0] = 8. Основной массив был изменен дополнительным массивом.
        */

        // *****  ref.
        /*
        static void AddRef(ref int x)   // ref указывает, что передается ссылка на переменную, а значит, она изменится.
        {
            x = x + 1;
        }

        int b = 5;
        AddRef(ref b);          //***** ref b - теперь b поменялась согласно методу!!!
        Console.WriteLine(b);   // 6.
        */

        // ***3 string. Сложная структура, ПЕРЕМЕННЫЕ НЕ МЕНЯЮТСЯ!!!! Строки не изменяются. Создаются ВСЕГДА КОПИИ обьекта!.

        /*
        string a = "123";
        string b = a;
        Console.WriteLine(a);
        Console.WriteLine(b);

        b = "qwe";
        Console.WriteLine(a);
        Console.WriteLine(b);

            // *****Для сложения больших и много строк используйте StringBuilder
        */

        // ******* 4.  ****** Чтобы ссылочный тип не менял оригинал.
        /*
        var personAlex = new Person() { Name = "Alex" };
        var personJon = personAlex.Clone();
        Console.WriteLine(personAlex.Name); // Alex.
        Console.WriteLine(((Person)personJon).Name);    // Alex

        ((Person)personJon).Name = "Jon";

        Console.WriteLine(personAlex.Name);             // Alex
        Console.WriteLine(((Person)personJon).Name);    // Jon
        */
    }

    /*
     // *1
     public class Person
     {
         public string Name { get; set; }
     }
    */

    // *4 
    /*
    public class Person : ICloneable    // Создает клон оригинала, в итоге оригинал не изменяется.
    {
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
    */




} 