using System;
class Class2
{
    //static void Main(string[] args)
    void Main(string[] args)
    {
        SealedClass sealedCls = new SealedClass();
        int total = sealedCls.Add(4, 5);
        Console.WriteLine("Total = " + total.ToString());
        Console.ReadLine();
    }
}
// Sealed class  
sealed class SealedClass
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}

//class derivedSealedClass : SealedClass
//{

//}