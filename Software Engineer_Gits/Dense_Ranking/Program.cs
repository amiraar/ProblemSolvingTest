using System;
using System.Linq;

public class Program
{
    public static int[] DenseRanking(int[] scores, int[] gitsScores)
    {
        // Buat daftar unik dari skor pemain
        var uniqueScores = scores.Distinct().OrderByDescending(score => score).ToArray();
        
        // Buat kamus untuk menyimpan peringkat berdasarkan skor
        var rankMap = uniqueScores.Select((score, index) => new { Score = score, Rank = index + 1 })
                                  .ToDictionary(item => item.Score, item => item.Rank);

        // Hitung peringkat GITS untuk setiap skor yang didapatkan
        int[] ranks = new int[gitsScores.Length];
        for (int i = 0; i < gitsScores.Length; i++)
        {
            int rank = 1;
            for (int j = 0; j < uniqueScores.Length; j++)
            {
                if (gitsScores[i] >= uniqueScores[j])
                {
                    rank = rankMap[uniqueScores[j]];
                    break;
                }
            }
            ranks[i] = rank;
        }

        return ranks;
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Masukkan jumlah pemain: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                throw new ArgumentException("Jumlah pemain harus lebih besar dari 0.");
            }

            Console.Write("Masukkan daftar skor pemain (dipisahkan oleh spasi): ");
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (scores.Length != n)
            {
                throw new ArgumentException("Jumlah skor pemain harus sama dengan jumlah pemain.");
            }

            Console.Write("Masukkan jumlah permainan yang diikuti oleh GITS: ");
            int numGames = int.Parse(Console.ReadLine());

            Console.Write("Masukkan skor yang didapatkan oleh GITS dalam setiap permainan (dipisahkan oleh spasi): ");
            int[] gitsScores = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (gitsScores.Length != numGames)
            {
                throw new ArgumentException("Jumlah skor permainan GITS harus sama dengan jumlah permainan yang diikuti.");
            }

            int[] ranks = DenseRanking(scores, gitsScores);

            Console.WriteLine("Sampel Output:");
            Console.WriteLine(string.Join(" ", ranks));
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi kesalahan: " + e.Message);
        }
    }
}
