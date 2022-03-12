using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enigma
{
    class Dial
    {
        public static string DialPlus(int position, string data)
        {
            char[] arrData = data.ToCharArray();

            int countOddGreat = 0;
            int countOddLow = 0;

            int greatIndex = 0;
            int lowIndex = 0;

            if (arrData.Length % 2 == 0)
            {
                countOddGreat = arrData.Length / 2;
                countOddLow = arrData.Length / 2;
            }     
            else
            {
                countOddGreat = (int)Math.Ceiling((double)arrData.Length / 2);
                countOddLow = (int)Math.Floor((double)arrData.Length / 2);
            }
            char[] even = new char[countOddGreat];
            char[] odd = new char[countOddLow];

            for (int round = 0; round < position; round++)
            {

                for (int i = 0; i < arrData.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even[greatIndex] = arrData[i];
                        greatIndex++;
                    }

                    else
                    {
                        odd[lowIndex] = arrData[i];
                        lowIndex++;
                    }
                }
                for (int i = 0; i < even.Length; i++)
                {
                    arrData[i] = even[i];
                }
                for (int i = 0; i < odd.Length; i++)
                {
                    arrData[i + even.Length] = odd[i];
                }

                greatIndex = 0;
                lowIndex = 0;
            }

            return new string(arrData);
        }
        public static string DialMinus(int position, string data)
        {
            char[] arrData = data.ToCharArray();

            int countOddGreat = 0;
            int countOddLow = 0;

            int greatIndex = 0;
            int lowIndex = 0;

            if (arrData.Length % 2 == 0)
            {
                countOddGreat = arrData.Length / 2;
                countOddLow = arrData.Length / 2;
            }
            else
            {
                countOddGreat = (int)Math.Ceiling((double)arrData.Length / 2);
                countOddLow = (int)Math.Floor((double)arrData.Length / 2);
            }
            char[] even = new char[countOddGreat];
            char[] odd = new char[countOddLow];

            for (int round = 0; round < position; round++)
            {
                for (int i = 0; i < even.Length; i++)
                {
                    even[i] = arrData[i] ;
                }
                for (int i = 0; i < odd.Length; i++)
                {
                     odd[i] = arrData[i + even.Length];
                }

                for (int i = 0; i < arrData.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        arrData[i] = even[greatIndex];
                        greatIndex++;
                    }

                    else
                    {
                        arrData[i] = odd[lowIndex];
                        lowIndex++;
                    }
                }
                

                greatIndex = 0;
                lowIndex = 0;
            }

            return new string(arrData);
        }
    }
}
