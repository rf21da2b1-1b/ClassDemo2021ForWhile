﻿using System;
using System.Collections.Generic;

namespace ClassDemo2021ForWhile
{
    internal class InsertCodeHere
    {
        public InsertCodeHere()
        {
        }

        public void MyCode()
        {
            /*
             * For Loop
             */
            for (int i = 0; i < 20; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int j = 15; j > 0; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();



            /*
             * While Loop
             */
            bool fortsæt = true;
            while (fortsæt)
            {
                String str = Console.ReadLine();
                Console.WriteLine(str);

                if (str.ToLower() == "stop")
                {
                    fortsæt = false;
                }
            }






            /*
             * Foreach Loop
             */
            List<Person> personer = new List<Person>();
            personer.Add(new Person(12, "peter", "12345678"));
            personer.Add(new Person(13, "jakob", "87654321"));
            personer.Add(new Person(14, "charlotte", "11223344"));
            personer.Add(new Person(15, "anders", "55667788"));
            personer.Add(new Person(16, "henrik", "99001122"));
            personer.Add(new Person(17, "vibeke", "33445566"));
            personer.Add(new Person(18, "mohammed", "99887766"));
            personer.Add(new Person(19, "jens peter", "55443322"));
            personer.Add(new Person(1, "morten", "88664422"));
            personer.Add(new Person(2, "nilma", "11335577"));
            personer.Add(new Person(3, "michael", "22446688"));
            personer.Add(new Person(4, "steen", "12213443"));
            personer.Add(new Person(5, "martin", "77227488"));
            personer.Add(new Person(6, "poul", "25398765"));

            Console.WriteLine("Alle undervisere");
            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }

            /*
             * kun undervisere med m
             */
            Console.WriteLine("Kun dem der starter med m");
            foreach (Person p in personer)
            {
                if (p.Navn.ToLower().StartsWith("m"))
                {
                    Console.WriteLine(p);
                }
            }
            




        }
    }
}