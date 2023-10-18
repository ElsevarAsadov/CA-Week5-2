﻿using System;
using System.Text.RegularExpressions;

namespace IDK2
{
    internal static class Extensions
    {

        // ------- TASK1 - START -----//

        public static int MatchWordCount(this string originalStr, string matchStr, bool isGreedy = false)
        {

            bool found = false;

            int count = 0;

            string currentStack = "";

            int cursor = 0;

            char before = originalStr[0];



            if (!isGreedy)
            {
                for (int i = 0; i < originalStr.Length; i++)
                {
                    char c = originalStr[i];

                    if (cursor == matchStr.Length - 1)
                    {
                        found = true;
                        cursor = 0;






                        if (i != originalStr.Length - 1) currentStack = "";
                        else currentStack += c;

                        if (i + 1 < originalStr.Length && originalStr[i + 1] == ' ')
                        {
                            if(i+2 < originalStr.Length - 2 && Char.IsLetter(originalStr[i+2])) count++;
                        }



                        else
                        {
                            currentStack = "";
                            if (i + 2 < originalStr.Length - 2 && Char.IsLetter(originalStr[i + 2]))  count++;
                            cursor = 0;
                        }


                    }


                    else if (c == matchStr[cursor] && (c == before || (cursor != 0 && currentStack.ToCharArray().Contains(currentStack[cursor - 1])) || before == ' '))
                    {
                        currentStack += matchStr[cursor];
                        cursor++;
                    }




                    else
                    {
                        currentStack = "";
                        cursor = 0;
                    }

                    before = c;
                }

                if (currentStack == matchStr)
                {
                    count++;
                }

            }

            else
            {
                for (int i = 0; i < originalStr.Length; i++)
                {
                    char c = originalStr[i];

                    if (cursor == matchStr.Length - 1)
                    {
                        found = true;
                        currentStack = "";
                        count++;
                        cursor = 0;
                    }

                    else if (c == matchStr[cursor])
                    {
                        
                        currentStack += c;
                        cursor++;
                    }
                    else
                    {
                        currentStack = "";
                        cursor = 0;
                    }
                }
            }

            return found ? count : -1;
        }



        // ++++++++ TASK1 - END ++++++//




        // ------- TASK2 - START -----//

        public static bool IsPolindrom(this int integer)
        {
            char[] carr = integer.ToString().ToCharArray();

            for (int i = carr.Length - 1; i > -1; i--)
            {
                if (carr[i] != carr[carr.Length - i - 1])
                {

                    return false;

                };
            }


            return true;

        }


        // ++++++++ TASK2 - END ++++++//





        // ------- TASK3 - START -----//

        public static bool HasAnyDigit(this string str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }


            return false;

        }

        // ++++++++ TASK3 - END ++++++//
    }
}