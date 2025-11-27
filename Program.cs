using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tnayinn
{
    

   
    
      class animal
        {
            public string nam {  get; set; }

            public virtual void speak ()
            {
                Console.WriteLine("Animal Sound");


            }

            class Dog : animal
            {
                public override void speak()
                {
                    Console.WriteLine("Woof!");
                }

            }

            class Cat : animal
            {
                public override void speak()

                {
                    Console.WriteLine("Meow!");
                }

                
            }

            class Cow : animal 
            {

                public override void speak()
                {
                    Console.WriteLine("Moo!");
                }
        }

        class Name 
        {
            
        }
 

                class program 
            {
                
        static void Main(string[] args)
        {
            
            {

                    animal[] Animals = new animal[3];

                    Animals[0] = new Dog() { nam = "Pluto" };
                    Animals[1] = new Cat() { nam = "Murka" };
                    Animals[2] = new Cow() { nam = "Zeus" };

                    for (int i = 0; i < Animals.Length; i++)
                    {
                        Console.WriteLine(Animals[i].nam + ": ");

                        Animals[i].speak();
                    }





                }

            
            }
        }

    }

}
