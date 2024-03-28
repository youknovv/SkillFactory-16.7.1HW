namespace Module16
{
    public class Calculator
    {
        public int Subtraction(int a, int b) //использовала метод в предыдущем задании, не стала дублировать в дз
        {
            return a - b;
        }

        public int Division(int a, int b) //использовала метод в предыдущем задании, не стала дублировать в дз
        {
            return a / b;
        }

        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Addition(int a, int b) //перегрузка для домашнего задания
        {
            return a + b;
        }

        public int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
        
        public int Multiplication (int a, int b) //перегрузка для домашнего задания
        {
            return a * b;
        }
        
    }
}