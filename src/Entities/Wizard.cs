namespace src.Entities
{
    public class Wizard : Heroes
    {
        public Wizard(string name, string heroesType, int level, string hitPoints, string magicPoints) : base(name, heroesType, level, hitPoints, magicPoints)
        {
            this.name = name;
            this.heroesType = heroesType;
            this.level = level;
            this.hitPoints = hitPoints;
            this.magicPoints = magicPoints;
        }

        public override string Attack()
        {
            return this.name + " lançou uma magia!\n";
        }   

    }
}