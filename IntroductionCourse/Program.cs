using System;
using System.IO;
using System.Text;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("������� ������������ ����� ����� 0...255");
            string num = Console.ReadLine();

            // �������� �����
            using (FileStream fs = new FileStream("D:/Homework_GB/homework.bin", FileMode.Create))
            {
                // ����� ������ ��� �������� ������
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Default))
                {
                    // ������
                    bw.Write(num);
                }

            }
            // �������� �����
            using (FileStream fs = new FileStream("D:/Homework_GB/homework.bin", FileMode.Open))
            {
                // ����� ������ ��� ��������� ������
                using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                {
                    // ���������� 
                    string num2 = br.ReadString();

                    // ������� ����������� ������ �� ����� ��� ��������
                    Console.WriteLine("������ �� �����: {0}", num2);
                }
            }
            Console.Read();
        }    
    }
}
