using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            int first = 0;
            bool exit = false;
            int second = 0;
            string op;
            Console.WriteLine("____�����������____");
            while (!exit)
            {
                while (true)
                {
                    Console.Write("������� ������ ����� (��� ������ '�����'): ");
                    string input = Console.ReadLine();
                    if (input == "�����" || input == "�����")
                    {
                        exit = true;
                        break;
                    }
                    if (int.TryParse(input, out first))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n������������ ��������.");
                    }
                } // ���� ������� �����
                if (exit)
                {
                    break;
                }
                while (true)
                {
                    Console.Write("\n������� ������ �����: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out second))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n������������ ��������.");
                    }

                } // ���� �������� �����

                while (true)
                {

                    Console.Write("\n�������� �������� (+, -, *, /): ");
                    op = Console.ReadLine();
                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n������������ ��������.");
                    }
                }

                switch (op)using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            int first = 0;
            bool exit = false;
            int second = 0;
            string op;
            Console.WriteLine("____�����������____");
            while (!exit)
            {
                while (true)
                {
                    Console.Write("������� ������ ����� (��� ������ '�����'): ");
                    string input = Console.ReadLine();
                    if (input == "�����" || input == "�����") {
                        exit = true;
                        break; }
                    if (int.TryParse(input, out first))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n������������ ��������.");
                    }
                } // ���� ������� �����
                if (exit)
                {
                    break;
                }
                while (true)
                {
                    Console.Write("\n������� ������ �����: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out second))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n������������ ��������.");
                    }

                } // ���� �������� �����

                while (true)
                {

                    Console.Write("\n�������� �������� (+, -, *, /): ");
                    op = Console.ReadLine();
                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n������������ ��������.");
                    }
                }

                switch (op)
                {

                    case "+":
                        Console.WriteLine($"\n��������� {first} + {second} ����� {first + second}\n ");
                        break;
                    case "-":
                        Console.WriteLine($"\n��������� {first} - {second} ����� {first - second}\n");
                        break;
                    case "*":
                        Console.WriteLine($"\n��������� {first} * {second} ����� {first * second}\n");
                        break;
                    case "/":
                        if (second != 0)
                        {
                            Console.WriteLine($"\n��������� {first} / {second} ����� {first / second} \n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n�� ���� ������ ������!\n");
                            break;
                        }
                }

            }
        }
    }
}
                {

                    case "+":
                        Console.WriteLine($"\n��������� {first} + {second} ����� {first + second}\n ");
                        break;
                    case "-":
                        Console.WriteLine($"\n��������� {first} - {second} ����� {first - second}\n");
                        break;
                    case "*":
                        Console.WriteLine($"\n��������� {first} * {second} ����� {first * second}\n");
                        break;
                    case "/":
                        if (second != 0)
                        {
                            Console.WriteLine($"\n��������� {first} / {second} ����� {first / second} \n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n�� ���� ������ ������!\n");
                            break;
                        }
                }

            }
        }
    }
}