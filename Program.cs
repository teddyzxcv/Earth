using System;
using System.Collections.Generic;
using System.IO;
namespace Earth
{
    class Program
    {
        static void Main(string[] args)
        {

            Country China = new Country()
            {
                FullName = "People's Republic of China",
                Population = 1300000000,
                AreaOfC = 9600000,
                Leader = "Xi Jinping",
                TypeOfP = "	Unitary Marxist–Leninist one-party socialist republic",
                GDP = 14900000000000
            };
            Country Russian = new Country()
            {
                FullName = "Russian Federation",
                Population = 140000000,
                AreaOfC = 17000000,
                Leader = "Vladimir Vladimirovich Putin",
                TypeOfP = "Democratical republic",
                GDP = 1700000000000
            };
            Country America = new Country()
            {
                FullName = "United State of America",
                Population = 320000000,
                AreaOfC = 9000000,
                Leader = "Biden or Trump?",
                TypeOfP = "Democratical republic",
                GDP = 21000000000000
            };
            Russian.WriteAllInfoInC("1.txt");



        }


    }


    class Country
    {
        public string FullName { get; set; }
        public int Population { get; set; }
        public int AreaOfC { get; set; }
        public string Leader { get; set; }
        public string TypeOfP { get; set; }

        public long GDP { get; set; }
    }

    class Region : Country
    {
        public string Form { get; set; }
    }
    static class WriteInfo
    {
        public static void WriteAllInfoInC(this Country Info, string path)
        {
            FileInfo finf = new FileInfo(path);
            FileStream fs = finf.Create();
            fs.Close();
            File.WriteAllText(path, $"Name of country:{Info.FullName} \nPopulation: {Info.Population} \nArea:{Info.AreaOfC} \nType of administration: {Info.TypeOfP} \nGPD: {Info.GDP}");
        }
    }

    static class CalcInfo
    {
        public static void CalAllInfo<T>(this Country Info)
        {
            Console.WriteLine($"{Info.FullName}: ");
        }

    }

}
