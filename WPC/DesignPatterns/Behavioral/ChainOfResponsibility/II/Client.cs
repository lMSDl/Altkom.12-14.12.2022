using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Client
    {
        public static void Execute()
        {
            var textBoxFrame = new Frame() { Name = "textBoxFrame" };
            var textBox = new TextBox() { Name = "textBox" };
            textBoxFrame.Add(textBox);

            var buttonFrame = new Frame() { Name = "buttonFrame" };
            var button = new Button() { Name = "button" };
            buttonFrame.Add(button);

            textBox.Add(buttonFrame);


            button.OnClick = () =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;
                textBox.Text = null;
                return true;
            };

            Console.WriteLine("---");
            textBoxFrame.Click();
            Console.WriteLine("---");
            button.Click();
            Console.WriteLine("---");
            textBox.Click();
            Console.WriteLine("---");
            textBox.Text = "abc";
            Console.WriteLine("---");
            button.Click();
            Console.WriteLine("---");
            button.Click();
        }
    }
}
