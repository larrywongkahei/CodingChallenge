public class CodingChallenge
{
    public static int[][] groupArrayElements(int[] arrayOfNumbers, int number)
    {
        //Create a list that would be used to convert to array and return
        List<int[]> listToReturn = new List<int[]>();

        //Create a variable that show how many int inside one array
        int eachArrayCount = Decimal.ToInt32(Math.Ceiling((decimal)arrayOfNumbers.Count() / number));

        //A variable that used to count loop
        int countLoop = 0;

        //Create a loop to loop the input number of time(create array and add into the list)
        for(var i = 0; i < number; i++)
        {
            //Initialize an array with the number of in needed in the array
            //If arrayOfNumbers.Count() - countLoop > eachArrayCount means that its now the final pary of the array, then initialize with equally devided number
            //If arrayOfNumbers.Count() - countLoop is smaller than eachArrayCount, then initialize it with the number or remainder
            int[] arrayToAdd = arrayOfNumbers.Count() - countLoop > eachArrayCount ? new int[eachArrayCount] : new int[arrayOfNumbers.Count() - countLoop];

            //This loop is for adding in into the arrayToAdd array, it loops the eachArrayCount length of time as required
            for (var x = 0; x < eachArrayCount; x++)
            {
                //Created a if statement for the final part of the array because the final part required to have length equal to remainder
                if (countLoop != arrayOfNumbers.Count())
                {
                    arrayToAdd[x] = arrayOfNumbers[countLoop];
                    countLoop++;
                }
                else
                {
                    break;
                }
            }
            listToReturn.Add(arrayToAdd);
        }
        return listToReturn.ToArray();
    }

    public static string printNumbersOfArraysInArray(int[][] array)
    {
        string stringToReturn = "[";
        for(var i = 0; i < array.Count(); i++)
        {
            stringToReturn += "[";
            for(var x = 0; x < array[i].Count(); x++)
            {
                if (x + 1< array[i].Count())
                {
                    stringToReturn += $"{array[i][x]}, ";
                }
                else
                {
                    stringToReturn += $"{array[i][x]}]";
                }
            }
            if (i + 1 != array.Count())
            {
                stringToReturn += ", ";
            }
        }
        stringToReturn += "]";
        return stringToReturn;
    }

    public static void Main(string[] args)
    {
        //test1
        //int[] arrayToTest = new int[] { 1, 2, 3, 4, 5 };
        //int[][] newArray = groupArrayElements(arrayToTest, 3);
        //Console.WriteLine(printNumbersOfArraysInArray(newArray));
        //test2
        int[] arrayToTest = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int[][] newArray = groupArrayElements(arrayToTest, 3);
        Console.WriteLine(printNumbersOfArraysInArray(newArray));
    }
}