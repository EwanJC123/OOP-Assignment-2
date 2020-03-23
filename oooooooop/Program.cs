using System;
using System.IO;

namespace oooooooop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter filename 1 with .txt");
            string userFileName1 = Console.ReadLine();
            Console.WriteLine("Please enter filename 2 with .txt");
            string userFileName2 = Console.ReadLine();
            bool filesAreSame = diff(userFileName1,userFileName2);
            if (filesAreSame == true)
            {
                Console.WriteLine("{0} and {1} are the same",userFileName1,userFileName2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} and {1} are not the same", userFileName1, userFileName2);
                Console.ReadLine();
            }
            
         
        }

        static bool diff(string fileName1,string fileName2)
        {
            
            string[] file1 = File.ReadAllLines(fileName1);
            string[] file2 = File.ReadAllLines(fileName2);

            if (file1.Length != file2.Length)
            {
                return false;
            }
            
            
            for(int i = 0 ; i<file2.Length; i++)
            {
                if (file1[i] != file2[i])
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
      

        }
        
    }
}
