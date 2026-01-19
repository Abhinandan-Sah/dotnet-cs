namespace Questions_TopBrains
{
    public class ArithmeticExpressions
    {
        public static void ArithmeticExpressionsAnswer()
        {
            Console.WriteLine("Enter the string values: ");
            string s = Console.ReadLine();

            // 1. Split by space
            string[] st = s.Split(' ');

            // 2. Validate format
            if (st.Length != 3)
            {
                Console.WriteLine("Error:InvalidExpression");
                return;
            }

            // 3. Convert first operand
            if (!int.TryParse(st[0].Trim(), out int a))
            {
                Console.WriteLine("Error:InvalidNumber");
                return;
            }

            // 4. Read operator
            string op = st[1].Trim();

            // 5. Convert second operand
            if (!int.TryParse(st[2].Trim(), out int b))
            {
                Console.WriteLine("Error:InvalidNumber");
                return;
            }

            decimal result = 0; 
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error:DivisionByZero");
                        return;
                    }
                    result = (decimal)a / b;
                    break;
                default:
                    Console.WriteLine("Error:InvalidOperator");
                    return;
            }
            Console.WriteLine($"Result: {result}");


        }
    }
}