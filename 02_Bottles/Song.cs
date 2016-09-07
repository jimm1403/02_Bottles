using System;

namespace _02_Bottles
{
    internal class Song
    {
        string _zero = " No more bottles of beer on the wall.";
        string _one = "1 bottle of beer on the wall."
                    + " 1 bottle of beer."
                    + " Take one down and pass it around."
                    + " No more bottles of beer on the wall.";
        string _two = "2 bottles of beer on the wall."
                    + " 2 bottles of beer."
                    + " Take one down and pass it around."
                    + " 1 bottle of beer on the wall."
                    + " 1 bottle of beer on the wall."
                    + " 1 bottle of beer."
                    + " Take one down and pass it around."
                    + " No more bottles of beer on the wall."; 
        string _three = "3 bottles of beer on the wall."
                    + " 3 bottles of beer."
                    + " Take one down and pass it around."
                    + " 2 bottles of beer on the wall."
                    + " 2 bottles of beer on the wall."
                    + " 2 bottles of beer."
                    + " Take one down and pass it around."
                    + " 1 bottle of beer on the wall."
                    + " 1 bottle of beer on the wall."
                    + " 1 bottle of beer."
                    + " Take one down and pass it around."
                    + " No more bottles of beer on the wall.";

        internal object CountBottles(int bottles)
        {
            string line = "";
            
            for (int _bottles = 3; _bottles > 0 ; _bottles--)
            {
                if (bottles == 3)
                    line = _three;
                else if (bottles == 2)
                    line = _two;
                else if (bottles == 1)
                    line = _one;
                else
                {
                    line = _zero;
                }
            }
                return line;
        }
    }
}