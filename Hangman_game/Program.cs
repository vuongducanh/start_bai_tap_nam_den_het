using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Hangman_game
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                string value = "vinhphuc";
                char[] array = value.ToCharArray();
                int len = array.Length;
                string len2 = "";
                for (int i = 0; i < len; i++)
                {
                   len2+="_";
                }
                char[] len3 = len2.ToCharArray(); 
                 Console.WriteLine(" you welcome");
                int count=0;
                while(true)
                {       
                    Console.Write(" nhap vao ki tu input = ");
                    char input = Convert.ToChar(Console.ReadLine());
                    for(int j=0;j<len;j++)
                    {
                        if(input == array[j])
                        {
                            len3[j] = array[j];
                        } 
                    }
                     Console.WriteLine(len3);
                    count++;
                    
                    var result = array.Except(len3);
                    if(result.Count()==0)
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                    if(count == 7)
                    {
                        Console.WriteLine("game over");
                        break;
                    }
                }
            }
            catch (System.FormatException)
            {
            System.Console.WriteLine("ki tu ban nhap khong hop le ");
            }
        }
    }
}