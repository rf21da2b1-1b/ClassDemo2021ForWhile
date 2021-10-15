using System;
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
            ///*
            // * For Loop
            // */
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //for (int j = 15; j > 0; j--)
            //{
            //    Console.Write(j + " ");
            //}
            //Console.WriteLine();



            ///*
            // * While Loop
            // */
            //bool fortsæt = true;
            //while (fortsæt)
            //{
            //    String str = Console.ReadLine();
            //    Console.WriteLine(str);

            //    if (str.ToLower() == "stop")
            //    {
            //        fortsæt = false;
            //    }
            //}






            ///*
            // * Foreach Loop
            // */
            //List<Person> personer = new List<Person>();
            //personer.Add(new Person(12, "peter", "12345678"));
            //personer.Add(new Person(13, "jakob", "87654321"));
            //personer.Add(new Person(14, "charlotte", "11223344"));
            //personer.Add(new Person(15, "anders", "55667788"));
            //personer.Add(new Person(16, "henrik", "99001122"));
            //personer.Add(new Person(17, "vibeke", "33445566"));
            //personer.Add(new Person(18, "mohammed", "99887766"));
            //personer.Add(new Person(19, "jens peter", "55443322"));
            //personer.Add(new Person(1, "morten", "88664422"));
            //personer.Add(new Person(2, "nilma", "11335577"));
            //personer.Add(new Person(3, "michael", "22446688"));
            //personer.Add(new Person(4, "steen", "12213443"));
            //personer.Add(new Person(5, "martin", "77227488"));
            //personer.Add(new Person(6, "poul", "25398765"));

            //Console.WriteLine("Alle undervisere");
            //foreach (Person p in personer)
            //{
            //    Console.WriteLine(p);
            //}

            ///*
            // * kun undervisere med m
            // */
            //Console.WriteLine("Kun dem der starter med m");
            //foreach (Person p in personer)
            //{
            //    if (p.Navn.ToLower().StartsWith("m"))
            //    {
            //        Console.WriteLine(p);
            //    }
            //}

            //Console.WriteLine("Med telefon 11223344");
            //foreach (Person p in personer)
            //{
            //    if (p.Tlf == "11223344")
            //    {
            //        Console.WriteLine(p);
            //    }
            //}


            ///*
            // * Dictionary
            // */
            //Dictionary<string, Person> personer2 = new Dictionary<string, Person>();
            

            //personer2.Add("12345678", new Person(12, "peter", "12345678"));
            //personer2.Add("87654321", new Person(13, "jakob", "87654321"));
            //personer2.Add("11223344", new Person(14, "charlotte", "11223344"));
            //personer2.Add("12123344",new Person(15, "anders", "12123344"));
            //personer2.Add("99001122", new Person(16, "henrik", "99001122"));
            //personer2.Add("33445566", new Person(17, "vibeke", "33445566"));
            //personer2.Add("99887766", new Person(18, "mohammed", "99887766"));
            //personer2.Add("55443322", new Person(19, "jens peter", "55443322"));
            //personer2.Add("88664422", new Person(1, "morten", "88664422"));
            //personer2.Add("11335577", new Person(2, "nilma", "11335577"));
            //personer2.Add("22446688", new Person(3, "michael", "22446688"));
            //personer2.Add("12213443", new Person(4, "steen", "12213443"));
            //personer2.Add("77227488", new Person(5, "martin", "77227488"));
            //personer2.Add("25398765", new Person(6, "poul", "25398765"));


            //// alle
            //Console.WriteLine("dic alle");
            //foreach (Person p in personer2.Values)
            //{
            //    Console.WriteLine(p);
            //}

            //Console.WriteLine("dic tlf");
            //Console.WriteLine(personer2["11223344"]);


            //Console.WriteLine("Dic, Kun dem der starter med m");
            //foreach (Person p in personer2.Values)
            //{
            //    if (p.Navn.StartsWith("m"))
            //    {
            //        Console.WriteLine(p);
            //    }  
            //}



            /*
             * Array
             */
            // erklæring
            Person[] personer3;

            // opretter
            personer3 = new Person[30];

            // indsætter værdi
            int nextId = 0;

            if (nextId > personer3.Length)
            {
                Console.WriteLine("Array er fyldt");
            }
            else
            {
                personer3[nextId++] = new Person(2, "nilma", "11335577");
            }

            //Console.WriteLine(personer3[30]);

            //foreach (Person p3 in personer3)
            //{
            //    Console.WriteLine(p3);
            //}
            for (int i = 0; i < nextId; i++)
            {
                Console.WriteLine(personer3[i]);
            }

            // initialisere et array
            for (int i = 0; i < personer3.Length; i++)
            {
                personer3[i] = new Person();
            }

        }
    }
}