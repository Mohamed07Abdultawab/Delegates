
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

/*
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

*/

#endregion


#region Video3 -> Delegate Chains 
/*
namespace DelegateChains
{
    delegate void del(string input);
    delegate string strDel(string input);
    internal class Program
    {
        static void Main(string[] args)
        {
            //when return type is void, all methods will be invoked
            del del1 = (input) => Console.WriteLine("Method1: " + input);
            del1 += (input) => Console.WriteLine("Method2: " + input);
            del1 += (input) => Console.WriteLine("Method3: " + input);

            del1.Invoke("Mohamed");


            //when return type is not void, only the last method's return value will be returned
            strDel stringDel1 = (input) =>"Method11: " + input;
            stringDel1 += (input) => "Method22: " + input;
            stringDel1 += (input) => "Method33: " + input;
            //return only method33's return value
            Console.WriteLine(stringDel1.Invoke("Ali"));

        }

        //use lambda expressions instead of these methods
        //static void Method1(string input)
        //{
        //    Console.WriteLine("Method1: " + input);
        //}

        //static void Method2(string input)
        //{
        //    Console.WriteLine("Method2: " + input);
        //}

        //static void Method3(string input)
        //{
        //    Console.WriteLine("Method3: " + input);
        //}
        //static string Method11(string input)
        //{
        //    return ("Method1: " + input);
        //}

        //static string Method22(string input)
        //{
        //    return ("Method2: " + input);
        //}

        //static string Method33(string input)
        //{
        //    return ("Method3: " + input);
        //}


    }
}

*/
#endregion



#region Video3 -> Generic Delegates
/*

//instead use datata types in delegates, we can use generic delegates to make them more flexible and reusable
namespace GenericDelegates
{
    //delegate int del1(int a, int b);
    //delegate string del2(string a, string b);

    delegate T del<T>(T a, T b);//generic delegate
    internal class Program
    {
        static void Main(string[] args)
        {
            del<int> del1 = (a, b) => a + b;
            Console.WriteLine(del1.Invoke(3, 2));

            del<string> del2 = (a, b) => a + b;
            Console.WriteLine(del2.Invoke("Hello ", "World"));
        }
    }
}
*/


#endregion



#region Video4 -> Func - Action - Predicate Delegates
/*

using System;

namespace FuncActionPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func is a delegate that can take number of parameters and last parameters is return a value
            Console.WriteLine("===Test Func===");
            Func<int,int,int> add = (a, b) => a + b;//Func<parameter types, return type>
            Console.WriteLine(add.Invoke(3, 2));

            Func<int,int,int,int,int,int> add2 = (a, b, c, d, e) => a + b + c + d + e;
            Console.WriteLine(add2.Invoke(1, 2, 3, 4, 5));

            Func<int, int, string> print = (a,b) => (a + " " + b);
            Console.WriteLine(print.Invoke(10, 20));





            //Action is a delegate that can take number of parameters but no return type'
            Console.WriteLine("\n===Test Action===");
            // Func can have void return type but we need to return nothing so use action
            Action<string> printMessage = (m) => Console.WriteLine(m);
            printMessage.Invoke("Hello World");

            Action<int, int> printSum = (a, b) => Console.WriteLine(a + b);
            printSum.Invoke(10, 20);




            //Predicate is a delegate that can take one parameter and return a boolean value
            Console.WriteLine("\n===Test Predicate===");
            Predicate<int> IsEven = (a) => a % 2 == 0;
            Console.WriteLine(IsEven.Invoke(10));

            Predicate<string> IsLongerThan5 = (s) => s.Length > 5;
            Console.WriteLine(IsLongerThan5.Invoke("Hello World"));
        }
    }
}

*/
#endregion



#region Video5 -> Events & Observer Pattern
/*
namespace EventsandObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel channel = new YouTubeChannel();

            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();
            Subscriber subscriber3 = new Subscriber();

            subscriber1.Subscribe(channel);
            subscriber2.Subscribe(channel);
            subscriber3.Subscribe(channel);

            channel.UploadVideo("Video 1");
            channel.UploadVideo("Video 2");
            channel.UploadVideo("Video 3");

            //channel.videoUpload("video x");
            //we can't invoke the event from outside the class, only the class that defines the event can invoke it
            //can use += or -= to subscribe or unsubscribe to the event, but can't use = to assign a new method to the event because it will remove all the existing subscribers

            channel.videoUpload += (title) => Console.WriteLine("Another subscriber watch: " + title);
            channel.UploadVideo("Video 4");


        }
    }

    public delegate void VideoUpload(string title);
    public class YouTubeChannel
    {
        //event is a special type of delegate that can only be invoked from within the class that defines it
        //and can only be subscribed to or unsubscribed from using the += and -= operators
        public event VideoUpload videoUpload;
        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"New video uploaded: {videoTitle}");
            videoUpload?.Invoke(videoTitle);
        }
    }

    public class Subscriber
    {
        public void Subscribe(YouTubeChannel channel)
        {
            channel.videoUpload += WatchTheVideo;
        }

        public void WatchTheVideo(string videoTitle)//handler
        {
            Console.WriteLine($"User watch: {videoTitle}");
        }
    }
}
*/
#endregion


