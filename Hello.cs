using System;

namespace HelloWorld
{
  class Hello
  {
         static void Main (string[] args)
    {
      Console.WriteLine("Hello World!");  

      // Sum of numbers
      Console.WriteLine("Enter number of variales");
      int n= int.Parse(Console.ReadLine());
     
      int sum=1;
        for(int num =1;num < n; num+=2 ) {
           if(num%7 ==0)
           {
            continue;
           
           }            
            sum+=num;
        Console.WriteLine("+" + num);
      }  
      Console.WriteLine("Sum of "+ n +  "numbers is " +sum);

      //// Prime number program
     
       Console.WriteLine("======Prime number program=====");
      Console.WriteLine("Enter the starting number");
      int n01=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the range of prime numbers");
      int no2 = int.Parse(Console.ReadLine());
        for(int i=n01; i<no2; i++)
        {
          int divider =2;
          bool prime =true;
          int maxDivider =(int)Math.Sqrt(i);
              while(divider <=maxDivider){
                    
                  if(i%divider ==0 ){
                    prime =false;
                    break;
                  } divider++;
              }
                  if (prime){
                    Console.WriteLine(" " + i);
                  }
        }

        ////Pattern 
        // Console.WriteLine("#################Number Patterns########################");
        // for(int a=0; a<=3;a++){
        //   for(int b=0; b <=3; b++){
        //     for(int c=0; c<=3; c++){
        //       for(int d=0; d<=3; d++){
        //         // if ((a+b)== (c+d)){
        //         //   Console.WriteLine(a +" "+ b+ " "+c+" "+d);
        //         // }
        //          if ((a*b)== (c*d)){
        //           Console.WriteLine(a +" "+ b+ " "+c+" "+d);
        //         }
        //       }
        //     }
        //   }
        // }



      ////Pattern 
        Console.WriteLine("#################Lottery Game 6/49########################");
        // for(int i1=1; i1<=44;i1++){
        //   for(int i2=i1+1; i2 <=45; i2++){
        //     for(int i3=i2+1; i3<=46; i3++){
        //         for(int i4=i3+1; i4<=47; i4++){
        //           for(int i5=i4+1; i5<=48;i5++){
        //             for(int i6=i5+1; i6<=49; i6++){

        //             Console.WriteLine(i1+" "+ i2+ " "+i3+" "+i4 +" "+i5+ " "+i6);
        //             }
        //           }
                  
                    
        // //      }
        //       }
        //     }
        //   }

     //Write a program that prints on the console the numbers from 1 to N.
      //The number N should be read from the standard input.
       Console.WriteLine("Enter range of the number to print");
       int Num = int.Parse(Console.ReadLine());
       for(int i=1; i<=Num; i++){
        Console.WriteLine(i);
       }

       ///Write a program that prints on the console the numbers from 1 to N,
      ///which are not divisible by 3 and 7 simultaneously. The number N
       //should be read from the standard input.

       Console.WriteLine("Enter a number");
       int y = int.Parse(Console.ReadLine());
       for(int w=1; w<=y; w++){
        if(w % 3 != 0 && w % 7 != 0)
        {
           Console.Write("{0} ", w);
        }
       }Console.ReadKey();

       ////Write a program that reads from the console a series of integers and
      //  prints the smallest and largest of them.
      // Console.Write("Enter the range of numbers");
      // int number = int.Parse(Console.ReadLine());
      // for(int r=1; r<=number; r++){
      //   for(int e=1; e<=r;e++){
      //    int temp=1;

      //   }
           
      // } 







 int[] a = new int[30]; // Array Declaration in C#  
Console.Write("Enter the Number of values to find Smallest and Largest Number: ");  
int number = Convert.ToInt16(Console.ReadLine()); // read the string value and convert it in to integer  
float large, small;
//Reading the values one by one  
for (int z = 1; z <= number; z++)  
{  
Console.Write("Enter the No " + z + ":");  
a[z] = Convert.ToInt16(Console.ReadLine());  
}  
 large = a[0];
            small = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > large)
                    large = a[i];
                else if (a[i] < small)
                    small = a[i];
            }
            Console.WriteLine("Largest element in the array is {0}", large);
            Console.WriteLine("Smallest element in the array is {0}", small);
        }
//Display the Smallest value  7
//Console.WriteLine("The smallest Value is "+a[1]);  
//Display the Biggest Value  
//Console.WriteLine("The Largest Value is " + a[number]);  
//Waiting for output  
//Console.ReadKey();  


  
    }

    }
 
