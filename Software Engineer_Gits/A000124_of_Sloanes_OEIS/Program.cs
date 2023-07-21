using System;

class Programs
{
    static string A000124(int n)
    {
        int[] output = new int[n];
        int currentSum = 0;

        for (int i = 1; i <= n; i++)
        {
            currentSum += i;
            output[i - 1] = currentSum;
        }

        return string.Join("-", output);
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Masukkan angka: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                throw new Exception("Input harus lebih besar dari 0.");
            }

            string result = A000124(n);
            Console.WriteLine("Output: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}