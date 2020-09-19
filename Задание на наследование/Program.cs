using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_на_наследование
{
    class Program
    {
//    	Пример с животными
        public abstract class Pets
        {
            public string name { get; set; }
            public string owner { get; set; }
            public void Info()
            {
                Console.WriteLine(name);
                Console.WriteLine(owner);
            }
            public abstract void ShowSkils();
          
        }
        public class Dogs : Pets
        {
            public override void ShowSkils()
            {
                Console.WriteLine("Barking");
                Console.WriteLine("Guarding");
                Console.WriteLine("Sleaping");
            }
        }
        public class Puppe : Dogs
        {
            public override void ShowSkils()
            {
                Console.WriteLine("Barking");
                Console.WriteLine("Sleaping");
            }
        }
//        Пример с фигурами
		public abstract class fSquare
		{
			public double length;
			public fSquare(int Length)
			{
				length=Length;
				
			}
			public abstract  double Square();
		}
		public class Rectangle : fSquare
		{
			public double width;
			public Rectangle(int Length,int Width):base(Length)
			{
				width=Width;
			}
				public override double  Square()
				{
					return length*width;
				}
			
		}
		public class VRectangle : Rectangle
		{
			public double hight;
			public VRectangle(int Length,int Width, int Higth):base(Length,Width)
			{
				hight=Higth;
			}
			public override double Square()
		{
				return 2*(length*width+length*hight+hight*width);
		}
		}
		
		
        static void Main(string[] args)
        {
            Dogs dog1 = new Dogs();
            dog1.name = "Шарик";
            dog1.owner = "Василий Иванович";
            Puppe dog2 = new Puppe();
            dog2.name = "Бобик";
            dog2.owner = "Афанасий Иванович";
            var dogs = new Pets[] { dog1, dog2 };
            foreach (var dog in dogs)
            {
                dog.Info();
                dog.ShowSkils();
            }
            Rectangle f1=new Rectangle(10,20);
            VRectangle f2= new VRectangle(10,20,5);
            Console.WriteLine(f1.Square());
            Console.WriteLine(f2.Square());
            Console.ReadLine();
        }
    }
}
