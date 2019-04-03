using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();

            Console.WriteLine("Please enter animal details");

            Console.WriteLine("Please enter in the animals name: ");





        }
    }
    class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int AnimalId { get; set; }

    }

    class Pigs : Animal
    {
        public int Domestic { get; set; }
        public int WildKuniKuni { get; set; }


        public Pigs(string _name, string _species, int _age, int _animalId, int _domestic, int _wildKuniKuni)
        {
            Name = _name;
            Species = _species;
            Age = _age;
            AnimalId = _animalId;
            Domestic = _domestic;
            WildKuniKuni = _wildKuniKuni;

        }

        public Pigs()
        {

        }

        public string GetPigDetails()
        {
            return "Name: " + Name + "Species: " + Species + "Age: " + Age + "Animal ID: " + AnimalId + "Domestic: " + Domestic + "Wild (Kuni Kuni): " + WildKuniKuni;
        }


    }

    class Sheep : Animal
    {
        public int Merino { get; set; }
        public int DorsetHorn { get; set; }

        public Sheep(string _name, string _species, int _age, int _animalId, int _merino, int _dorsetHorn)
        {
            Name = _name;
            Species = _species;
            Age = _age;
            AnimalId = _animalId;
            Merino = _merino;
            DorsetHorn = _dorsetHorn;

        }

        public Sheep()
        {

        }

        public string GetSheepDetails()
        {
            return "Name: " + Name + "Species: " + Species + "Age: " + Age + "Animal ID: " + AnimalId + "Merino: " + Merino + "Dorset Horn: " + DorsetHorn;
        }
    }

    class Llamas : Animal
    {
        public int Alpaca { get; set; }
        public int Guanaco { get; set; }

        public Llamas(string _name, string _species, int _age, int _animalId, int _alpaca, int _guanaco)
        {
            Name = _name;
            Species = _species;
            Age = _age;
            AnimalId = _animalId;
            Alpaca = _alpaca;
            Guanaco = _guanaco;

        }

        public Llamas()
        {

        }

        public string GetLllamaDetails()
        {
            return "Name: " + Name + "Species: " + Species + "Age: " + Age + "Animal ID: " + AnimalId + "Alpaca: " + Alpaca + "Guanaco: " + Guanaco;
        }
    }

    class Cows : Animal
    {
        public int Fresian { get; set; }
        public int Angus { get; set; }
        public int TexasLonghorn { get; set; }

        public Cows(string _name, string _species, int _age, int _animalId, int _fresian, int _angus, int _texasLonghorn)
        {
            Name = _name;
            Species = _species;
            Age = _age;
            AnimalId = _animalId;
            Fresian = _fresian;
            Angus = _angus;
            TexasLonghorn = _texasLonghorn;

        }

        public Cows()
        {

        }

        public string GetCowDetails()
        {
            return "Name: " + Name + "Species: " + Species + "Age: " + Age + "Animal ID: " + AnimalId + "Fresian: " + Fresian + "Angus: " + Angus + "Texas Longhorn: " + TexasLonghorn;
        }
    }

    class Birds : Animal
    {
        public int Ducks { get; set; }
        public int BantamChickens { get; set; }
        public int Peacocks { get; set; }

        public Birds(string _name, string _species, int _age, int _animalId, int _ducks, int _bantamChickens, int _peacocks)
        {
            Name = _name;
            Species = _species;
            Age = _age;
            AnimalId = _animalId;
            Ducks = _ducks;
            BantamChickens = _bantamChickens;
            Peacocks = _peacocks;

        }

        public Birds()
        {

        }

        public string GetBirdDetails()
        {
            return "Name: " + Name + "Species: " + Species + "Age: " + Age + "Animal ID: " + AnimalId + "Ducks: " + Ducks + "Bantam Chickens: " + BantamChickens + "Peacocks: " + Peacocks;
        }
    }
