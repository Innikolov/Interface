using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Garden
    {
        static void Main(string[] args)
        {
            var flowers = new List<Flowers> { };
            flowers.Add(new Flowers());
            flowers[0].Name = "Orchid";
            flowers[0].Size = 26;
            Console.WriteLine("Flowers: ");
            Console.WriteLine("This {0} is a {1}, and its {2} cm in height", flowers[0].Type, flowers[0].Name, flowers[0].Size);
            flowers[0].WaterTheFlower();

            flowers.Add(new Flowers());
            flowers[1].Name = "Violet";
            flowers[1].Size = 15;
            Console.WriteLine("This {0} is a {1}, and its {2} cm in height", flowers[1].Type, flowers[1].Name, flowers[1].Size);
            flowers[1].WaterTheFlower();

            var fruitTree = new List<FruitTrees> { };
            fruitTree.Add(new FruitTrees());
            fruitTree[0].FruitName = "Apple";
            fruitTree[0].Size = 256;
            fruitTree[0].FruitCount = 23;
            Console.WriteLine("\nFruit trees: ");
            Console.WriteLine("This is a/an {0} {1}, and its {2} cm in height", fruitTree[0].FruitName, fruitTree[0].Type, fruitTree[0].Size);
            fruitTree[0].GetFruit();

            fruitTree.Add(new FruitTrees());
            fruitTree[1].FruitName = "Lemon";
            fruitTree[1].Size = 198;
            fruitTree[1].FruitCount = 34;
            Console.WriteLine("This is a/an {0} {1}, and its {2} cm in height", fruitTree[1].FruitName, fruitTree[1].Type, fruitTree[1].Size);
            fruitTree[1].GetFruit();

            Console.WriteLine();
            Console.WriteLine();
            fruitTree[0].SitAndRelax();

            ComparePlants(flowers[0], fruitTree[1]);

            Console.ReadLine();


            void ComparePlants(Plants one, Plants two)
            {
                if (one.CompareTo(two) > 0)
                {
                    Console.WriteLine($"{one.Type} is higher than {two.Type}");
                }
                else if (one.CompareTo(two) == 0)
                {
                    Console.WriteLine("Planes are with equal height!");
                }
                else
                {
                    Console.WriteLine($"{one.Type} is lower than {two.Type}");
                }

            }

            
        }
    }
}
