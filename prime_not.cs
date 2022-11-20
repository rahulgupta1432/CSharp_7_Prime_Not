using System;
class HelloWorld {
  static void Main() {
      int i,m=0;
      Console.WriteLine("Enter the Integer Number:");
    int n1=Convert.ToInt32(Console.ReadLine());
    for(i=1;i<n1;i++)
    {
        if(n1%i==0)
        {
            m++;
        }
    }
    if(m==2)
    {
        Console.WriteLine("Prime Number");
    }else{
        Console.WriteLine("Not Prime Number");
    }
    
    }
} 