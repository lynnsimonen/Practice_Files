using System;

namespace Practice_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; 
            int i;  
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");	
        
            Console.Write("Input 10 elements in the array :\n");  
            for(i=0; i<10; i++)  
            {  
                Console.Write("element - {0} : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());  		
            }  
        
            Console.Write("\nElements in array are: ");  
            for(i=0; i<10; i++)  
            {  
                Console.Write("{0}  ", arr[i]);  
            } 
            Console.Write("\n");	

            //------------------------------------------------

            int[] array = new int[] { 50, 100, 150, 200, 250, 300, 350, 400 };
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
