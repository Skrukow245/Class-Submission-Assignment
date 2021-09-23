using System;



class Math
{
    public void Divide(int input1, out int result)
    {
        result = input1 / 2;
    }
    public int Add(int a, int b)
    {
        return a + b;                                     
    }      
    public int Add(int a, int b, int c)         //overloading
    {
        return a + b + c;
    }
}

