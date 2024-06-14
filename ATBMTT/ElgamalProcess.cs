using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace ATBMTT
{
    public class ElgamalProcess
    {
        private static readonly long MIN = 10000000;
        private static readonly long MAX = 100000000;

        public static string HashString(string text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                BigInteger number = new BigInteger(hashBytes);
                string hexString = number.ToString("X");
                return hexString.PadLeft(64, '0');
            }
        }

        public static BigInteger Gcd(BigInteger a, BigInteger b)
        {
            if (b == BigInteger.Zero)
            {
                return a;
            }
            return Gcd(b, BigInteger.Remainder(a, b));
        }

        public static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            for (long i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static BigInteger Sqrt(BigInteger n)
        {
            if (n.CompareTo(BigInteger.Zero) <= 0)
            {
                return BigInteger.Zero;
            }
            BigInteger left = BigInteger.One;
            BigInteger right = n;
            while (left.CompareTo(right) < 0)
            {
                BigInteger mid = (left + right) >> 1;
                if (BigInteger.Multiply(mid, mid).CompareTo(n) <= 0)
                {
                    left = mid + BigInteger.One;
                }
                else
                {
                    right = mid;
                }
            }
            return left - BigInteger.One;
        }

        public static long ChoicePrime()
        {
            Random rand = new Random();
            long result;
            do
            {
                result = rand.Next((int)MIN, (int)MAX + 1);
            } while (!IsPrime(result));
            return result;
        }

/*        public static BigInteger PowMod(BigInteger a, BigInteger b, BigInteger n)
        {
            BigInteger result = BigInteger.One;
            while (b.CompareTo(BigInteger.Zero) > 0)
            {
                if (b.IsEven)
                {
                    a = BigInteger.ModPow(a, 2, n);
                    b = b / 2;
                }
                else
                {
                    result = BigInteger.ModPow(result * a, BigInteger.One, n);
                    b -= BigInteger.One;
                }
            }
            return result;
        }*/

        public static BigInteger[] ExtendedEuclid(BigInteger a, BigInteger b)
        {
            if (b.Equals(BigInteger.Zero))
            {
                return new BigInteger[] { BigInteger.One, BigInteger.Zero };
            }
            else
            {
                BigInteger[] vals = ExtendedEuclid(b, a % b);
                BigInteger temp = vals[1];
                vals[1] = vals[0] - (a / b) * vals[1];
                vals[0] = temp;
                return vals;
            }
        }


        public static BigInteger ModInverse(BigInteger k, BigInteger p)
        {
            BigInteger m0 = p, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (p == 1)
                return 0;

            while (k > 1)
            {
                q = k / p;
                t = p;
                p = k % p;
                k = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        static RandomNumberGenerator rng = RandomNumberGenerator.Create();

        public static BigInteger GenerateRandomAlpha(BigInteger p)
        {
            byte[] data = new byte[p.ToByteArray().Length];
            rng.GetBytes(data);
            BigInteger alpha = new BigInteger(data);

            // Đảm bảo alpha > 1 và alpha < p
            alpha = BigInteger.Abs(alpha);
            alpha %= p - 1;
            alpha += 1;

            return alpha;
        }

        public static List<BigInteger> CreKey()
        {
            List<BigInteger> keys = new List<BigInteger>();
            long tmp = ChoicePrime();
            BigInteger p = new BigInteger(tmp);
            BigInteger alpha = GenerateRandomAlpha(p);
            BigInteger a = GenerateRandomAlpha(p);
            BigInteger beta = BigInteger.ModPow(alpha, a, p);
            BigInteger k;
            do
            {
                k = GenerateRandomAlpha(p);
                while(k == p-1)
                {
                    k = GenerateRandomAlpha(p);
                }
            } while (!Gcd(k, p - 1).Equals(BigInteger.One));
            BigInteger r = BigInteger.ModPow(alpha, k, p);
            keys.Add(p);
            keys.Add(alpha);
            keys.Add(beta);
            keys.Add(a);
            keys.Add(k);
            keys.Add(r);
            return keys;
        }

        public static string CreateSign(string text, BigInteger r, BigInteger a, BigInteger k, BigInteger p)
        {
            // Hàm băm để lấy chuỗi băm của văn bản
            string textHash = HashString(text);
            char[] textAscii = textHash.ToCharArray();
            List<BigInteger> result = new List<BigInteger>();
            BigInteger kInv = ModInverse(k, p - 1);

            foreach (char c in textAscii)
            {
                int charAscii = (int)c;
                // Tính toán s với điều chỉnh kết quả về dương
                BigInteger s = ((charAscii - (a * r)) * kInv) % (p - 1);
                if (s < 0)
                {
                    s += (p -1);
                }
                result.Add(s);
            }

            // Chuyển đổi kết quả sang chuỗi và trả về
            return string.Join(",", result);
        }

        public static bool VerifySign(string text, string sign, BigInteger beta, BigInteger r, BigInteger alpha, BigInteger p)
        {
            string textHash = HashString(text);
            char[] textAscii = textHash.ToCharArray();
            List<BigInteger> signList = new List<BigInteger>();

            // Chuyển đổi chuỗi sign thành danh sách các số nguyên
            foreach (string str in sign.Split(','))
            {
                signList.Add(BigInteger.Parse(str));
            }

            // Kiểm tra độ dài của textHash và signList
            if (textAscii.Length != signList.Count)
            {
                return false;
            }

            // Kiểm tra từng ký tự và giá trị trong signList
            for (int i = 0; i < textAscii.Length; i++)
            {
                BigInteger v = (BigInteger.ModPow(beta, r, p) * BigInteger.ModPow(r, signList[i], p)) % p;
                BigInteger u = BigInteger.ModPow(alpha, (int)textAscii[i], p);

                if (!u.Equals(v))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
