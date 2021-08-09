using System;
using System.Collections.Generic;

namespace Lab5_1_RPG
{
    class GameCharacter
    {
        public string Name;
        public int Strength;
        public int Intelligence;

        public GameCharacter()
        {
            Name = "";
            Strength = 0;
            Intelligence = 0;
        }
        public GameCharacter(string _Name, int _Strength, int _Intelligence)
        {
            Name = _Name;
            Strength = _Strength;
            Intelligence = _Intelligence;
        }
        public virtual void Play()
        {
            Console.WriteLine($"\nName: {this.Name}" +
                $"\nStrength: {this.Strength}" +
                $"\nIntelligence: {this.Intelligence}");
        }
    }
    class Warrior : GameCharacter
    {
        public string WeaponType;
        public Warrior()
        {
            this.Name = "";
            this.Strength = 0;
            this.Intelligence = 0;
            this.WeaponType = "";
        }
        public Warrior(string _Name, int _Strength, int _Intelligence, string _WeaponType) : base(_Name, _Strength, _Intelligence)
        {
            this.Name = _Name;
            this.Strength = _Strength;
            this.Intelligence = _Intelligence;
            this.WeaponType = _WeaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"\nName: {this.Name}" +
                $"\nStrength: {this.Strength}" +
                $"\nIntelligence: {this.Intelligence}" +
                $"\nWeapon Type: {this.WeaponType}");
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy;
        public MagicUsingCharacter()
        {
            this.Name = "";
            this.Strength = 0;
            this.Intelligence = 0;
            this.MagicalEnergy = 0;
        }
        public MagicUsingCharacter(string _Name, int _Strength, int _Intelligence, int _MagicalEnergy) : base(_Name, _Strength, _Intelligence)
        {
            this.Name = _Name;
            this.Strength = _Strength;
            this.Intelligence = _Intelligence;
            this.MagicalEnergy = _MagicalEnergy;
        }
        public override void Play()
        {
            Console.WriteLine($"\nName: {this.Name}" +
                $"\nStrength: {this.Strength}" +
                $"\nIntelligence: {this.Intelligence}" +
                $"\nMagical Energy: {this.MagicalEnergy}");
        }
    }
    class Wizard: MagicUsingCharacter
    {
        public int SpellNumber;
        public Wizard()
        {
            this.Name = "";
            this.Strength = 0;
            this.Intelligence = 0;
            this.MagicalEnergy = 0;
            this.SpellNumber = 0;
        }
        public Wizard(string _Name, int _Strength, int _Intelligence, int _MagicalEnergy, int _Spellnumber) : base(_Name, _Strength, _Intelligence, _MagicalEnergy)
        {
            this.Name = _Name;
            this.Strength = _Strength;
            this.Intelligence = _Intelligence;
            this.MagicalEnergy = _MagicalEnergy;
            this.SpellNumber = _Spellnumber;
        }
        public override void Play()
        {
            Console.WriteLine($"\nName: {this.Name}" +
                $"\nStrength: {this.Strength}" +
                $"\nIntelligence: {this.Intelligence}" +
                $"\nMagical Energy: {this.MagicalEnergy}" +
                $"\nSpell Number: {this.SpellNumber}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            Warrior w1 = new Warrior("Mario", 8, 6, "Red Plunger");
            Warrior w2 = new Warrior("Luigi", 6, 8, "Green Plunger");
            Wizard z1 = new Wizard("Harry Potter", 5, 8, 10, 1);
            Wizard z2 = new Wizard("Gandolf", 2, 10, 9, 42);
            Wizard z3 = new Wizard("Voldemort", 0, 9, 0, 8);

            gameCharacters.Add(w1);
            gameCharacters.Add(w2);
            gameCharacters.Add(z1);
            gameCharacters.Add(z2);
            gameCharacters.Add(z3);

            foreach (GameCharacter character in gameCharacters) character.Play();
        }
    }
}
