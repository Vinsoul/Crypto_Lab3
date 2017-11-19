using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Lab3
{
    class RNG
    {
        static BigInteger p = BigInteger.Parse("0D5BBB96D30086EC484EBA3D7F9CAEB07", System.Globalization.NumberStyles.AllowHexSpecifier);
        static BigInteger q = BigInteger.Parse("0425D2B9BFDB25B9CF6C416CC6E37B59C1F", System.Globalization.NumberStyles.AllowHexSpecifier);
        static BigInteger n = p * q;

        public static BigInteger Next(int bits)
        {
            return Next(1, BigInteger.Pow(2, bits));
        }

        public static BigInteger Next(BigInteger upperLimit)
        {
            return Next(1, upperLimit);
        }

        public static BigInteger Next(BigInteger lowerLimit, BigInteger upperLimit)
        {
            int bytes = (upperLimit - lowerLimit).ToByteArray().Length;
            return new BigInteger(BBS_Bytes((int)DateTime.Now.Ticks, bytes));
        }

        public static byte[] BBS_Bytes(int x0, int bytes)
        {
            byte[] result = new byte[bytes];

            BigInteger current = x0;
            for (int i = 0; i < 8 * bytes; i++)
            {
                current = BigInteger.ModPow(current, 2, n);
                result[i] = (byte)(current % 256);
            }

            return result;
        }
    }
}
