﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // PowerUp p = new PowerUp();

            // p.name = "Fungi";
            // p.x = 4;
            // p.y = 3;

            XmlSerializer serializer = new XmlSerializer(typeof(PowerUp));

            FileStream myFile = File.Open("powerup.xml", FileMode.OpenOrCreate);

            // serializer.Serialize(myFile, p);

            PowerUp p = (PowerUp) serializer.Deserialize(myFile);

            myFile.Close();

            Console.WriteLine(p.name);

            Console.ReadLine();

            

            // 3 56 90



            Console.WriteLine("Hello World!");
        }
    }
}
