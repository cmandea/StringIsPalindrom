namespace StringIsPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = CheckString();
          
            //string text2 ;
            Console.WriteLine("Sirul este:" + text1);
            int lenghtText = text1.Length - 1;
            string mirrorText = "";
            for (int i = text1.Length-1; i >=0; i--) 
            {
               
                
                mirrorText = mirrorText + text1[i];
                

            }
            Console.WriteLine("Sirul invers este:" + mirrorText);
            bool areEqualStrings=string.Equals(text1, mirrorText,StringComparison.OrdinalIgnoreCase);
            if (areEqualStrings)
            {
                Console.WriteLine($"Sirul {text1} este un palindrom!");
            }
            else 
            {
                Console.WriteLine($"Sirul {text1} NU este un palindrom!");
            }
        }


        static string CheckString() //verific daca stringul este null ----
        {
            Console.Write("Please enter a string:");
            string strText = Console.ReadLine();
            bool isValidString = string.IsNullOrWhiteSpace(strText);
            while (isValidString)
            {
                if (string.IsNullOrWhiteSpace(strText))
                {
                    Console.WriteLine("Please enter a string not null:");
                    strText = Console.ReadLine();
                    isValidString = string.IsNullOrWhiteSpace(strText);

                }
                else
                {
                    isValidString = string.IsNullOrWhiteSpace(strText);

                }
                
            }
            return strText;

        }
    }
}