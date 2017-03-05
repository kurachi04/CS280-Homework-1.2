using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();

            pokemon1.Poke_Number = 201;
            pokemon1.Poke_Name = "Unknown";
            pokemon1.Poke_Height = 1.08f;
            pokemon1.Poke_Weight = 11.0f;
            pokemon1.Poke_Category = "Symbol";
            pokemon1.Poke_Abilities = "Levitate";
            pokemon1.Poke_Gender = "Unknown";

            Console.WriteLine("我最喜歡的寶可夢\r\n編號:{0}\r\n名稱:{1}\r\n身高:{2}公分\r\n體重:{3}公斤\r\n種類:{4}\r\n技能:{5}\r\n性別:{6}", pokemon1.Poke_Number, pokemon1.Poke_Name, pokemon1.Poke_Height, pokemon1.Poke_Weight, pokemon1.Poke_Category, pokemon1.Poke_Abilities, pokemon1.Poke_Gender);
        }
    }
}