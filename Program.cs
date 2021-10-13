using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 12, 45, 67, 879, 89 };
            Console.WriteLine("\n");
            foreach(int item in data)
            {
                Console.Write(item + " ");
            }

            //-----------------------------------------------------------------

            // int[] arr = new int[10]; 
            // int i;  
            // Console.Write("\n\nRead and Print elements of an array:\n");
            // Console.Write("-----------------------------------------\n");	
        
            // Console.Write("Input 10 elements in the array :\n");  
            // for(i=0; i<10; i++)  
            // {  
            //     Console.Write("element - {0} : ",i);
            //     arr[i] = Convert.ToInt32(Console.ReadLine());  		
            // }  
        
            // Console.Write("\nElements in array are: ");  
            // for(i=0; i<10; i++)  
            // {  
            //     Console.Write("{0}  ", arr[i]);  
            // } 
            // Console.Write("\n");	

            //-----------------------------------------------------------------
            int[] array = new int[] { 50, 100, 150, 200, 250, 300, 350, 400 };
            Console.WriteLine("\n");
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine("\n");

            //------------------------------------------------------------------

            // Convert string to char array  
            string sentence = "Mahesh Chand";  
            char[] charArr = sentence.ToCharArray();  
            foreach (char ch in charArr)  
            {  
        
                Console.WriteLine(ch);  
            }   
        
            // Convert char array to string  
            char[] chars = new char[10];  
            chars[0] = 'M';  
            chars[1] = 'a';  
            chars[2] = 'h';  
            chars[3] = 'e';  
            chars[4] = 's';  
            chars[5] = 'h';  
            string charsStr = new string(chars);  
            string charsStr2 = new string(new char[] {'T','h','i','s',' ','i','s',' ','a',' ','s','t','r','i','n','g'});  
            Console.WriteLine("Chars to string: {0}", charsStr);  
            Console.WriteLine("Chars to string: {0}", charsStr2); 

            //----------------------------------------------------------------------

            string str = "116|2|312|4|25"; 
            int pipe = str.IndexOf("|");           
            
            //string new = str.Substring(0, str.IndexOf("|"));
            System.Console.WriteLine("\n" + str.Substring(0, str.IndexOf("|")) + "\n");

            List<int> list = new List<int>();   

            //------------------------------------------------------------------------

            // ToList();
            // given integer array 
            // { 10, 20, 30, 40, 50 }
            
            // using List<T> class
            //List<int> lst = new List<int> { 10, 20, 30, 40, 50 };
            
            // you can write the above line of code as
            int[] ints = new [] { 10, 20, 30, 40, 50 };
            List<int> lst = ints.OfType<int>().ToList();
            
            // printing output
            foreach (int i in lst)
            {
                Console.Write(i + " ");
            }
            
            System.Console.WriteLine("\n");

        //----------------------------------------------------------------------------- 
            // ToArray();
            // Step 1: create list.
            List<string> listNew = new List<string>();
            listNew.Add("one");
            listNew.Add("two");
            listNew.Add("three");
            listNew.Add("four");
            listNew.Add("five");
            
            // Step 2: convert to string array.
            string[] arrayNew = listNew.ToArray();
            Test(arrayNew);
    
    
            static void Test(string[] array)
            {
                Console.WriteLine("Array received: " + array.Length);
            }

            //-------------------------------------------------------------------------------------

            string fruit = "Apple,Banana,Orange,Strawberry";
            string[] split = fruit.Split(',');
            foreach (string item in split)
            {
                System.Console.Write(item + " ");
            } 








            
        }
    }
}
