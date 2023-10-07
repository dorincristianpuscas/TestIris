namespace TestIris
{
    public static class SingleNumberProblem
    {
        public static string SolveWithInputValidations(int[] input)
        {
            Dictionary<int, int> numberAppearances = new Dictionary<int, int>();
            foreach (int number in input)
            {
                if (!numberAppearances.ContainsKey(number))
                {
                    numberAppearances[number] = 1;
                }
                else
                {
                    numberAppearances[number]++;
                }
            }

            if (numberAppearances.Values.Where(v => v != 2).Count() != 1)
            {
                return "The input array is not in the correct format.";
            }

            return numberAppearances.Values.Where(v => v != 2).Count() != 1 ? 
                "The input array is not in the correct format." : 
                $"The single number is {numberAppearances.Keys.First(k => numberAppearances[k] == 1)}.";
        }

        public static string SolveWithoutInputValidations(int[] input)
        {
            int result = 0;
            foreach (int number in input)
            {
                result ^= number;
            }

            return $"The single number is {result}.";
        }
    }
}
