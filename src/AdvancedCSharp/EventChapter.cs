using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    public class EventChapter
    {
    }

    public class Sender
    {
        public event EventHandler? MyIntChanged;

        private int myInt;
        public int MyInt
        {
            get
            {
                return myInt;
            }

            set
            {
                myInt = value;
                OnMyIntChanged();
            }
        }

        private void OnMyIntChanged()
        {
            if(MyIntChanged != null)   
                MyIntChanged(this, EventArgs.Empty);
        }

        public void GetNotifications(Object sender, EventArgs e)
        {
            Console.WriteLine("Sender himself send a notification: i have changed myint value to {0}", myInt);
        }
    }

    public class Receiver
    {
        public void GetNotificationFromSender(Object sender, EventArgs e)
        {
            Console.WriteLine("Receiver receives a notification: Sender recently has chagned the myInt values.");
        }
    }

}