#region Video6 -> EventHandler - EventArgs
/*
namespace EventHandlerEventArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel channel1 = new YouTubeChannel() { ChannelName = "My Channel 1" };
            YouTubeChannel channel2 = new YouTubeChannel() { ChannelName = "My Channel 2" };

            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();
            Subscriber subscriber3 = new Subscriber();

            subscriber1.Subscribe(channel1);
            subscriber2.Subscribe(channel2);

            channel1.UploadVideo("Video 1, channel 1");
            channel2.UploadVideo("Video 2, channel 2");

            
        }
    }

  
    public class VideoInfoEventArgs: EventArgs  //custom event args class that inherits from EventArgs, can add any properties we want to pass to the event handlers
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
    }

    //public delegate void VideoUpload(string title);
    public class YouTubeChannel
    {
        public string ChannelName { get; set; }
        public event EventHandler<VideoInfoEventArgs> videoUpload;
        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"New video uploaded: {videoTitle}");
            //invoke the event with the video information as arguments
            videoUpload?.Invoke(this, new VideoInfoEventArgs() { Title = "99",Duration = 15, Description = "Description" });
        }
    }

    public class Subscriber
    {
        public void Subscribe(YouTubeChannel channel)
        {
            channel.videoUpload += WatchTheVideo;
        }

        public void WatchTheVideo(object sender, VideoInfoEventArgs e)//handler
        {
            //sender is the object that raised the event, in this case it's the YouTubeChannel object that uploaded the video
            YouTubeChannel channel = (YouTubeChannel)sender;
            Console.WriteLine($"User watch: {e.Title} & Duration: {e.Duration} & Description: {e.Description} from {channel.ChannelName}");
        }
    }

}
*/

#endregion




#region Video7 -> Covariance & Contravariance

using System.Threading.Channels;

namespace CovarianceContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple01 = new Apple();
            Orange orange01 = new Orange();

            //Covariance: we can assign a derived class object to a base class reference
            Fruit fruit01 = new Apple();
            Fruit fruit02 = new Orange();

            CreateFruitDelegate fruitDelegate = apple01.CreateApple;
            fruitDelegate += orange01.CreateOrange;
            fruitDelegate.Invoke();

            Console.WriteLine("\n====================\n");

            //part2
            //Contravariance: we can assign a base class reference to a derived class reference
            //Apple apple02 = new Fruit();//error because we can't assign a base class reference to a derived class reference


            AppleJuiceFactory appleJuiceFactory = new AppleJuiceFactory();
            FruitJuiceFactory fruitJuiceFactory = new FruitJuiceFactory();


            CreateAppleJuiceDelegate appleJuiceDelegate = appleJuiceFactory.CreateAppleJuice;//Normal
            appleJuiceDelegate += fruitJuiceFactory.CreateFruitJuice;//Contravariance allows us to assign a method that takes a base class parameter to a delegate that expects a derived class parameter, because the method can accept any object of the base class, including objects of the derived class.
            appleJuiceDelegate.Invoke(new Apple());
            //CreateFruitJuiceDelegate fruitJuiceDelegate = appleJuiceFactory.CreateAppleJuice;//Contravariance allows us to assign a method that takes a derived class parameter to a delegate that expects a base class parameter, because the method can accept any object of the derived class, including objects of the base class.
        }
    }

    
    public delegate Fruit CreateFruitDelegate();

    public class Fruit
    {

    }

    public class Apple : Fruit
    {
        public Apple CreateApple()
        {
            Console.WriteLine("New apple created");
            return new Apple();
        }
    }

    public class Orange : Fruit
    {
        public Orange CreateOrange()
        {
            Console.WriteLine("New orange created");
            return new Orange();
        } 
    }
    

    //delegate
    public delegate void CreateFruitJuiceDelegate(Fruit fruit);
    public delegate void CreateAppleJuiceDelegate(Apple apple);
    public class AppleJuiceFactory
    {
        public void CreateAppleJuice(Apple apple)
        {
            Console.WriteLine("Apple juice created");
        }
    }

    public class FruitJuiceFactory
    {
        public void CreateFruitJuice(Fruit fruit)
        {
            Console.WriteLine("Fruit juice created");
        }
    }
}






#endregion