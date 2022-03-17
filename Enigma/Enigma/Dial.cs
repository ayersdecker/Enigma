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
        public static string CypherEncrypt(string data)
        {

            char[] two = new char[0];
            char[] three = new char[0];
            char[] four = new char[0];
            char[] five = new char[0];
            char[] six = new char[0];
            char[] seven = new char[0];
            char[] eight = new char[0];
            char[] nine = new char[0]; 

            char[] chars = data.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                //if (i % 1 == 0) { Array.Resize<char>(ref one, one.Length + 1); one[one.Length - 1] = chars[i]; }
                if (i % 2 == 0) { Array.Resize<char>(ref two, two.Length + 1); two[two.Length - 1] = chars[i]; }
                if (i % 3 == 0) { Array.Resize<char>(ref three, three.Length + 1); three[three.Length - 1] = chars[i]; }
                if (i % 4 == 0) { Array.Resize<char>(ref four, four.Length + 1); four[four.Length - 1] = chars[i]; }
                if (i % 5 == 0) { Array.Resize<char>(ref five, five.Length + 1); five[five.Length - 1] = chars[i]; }
                if (i % 6 == 0) { Array.Resize<char>(ref six, six.Length + 1); six[six.Length - 1] = chars[i]; }
                if (i % 7 == 0) { Array.Resize<char>(ref seven, seven.Length + 1); seven[seven.Length - 1] = chars[i]; }
                if (i % 8 == 0) { Array.Resize<char>(ref eight, eight.Length + 1); eight[eight.Length - 1] = chars[i]; }
                if (i % 9 == 0) { Array.Resize<char>(ref nine, nine.Length + 1); nine[nine.Length - 1] = chars[i]; }
            }

            //string won = new string(one);
            string too = new string(two);
            string tre = new string(three);
            string fur = new string(four);
            string fiv = new string(five);
            string sits = new string(six);
            string sevan = new string(seven);
            string ehhht = new string(eight);
            string nein = new string(nine);
            return too + tre + fur + fiv + sits + sevan + ehhht + nein;
        
        }
       // public static string CypherDecrypt(int key, string data)
        //{

        //}
    }
}
