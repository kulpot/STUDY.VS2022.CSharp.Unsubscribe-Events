using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=dgAWtz9aFqs&list=PLAE7FECFFFCBE1A54&index=23
//

namespace Unsubscribe_Events
{
    class Person
    {
        Button myButton;
        public Person(Button but)
        {
            myButton = but;
            but.Click += cliffDive;//subscribe
        }
        void cliffDive(object sender, EventArgs e)
        {
            Console.WriteLine("Jumping!");
            myButton.Click -= cliffDive; //unsubscribe
        }
    }

    class MainClass
    {
        static void Main()
        {
            var but = new Button { Text = "Jump!" };
            //but.Click += new Person().cliffDive;
            new Person(but);
            var form = new Form();
            form.Controls.Add(but);
            Application.Run(form);
        }

    }
}
