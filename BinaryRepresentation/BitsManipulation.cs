using System;
using System.Text;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        private const int SIZEOFLONGTOBIT = (sizeof(long) * 8) - 1;

        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            char[] memoryDump = new char[64];           

            for (int i = SIZEOFLONGTOBIT; i >= 0; i--)
            {
                long mask = 1L << i;
                memoryDump[SIZEOFLONGTOBIT - i] = (number & mask) != 0 ? '1' : '0';
            }

            return new string(memoryDump);
        }
    }
}
