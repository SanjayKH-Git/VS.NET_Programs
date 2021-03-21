using System;
using System.Collections.Generic;
using System.Linq;



namespace InfixTo_Prefix_Postfix
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Infix Expression: ");
            string exp = Console.ReadLine();
            Console.Write("Postfix_Exp= {0}\nPrefix_exp={1} ", infixToPostfix(exp), infixToPrefix(exp));            
            Console.ReadLine();
        }

        public static string infixToPostfix(string exp)
        {
            string result = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < exp.Length; ++i)
            {                
                char c = exp[i];
                if (char.IsLetterOrDigit(c))
                    result += c;
                else if (c == '(')
                    stack.Push(c);
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        result += stack.Pop();

                    if (stack.Count > 0 && stack.Peek() != '(')
                        return "Invalid Expression";
                    else
                        stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {                       
                        result += stack.Pop();
                    }

                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
                result += stack.Pop();

          //  stack.Clear();
            return result;
        }

        public static string infixToPrefix(string exp)
        {
            string rev_exp="";
            char[] chars = exp.ToCharArray();            
            for(int j=chars.Length-1;j>=0;j--)
            {
                if (chars[j] == '(')
                    rev_exp += ')';
                else if (chars[j] == ')')
                    rev_exp += '(';
                else                
                    rev_exp += chars[j];
            }            
            var postfix = infixToPostfix(rev_exp);
            var result = new string(postfix.ToCharArray().Reverse().ToArray());
            return result;
        }
                
        internal static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;                
            }
            return -1;
        }
    }
}
