
#region Video1
/*
namespace Delegates
{
    delegate string del(string name);//hiring 
    delegate string del2(string name, string accent);
    delegate bool del3(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //section1
            //del translator = new del(EnglishToFrench);//pointing to method
            //string result1 = translator.Invoke("Hi");//invoking the method
            //string result2 = translator("Hi");

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);


            //del2 translator2 = new del2(EnglishToChinese);
            //string result3 = translator2.Invoke("Hi", "a");
            //string result4 = translator2("Hi", "a");

            //Console.WriteLine(result3);
            //Console.WriteLine(result4);


            //section2

            List<int> list = new List<int> { 10, 15, 11, 20, 22, 21, 12 };
            var output1 = GetFilterValues(list, 15, IsGreaterThan);
            var output2 = GetFilterValues(list, 15, IsLessThan);

            foreach (int i in output1)
            {
                Console.WriteLine(i);
            }


        }

        //section1
        //public static string EnglishToSpanish(string name)
        //{
        //    return "Hola";
        //}
        //public static string EnglishToFrench(string name)
        //{
        //    return "Bonjour";
        //}

        //public static string EnglishToGerman(string name)
        //{
        //    return "Hallo";
        //}

        //public static string EnglishToChinese(string name, string accent)
        //{
        //    return "Hallooooo";
        //}

        static List<int> GetFilterValues(List<int> list1, int x, del3 op)
        {
            List<int> result = new List<int>();
            foreach (int item in list1)
            {
                if (op(item, x))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static bool IsGreaterThan(int x, int y)
        {
            return x > y;
        }

        static bool IsLessThan(int x, int y)
        {
            return x < y;
        }
    }
}
*/
#endregion




#region Video2 -> inline method

namespace InlineMethods
{
    delegate int del (int a, int b);
    delegate string SayHiDel(string n);
    delegate void PrintValueDel();//can take parameters or not but no return type
    internal class Program
    {
        static void Main(string[] args)
        {
            del del1 = delegate (int a, int b) { return a + b; };//anonymous method
            int result1 = del1.Invoke(10, 20);
            Console.WriteLine(result1);

            del del2 = (a, b) => a + b;//lambda expression
            int result2 = del2.Invoke(10, 20);
            Console.WriteLine(result2);

            SayHiDel sayHiDel = delegate (string name) { return "Hi " + name; };
            string result3 = sayHiDel.Invoke("John");
            Console.WriteLine(result3);

            SayHiDel sayHiDel2 = (name) => "Hi " + name;
            string result4 = sayHiDel2.Invoke("John");
            Console.WriteLine(result4);

            //no parameters and no return type
            PrintValueDel printValueDel = delegate () { Console.WriteLine("Hello World"); };
            printValueDel.Invoke();

            PrintValueDel printValueDel2 = () => Console.WriteLine(33);
            printValueDel2.Invoke();
        }
    }
}



#endregion