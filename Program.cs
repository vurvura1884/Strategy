using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy
{
    class Program
    {
        public abstract class Strategy
        {
            public abstract void Do();
        }
        public class Speaking : Strategy
        {
            public override void Do()
            {
                Console.WriteLine("To speak");
            }
        }
        public class Writing : Strategy
        {
            public override void Do()
            {
                Console.WriteLine("To write");
            }
        }
        public class Reading : Strategy
        {
            public override void Do()
            {
                Console.WriteLine("To read");
            }
        }
        public class Listening : Strategy
        {
            public override void Do()
            {
                Console.WriteLine("To listen");
            }
        }


        public class RussianLanguage
        {
            Strategy strategy;
            public RussianLanguage(Strategy strategy)
            {
                this.strategy = strategy;
            }
            public Strategy st
            {
                get { return strategy; }
                set { strategy = value; }
            }
            public void DoIt()
            {
                strategy.Do();
            }
        }


        public class EnglishLanguage
        {
            Strategy strategy;
            public EnglishLanguage(Strategy strategy)
            {
                this.strategy = strategy;
            }
            public Strategy st
            {
                get { return strategy; }
                set { strategy = value; }
            }
            public void DoIt()
            {
                strategy.Do();
            }
        }

        
        static void Main(string[] args)
        {
            RussianLanguage rl = new RussianLanguage(new Speaking());
            rl.DoIt();
            rl.st = new Writing();
            rl.DoIt();
            Console.WriteLine("\n");
            EnglishLanguage el = new EnglishLanguage(new Reading());
            el.DoIt();
            el.st = new Listening();
            el.DoIt();
        }
    }
}
