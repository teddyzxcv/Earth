using System;
using System.Collections.Generic;
using System.IO;
namespace Earth
{
    class Program
    {
        static void Main(string[] args)
        {
            Region Checnya = new Region();
            Checnya["Nationalitites"] = "russians and chechenians";
            Checnya["Relief"] = "Mountains";
            Country China = new Country()
            {
                FullName = "People's Republic of China",
                Population = 1300000000,
                AreaOfC = 9600000,
                Leader = "Xi Jinping",
                TypeOfP = "Unitary Marxist–Leninist one-party socialist republic",
                GDP = 14900000000000,
                Cities = new List<string>() { "Beijing", "Wuhan", "Hongkong", "Taiwan" }
            };
            Country Russian = new Country()
            {
                FullName = "Russian Federation",
                Population = 140000000,
                AreaOfC = 17000000,
                Leader = "Vladimir Vladimirovich Putin",
                TypeOfP = "Democratical republic",
                GDP = 1700000000000,
                Cities = new List<string>() { "Moscow", "Sante-Peterburg", "Ekaterinburg" }
            };
            Country America = new Country()
            {
                FullName = "United State of America",
                Population = 320000000,
                AreaOfC = 9000000,
                Leader = "Biden or Trump?",
                TypeOfP = "Democratical republic",
                GDP = 21000000000000,
                Cities = new List<string>() { "New York", "Chicago", "Los Angeles" }
            };
            Russian.WriteAllInfoInCountry("1.txt");
            China.WriteAllInfoInCountry("2.txt");



        }


    }



    class Region : Country
    {
        string Nationalitites = "";
        string Relief = "";
        public string this[string propname]
        {


            get
            {
                switch (propname)
                {
                    case "Nationalitites": return "Nationalitites:" + Nationalitites;
                    case "Relief": return Relief;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "Nationalitites":
                        Nationalitites = value;
                        break;
                    case "Relief":
                        Relief = value;
                        break;
                }
            }
        }

    }
    static class WriteInfo
    {
        public static void WriteAllInfoInCountry(this Country Info, string path)
        {

            FileInfo finf = new FileInfo(path);
            FileStream fs = finf.Create();
            fs.Close();
            File.WriteAllText(path, $"Name of country:{Info.FullName} \nPopulation: {Info.Population} \nArea:{Info.AreaOfC} \nType of administration: {Info.TypeOfP} \nGPD: {Info.GDP}");
            File.AppendAllText(path, "\n" + String.Join(',', Info.Cities));
        }

    }

    static class CalcInfo
    {


    }

}
