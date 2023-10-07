namespace TestIris
{
    public static class BalancedBracketsProblem
    {
        public static string Solve(string input)
        {
            char[] openingBracketValues = new char[] { '(', '[', '{' };
            int i = -1;
            char[] openingBracketsArray = new char[input.Length];
            foreach (char character in input)
            {
                if (openingBracketValues.Contains(character))
                {
                    openingBracketsArray[++i] = character;
                }
                else
                {
                    if (i >= 0 && IsMatchingClosingBracket(i, openingBracketsArray, character))
                    {
                        i--;
                    }
                    else
                    {
                        return "Not Balanced";
                    }
                }
            }
            return i == -1 ? "Balanced" : "Not Balanced";
        }

        private static bool IsMatchingClosingBracket(int i, char[] openingBracketsArray, char character)
        {
            return (openingBracketsArray[i] == '(' && character == ')') ||
                   (openingBracketsArray[i] == '{' && character == '}') ||
                   (openingBracketsArray[i] == '[' && character == ']');
        }
    }
}
