using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main ( string[] args )
        {
            List<drink> drinks = new List<drink>();

            //drink drink1 = new drink() { Name = "紅茶", size = "大杯"price = 50 };
            //drinks.Add( drink1 );
            drinks.Add(new drink() { Name = "紅茶", Size = "大杯", Price = 50 });
            drinks.Add(new drink() { Name = "紅茶", Size = "小杯", Price = 30 });
            drinks.Add(new drink() { Name = "綠茶", Size = "大杯", Price = 50 });
            drinks.Add(new drink() { Name = "綠茶", Size = "小杯", Price = 30 });
            drinks.Add(new drink() { Name = "咖啡", Size = "大杯", Price = 60 });
            drinks.Add(new drink() { Name = "咖啡", Size = "小杯", Price = 40 });

            for(int i = 0;  i < drinks.Count; i++) 
            {
                Console.WriteLine($"{drinks[i].Name} {drinks[i].Size} {drinks[i].Price}");
            }
        }
    }
}