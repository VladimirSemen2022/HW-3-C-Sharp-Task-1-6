using System;


namespace HW_3_C_Sharp_Task_1_6
{
    class NewText
    {
        public string text { set; get; }
        private char[] chars;

        public NewText()
        {
            this.text = String.Empty;
            this.chars = new char[1];
        }

        public NewText(string text)
        {
            this.text = text;
            this.chars = text.ToCharArray();
        }

        public void GetSquare(char symbol, int size)
        {
            if (size < 80)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{symbol} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public bool CheckPalindrom ()
        {
            char[] tmpChar = (char[])this.chars.Clone();
            Array.Reverse(tmpChar);
            string tmpString = new String (tmpChar);
            return this.text.Equals(tmpString);
        }

        public int[] ExceptionFromArray(int [] intArray1, int[] intArray2)
        {
            int[] tmp = new int[intArray1.Length];
            int iter = 0;
            bool check = false;
            for (int i = 0; i < intArray1.Length; i++)
            {
                for (int j = 0; j < intArray2.Length; j++)
                {
                    if (intArray1[i].Equals(intArray2[j]))
                        check = true;
                }
                if (!check)
                {
                    tmp[iter] = intArray1[i];
                    iter++;
                }
                else
                    check = false;
            }
            Array.Resize(ref tmp, iter);
            return tmp;
        }
    }
}
