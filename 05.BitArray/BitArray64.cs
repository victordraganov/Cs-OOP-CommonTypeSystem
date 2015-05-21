namespace _05.BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong bitValues;

        public BitArray64(ulong bits = 0)
        {
            this.bitValues = bits;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var currentItem = this.bitValues;
            bool seniorBitFound = false;
            bool enterIf = true;

            for (int i = 63; i >= 0; i--)
            {
                ulong currentBit = (currentItem & (ulong)(1 << i)) >> i;

                if (currentBit == 1 && enterIf)
                {
                    seniorBitFound = true;
                    enterIf = false;
                }

                if (seniorBitFound)
                {
                    yield return (int)currentBit; 
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return (first.bitValues == second.bitValues);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return (first.bitValues == second.bitValues);
        }

        public override bool Equals(object obj)
        {
            if (this.bitValues == (obj as BitArray64).bitValues)
            {
                return true;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            return (int)(this.bitValues >> 38 ^ this.bitValues >> 43); // Random, but not quite because we push right in order to not lose data. 
        }

        public override string ToString()
        {
            return this.bitValues.ToString();
        }
    }
}
