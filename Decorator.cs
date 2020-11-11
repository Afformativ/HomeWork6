using System;
using System.Collections.Generic;

namespace Decorator
{
    public abstract class Tree
    {
        public virtual void Appearance()
        {
            Console.WriteLine("Simple tree");
        }
    }

    public class ChristmasTree : Tree
    {
        public override void Appearance()
        {
            Console.WriteLine("Christmas tree");
        }
    }

    public abstract class ChristmasTreeDecorator : Tree
    {
        protected Tree tree;
        public ChristmasTreeDecorator(Tree _tree)
        {
            this.tree = _tree;
        }
    }

    public class ToysDecorator : ChristmasTreeDecorator
    {
        private string toys = "Toys: dog , cat , did moroz, star";
        public ToysDecorator(Tree _tree) : base(_tree)
        { }
        public override void Appearance()
        {
            tree.Appearance();
            Console.WriteLine(toys);
        }
    }

    public class GarlandDecorator : ChristmasTreeDecorator
    {
        public GarlandDecorator(Tree _tree) : base(_tree)
        { }

        public override void Appearance()
        {
            tree.Appearance();
            Shy();
        }

        private void Shy()
        {
            Console.WriteLine("Tree is shining");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree christmasTree = new ChristmasTree();
            christmasTree = new ToysDecorator(christmasTree);
            christmasTree = new GarlandDecorator(christmasTree);
            christmasTree.Appearance();
        }
    }
}