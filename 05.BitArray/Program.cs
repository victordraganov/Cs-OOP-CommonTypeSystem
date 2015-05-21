//05.Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _05.BitArray
{
    using System;

    class Program
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(15);

            Console.Write("The number {0} in bits: ",number);
            foreach (var item in number)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
