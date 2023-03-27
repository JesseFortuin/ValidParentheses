namespace ValidParentheses.BL
{
    public class ParenthesesChecker : IParenthesesChecker
    {
        public bool ValidParentheses(string str)
        {
            int open = 0;

            int closed = 0;

            if (string.IsNullOrEmpty(str))
            {
                return true;
            }

            if (str.StartsWith(")") && str.EndsWith("("))
            {
                return false;
            }

            foreach (char parenthesis in str)
            {
                if (parenthesis == '(') 
                {
                    open++;
                }

                if (parenthesis == ')') 
                {
                    closed++;

                    if (closed > open)
                    {
                        return false;
                    }
                }
            }

            open = str.Count(x => x.ToString() == "(");

            closed = str.Count(y => y.ToString() == ")");

            if (open == closed)
            {
                return true;
            }

            return false;
        }
    }
}