Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c, d, e, f As Double
        Console.Write("Enter the value of A: ")
        a = Console.ReadLine
        Console.Write("Enter the value of B: ")
        b = Console.ReadLine
        Console.WriteLine()
        c = a + b
        d = a - b
        e = a * b
        f = a / b
        Console.WriteLine("The Sum of the Value A and B is : {2}", a, b, c, d, e, f)
        Console.WriteLine()
        Console.WriteLine("The Difference of the Value A and B is : {3}", a, b, c, d, e, f)
        Console.WriteLine()
        Console.WriteLine("The Product of the Value A and B is : {4}", a, b, c, d, e, f)
        Console.WriteLine()
        Console.WriteLine("The Qoutient of the Value A and B is : {5}", a, b, c, d, e, f)
        Console.WriteLine()
        Console.ReadLine()


    End Sub

End Module
