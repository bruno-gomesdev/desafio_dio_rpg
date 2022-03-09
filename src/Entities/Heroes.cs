using System;

namespace src.Entities
{
    public class Heroes
    {

        public Heroes(string name, string heroesType, int level, string hitPoints, string magicPoints)
        {
            this.name = name;
            this.heroesType = heroesType;
            this.level = level;
            this.hitPoints = hitPoints;
            this.magicPoints = magicPoints;
        }
        public string name { get; set; }
        public string heroesType {get; set; }
        public int level {get; set; }
        public string hitPoints { get; set; }
        public string magicPoints { get; set; }


        public virtual string Attack()
        {
            return this.name + "fez um ataque simples";
        }

     public virtual string Attack(int bonus)
        {
            return this.name + $" fez um super ataque e somou {bonus} de Bônus";
        }

        public void Presentation ()
        {
            Console.WriteLine($"----------------------------");
            Console.WriteLine("Conheça o seu Herói!");
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"Nome:{name}");
            Console.WriteLine($"Tipo de herói: {heroesType}");
            Console.WriteLine($"Nível: {level}");
            Console.WriteLine($"Pontos de vida: {hitPoints}");
            Console.WriteLine($"Pontos de magia: {magicPoints}");
            Console.WriteLine($"---------------------------- \n");
                        
        }
        
     
    }
}