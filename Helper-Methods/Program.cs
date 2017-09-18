using System;

namespace HelperMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine();
            Console.ReadLine();

        }
        //Private allows for the method to be used only in this spacefic class, just a code block with a name is a method
        private static string superSecretFormula()
        {
            //some cool stuff here
            //
            return "hello world";
        }



    }
}
