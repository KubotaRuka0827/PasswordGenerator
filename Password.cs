using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Random r = new Random();
char[] chararrayA = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

int length = 1;
int num = 0;

Console.WriteLine("パスワード自動生成ツール");
Console.WriteLine("ーーーーーーーーーーーー");

Select();

void Select()
{
    Console.WriteLine("１．パスワード生成");
    Console.WriteLine("２．終了");
    Console.WriteLine("選択してください");
    int a = int.Parse(Console.ReadLine());
    if (a == 1) Settings(); ;
}

void Settings()
{
    Console.WriteLine("パスワードの長さは？");
    length = int.Parse(Console.ReadLine());
    Generate();
}

void Generate()
{
    
    string password = "";
    for (int i = 0; i < length; i++)
    {
        num = r.Next(chararrayA.Length);
        password += chararrayA[num];
    }
    Console.WriteLine(password);
    Select();
}