using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int numeral = 0;
        int printedNum = 0;
        try
        {
            numeral = myList[n];
            numeral = n - 1;
        }
        catch (Exception)
        {
            numeral = myList.Count - 1;
        }
        finally
        {
            for (; printedNum <= numeral; printedNum++)
            {
                Console.WriteLine(myList[printedNum]);
            }
        }
        return (printedNum);
    }
}
