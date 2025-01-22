using System;

namespace ConsoleApp15
{

    //parent class
    class fruit
    {
        protected void apple()
        {
            Console.WriteLine("apple is a fruit");
        }
    }
    //child1 extend parent
    class fruit1 : fruit
    {
        public void orange()
        {

            Console.WriteLine("orange is fruits");
        }
        //child2 extend child1 child1 have a data in parent
        class fruit2 : fruit1
        {
            public void grapes()
            {

                Console.WriteLine("grapes is fruits");
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    fruit2 obj=new fruit2();
                    obj.grapes();
                    obj.orange();
                    obj.apple();

                }
            }
        }
    }

}
