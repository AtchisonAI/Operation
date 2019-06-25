using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
           oper  = OperationFactory.createOperate("/");
            oper.NumberA = 2;
            oper.NumberB = 1;

            double result = oper.GetResult();

            Console.Write(result);
            Console.Read();

        }

        public class Operation
        {
            private double numberA = 0;
            private double numberB = 0;

            public double NumberA
            {
                get { return numberA; }
                set { numberA = value; }
            }

            public double NumberB
            {
                get { return numberB; }
                set { numberB = value; }
            }

            public virtual double GetResult()
            {
                double result = 0;
                return result;
            }
        }

        public class OperationAdd : Operation
        {
            public override  double GetResult()
            {
                double result = 0;
                result = NumberA + NumberB;
                return result;
            }
        }

        public class OperationSub : Operation
        {
            public override double GetResult()
            {
                double result = 0;
                result = NumberA - NumberB;
                return result;
            }
        }

        public class OperationMul : Operation
        {
            public override double GetResult()
            {
                double result = 0;
                result = NumberA * NumberB;
                return result;
            }
        }

        public class OperationDiv : Operation
        {
            public override double GetResult()
            {
                double result = 0;
                if (NumberB == 0)
                {
                    throw new Exception("除数不能为0！");
                }
                result = NumberA / NumberB;
                return result;
            }
        }

        public class OperationFactory
        {
            public static Operation createOperate(string operate)
            {
                Operation oper = null;
                switch (operate)
                {
                    case "+":
                        oper = new OperationAdd();
                        break;
                    case "-":
                        oper = new OperationSub();
                        break;
                    case "*":
                        oper = new OperationMul();
                        break;
                    case "/":
                        oper = new OperationDiv();
                        break;
                }

                return oper;
            }
            
        }
    
    }
}
