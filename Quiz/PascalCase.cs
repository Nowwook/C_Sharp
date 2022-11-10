using System;

namespace PascalCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 첫 단어를 대문자로 시작하는 표기법
            // 첫 단어가 숫자면 무시
            
            string text = Console.ReadLine();
            text = text.ToLower();
            string Text = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    Text = Text + Char.ToUpper(text[i]);
                }
                else if (text[i] == ' ')
                {
                    Text = Text + ' ';
                }
                else if (text[i - 1] == ' ')
                {
                    Text = Text + Char.ToUpper(text[i]);
                }
                else
                {
                    Text = Text + text[i];
                }
            }
            Console.WriteLine(Text);
        }
   }
}   
