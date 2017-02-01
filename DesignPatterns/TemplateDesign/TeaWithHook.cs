using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateDesign
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            Console.WriteLine();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            // get the user's response
            var answer = "y";
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            Console.WriteLine("Would you like lemon with your tea (y/n)? ");
            
            try
            {
                keyInfo = Console.ReadKey();                
            }
            catch (Exception ioe)
            {
                Console.WriteLine("IO error trying to read your answer");
            }
            if (keyInfo.Key != ConsoleKey.Y)
            {
                return "no";
            }
            return answer;
        }
    }
}
