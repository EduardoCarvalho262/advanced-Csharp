namespace AdvancedCSharp
{
    delegate int DelegateWithTwoIntParameterReturnInt(int x, int y); //Declaração de um delegate
    
    // Ele é geralmente usado para lidar com eventos e chamadas de métodos
    // principamente em programação assincrona.

    class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Multi(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("***A simple delegate demo.***");
            //Console.WriteLine("\n Calling Sum(..) method without using a delegate:");
            ////Console.WriteLine("Sum of 10 and 20 is : {0}", Sum(10, 20));
            //Console.WriteLine("Multi of 2 and 3 is : {0}", Multi(2, 3));
            ////Creating a delegate instance
            ////DelegateWithTwoIntParameterReturnInt delOb = new DelegateWithTwoIntParameterReturnInt(Sum);
            ////Or,simply write as follows:
            //DelegateWithTwoIntParameterReturnInt delOb = Multi;
            //Console.WriteLine("\nCalling Multi(..) method using a delegate.");
            //int total = delOb(2, 3);
            ////Console.WriteLine("Sum of 10 and 20 is: {0}", total);
            //Console.WriteLine("Multi of 2 and 3 is: {0}", total);
            /* Alternative way to calculate the aggregate of the numbers.*/
            //delOb(25,75) is shorthand for delOb.Invoke(25,75)
            //Console.WriteLine("\nUsing Invoke() method on delegate instance, calculating Multi of 2 and 3.");
            //total = delOb.Invoke(2, 3);
            //Console.WriteLine("Multi of 2 and 3 is: {0}", total);
            //Console.ReadKey();


            Console.WriteLine("******* Exploring Custom Events *************");
            var sender = new Sender();
            var receiver = new Receiver();

            sender.MyIntChanged += receiver.GetNotificationFromSender;
            sender.MyInt = 1;
            sender.MyInt = 2;
            //Unregistering now
            sender.MyIntChanged -= receiver.GetNotificationFromSender;
            sender.MyInt = 3;
            Console.ReadKey();

        }
    }
}




