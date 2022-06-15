﻿using System;

namespace Module_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в СПб", department?.Company?.Name ?? "Неизвестно");
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }

        static Department GetCurrentDepartment()
        {
            return null;
        }

    }
}
