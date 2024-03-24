using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Hiển thị hình chữ nhật");
            Console.WriteLine("2. Hiển thị tam giác vuông (Góc vuông ở 4 góc: trên bên trái, trên bên phải, dưới bên trái, dưới bên phải)");
            Console.WriteLine("3. Hiển thị tam giác cân");
            Console.WriteLine("4. Thoát");
            Console.WriteLine("Vui lòng nhập lựa chọn của bạn:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintRectangle();
                    break;
                case "2":
                    PrintSquareTriangles();
                    break;
                case "3":
                    PrintIsoscelesTriangle();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    static void PrintRectangle()
    {
        Console.WriteLine("Hình chữ nhật:");
        Console.WriteLine("********");
        Console.WriteLine("*      *");
        Console.WriteLine("*      *");
        Console.WriteLine("********");
    }

    static void PrintSquareTriangles()
    {
        Console.WriteLine("Tam giác vuông:");
        Console.WriteLine("Góc vuông ở trên bên trái:");
        Console.WriteLine("*");
        Console.WriteLine("**");
        Console.WriteLine("***");

        Console.WriteLine("Góc vuông ở trên bên phải:");
        Console.WriteLine("  *");
        Console.WriteLine(" **");
        Console.WriteLine("***");

        Console.WriteLine("Góc vuông ở dưới bên trái:");
        Console.WriteLine("***");
        Console.WriteLine("**");
        Console.WriteLine("*");

        Console.WriteLine("Góc vuông ở dưới bên phải:");
        Console.WriteLine("***");
        Console.WriteLine(" **");
        Console.WriteLine("  *");
    }

    static void PrintIsoscelesTriangle()
    {
        Console.WriteLine("Tam giác cân:");
        Console.WriteLine("    *");
        Console.WriteLine("   ***");
        Console.WriteLine("  *****");
        Console.WriteLine(" *******");
    }
}