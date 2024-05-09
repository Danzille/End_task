// See https://aka.ms/new-console-template for more information
int AckermannFunction(int m, int n) 
    { 
        if (m == 0) 
            return n + 1; 
        else if (n == 0) 
            return AckermannFunction(m - 1, 1); 
        else 
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
    } 
System.Console.WriteLine(AckermannFunction(3,5));