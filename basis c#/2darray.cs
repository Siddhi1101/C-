//2d array
using System;  
public class 2darray  
{  
    public static void Main() 
{
    int i,j,sum=0;
  	int[,] arr1 = new int[3,3];
       Console.Write("Input elements in the matrix :\n");
  for(i=0;i<3;i++)
  {
      for(j=0;j<3;j++)
      {
	      Console.Write("element - [{0},{1}] : ",i,j);
		  arr1[i,j] = Convert.ToInt32(Console.ReadLine()); 
      }
  }  
 
 Console.Write("\nThe matrix is : \n");
  for(i=0;i<3;i++)
  {
      
      for(j=0;j<3;j++){
           Console.Write("{0}\t",arr1[i,j]);}
     }
   Console.Write("\n\n");
   }
   
}
