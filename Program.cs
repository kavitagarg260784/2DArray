// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
char[,] Array = new char[3, 4]
{ { 'a', 'b', 'c', 'd' }, 
{ 'd', 'b', 'a', 'f'}, 
{ 'c', 'd', 'h', 'i' } };

Console.WriteLine("Enter letters"); // for example bc, df
string str = Console.ReadLine();
char letter1 = str[0];
char letter2 = str[1];
bool found = false;
for (int i= 0; i<3; i++)
{

    for (int j = 0; j < 3; j++)
    {
        found = false;

        if ((Array[i ,j] == letter1) & (Array[i, (j+1)] ==letter2)) // enter into IF condition if both letters are next to each other

            {

                int z = j+1;

            
            Console.WriteLine($"position x of {letter1}  is {i}", letter1, i);
            Console.WriteLine($"position y of {letter1} is { j}",letter1,j);
            Console.WriteLine($"position x of {letter2} is {i}", letter1, i);
            Console.WriteLine($"position y of {letter2} is { z}",letter2 ,z);
               
                 found = true;  
                break;  //coming out of loop if both letters are next to each other
            }
            else  
            {
           
            continue;
            }

        
    }
    if (found == true)
    {
        break;
    }
    else
    {
        continue;
    }


}
if(found == false)
{
    Console.WriteLine("not next to each other");
}