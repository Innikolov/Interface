using System;


namespace Abstract
{
    public class FruitTrees : Trees
    {
        public string FruitName { get; set; }

        public int FruitCount { get; set; }

        public override string Type
        {
            get
            {
                return "Tree";
            }
        }

        public void GetFruit()
        {
            Console.WriteLine($"You just picked a/an {this.FruitName}, now there are {this.FruitCount - 1} left. ");
        }

    }
}
