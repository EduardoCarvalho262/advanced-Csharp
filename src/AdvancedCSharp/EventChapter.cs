using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    //Step 1 Create a delegate
    public delegate void MyIntChangedEventHandler(object sender, JobNoEventArgs e);

    public class EventChapter
    {

    }

    public class Sender
    {
        private MyIntChangedEventHandler? myIntChanged;
        //Step-2 Create the event based on your own delegate
        public event MyIntChangedEventHandler? MyIntChanged
        {
            add
            {
                myIntChanged += value;
                Console.WriteLine("Inside of add method");
            }

            remove
            {
                myIntChanged -= value;
                Console.WriteLine("Inside of remove method");
            }
        }

        private int myInt;
        public int MyInt
        {
            get { return myInt; }

            set
            {
                myInt = value;
                OnMyIntChanged();
            }
        }

        protected virtual void OnMyIntChanged() //Step 3
        {
            if (myIntChanged != null)
            {
                JobNoEventArgs e = new JobNoEventArgs();
                e.JobNo = MyInt;
                myIntChanged(this, e);
            }      
        }
    }

    public class Receiver //Step 4
    {
        public void GetNotificationFromSender(Object sender, JobNoEventArgs e) //Same a assignment for delegate
        {
            Console.WriteLine("Receiver receives a notification: Sender recently has changed the myInt valut to {0}", e.JobNo);
        }
    }

    public class JobNoEventArgs : EventArgs 
    {
        int jobNo = 0;
        public int JobNo
        {
            get { return jobNo; }
            set { jobNo = value; }
        }
    }

}
