// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть номер завдання: ");
        int n = int.Parse(Console.ReadLine()!);
        switch (n)
        {
            case 1:
                Task_1.Task_1 myTask_1 = new Task_1.Task_1();
                myTask_1.main1();
                break;
            case 2:
                Task_2.Task_2 myTask_2 = new Task_2.Task_2();
                myTask_2.main2();
                break;
            case 3:
                Task_3.Task_3 myTask_3 = new Task_3.Task_3();
                myTask_3.main3();
                break;
                // Четрверте завдання: 3 програми = 3 файли: 4 5 6
            case 4:
                Task_4.Task_4 myTask_4 = new Task_4.Task_4();
                myTask_4.main4_1();
                break;
            case 5:
                Task_5.Task_5 myTask_5 = new Task_5.Task_5();
                myTask_5.main4_2();
                break;
            case 6:
                Task_6.Task_6 myTask_6 = new Task_6.Task_6();
                myTask_6.main4_3();
                break;
            default:
                break;
        }
        Main();
    }
}
