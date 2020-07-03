using System;

namespace Caesar_cypher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter message to be encoded");
            string encodingMessage=Console.ReadLine();
            Console.WriteLine("Enter key");
            int counter=0;
            string output = "";
            int key = Convert.ToInt32(Console.ReadLine());
            char[]alphabetArray={'a','b','c','d','e',
                'f','g','h','i','j','k','l','m','n','o','p',
                'q','r','s','t','u','v','w','x','y','z'};
            char[]charArr=encodingMessage.ToCharArray();
            int k = 0;
            int newChar = 0;
            char[] encodedArray = charArr;
            for (int i = 0; counter < encodingMessage.Length;i++)
            {
               
                if (charArr[k] == alphabetArray[i])
                {
                    newChar = (i + key)%26;
                    encodedArray[k] = alphabetArray[newChar];
                    k++;
                    counter = counter + 1;
                    i = -1;
                }
            }
            for(int s=0; s < encodedArray.Length; s++)
            {
                output = output + encodedArray[s];
            }
            Console.WriteLine(output);
        }
    }
}
