using System;
using System.Collections.Generic;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> profetas = new List<String>();
            profetas.Add("Joseph Smith");
            profetas.Add("Russel M. Nelson");
            profetas.Add("Dalin H. Oaks");
            profetas.Add("Henry B Eiring");
            profetas.Add("Jeffrey R. Holland");
            profetas.Add("Dieter F Uchtdorf");
            profetas.Add("David A. Bednar");
            profetas.Add("Quentin L. Cook");
            profetas.Add("D. Todd Christofferson");
            profetas.Add("Neil L. Andersen");
            profetas.Add("Ronald A. Rasband");
            profetas.Add("Gary E. Stevenson");
            profetas.Add("Dale G. Renlund");
            profetas.Add("Gerrit W. Gong");
            profetas.Add("Ulisses Soares");
            profetas.Add("Patrick Kearon");

            Console.WriteLine("\n");

            Console.WriteLine("Estes são os 12 Apóstolos do Cordeiro: \n");
        
            foreach(String apostolos in profetas)
            {
                Console.WriteLine(apostolos);
                
            }
            Console.ReadKey();
        }
    }
}