﻿namespace TreeDataGridDemo.Models
{
    internal class Country
    {
        public string? Name { get; set; }
        public string Region { get; private set; }
        public int Population { get; private set; }
        //Square Miles
        public int Area { get; private set; }
        //Per Square Mile
        public double PopulationDensity { get; private set; }
        //Coast / Area
        public double CoastLine { get; private set; }
        public double? NetMigration { get; private set; }
        //per 1000 births
        public double? InfantMortality { get; private set; }
        public int GDP { get; private set; }
        public double? LiteracyPercent { get; private set; }
        //per 1000
        public double? Phones { get; private set; }
        public double? BirthRate { get; private set; }
        public double? DeathRate { get; private set; }

        public Country(string name, string region, int population, int area, double density, double coast, double? migration,
                       double? infantMorality, int gdp, double? literacy, double? phones, double? birth, double? death)
        {
            Name = name;
            Region = region;
            Population = population;
            Area = area;
            PopulationDensity = density;
            CoastLine = coast;
            NetMigration = migration;
            InfantMortality = infantMorality;
            GDP = gdp;
            LiteracyPercent = literacy;
            BirthRate = birth;
            DeathRate = death;
        }
        public Country()
        {
            Name = "";
            Region = "region";
            Population = 0;
            Area = 0;
            PopulationDensity = 0;
            CoastLine = 0;
            NetMigration = 0;
            InfantMortality = 0;
            GDP = 0;
            LiteracyPercent = 0;
            BirthRate = 0;
            DeathRate = 0;
        }
    }
}
