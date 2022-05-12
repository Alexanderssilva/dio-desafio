namespace criando_um_jogo.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name,int Level,string HeroType,int MaxHp,int CurrentHp, int MaxMp, int CurrentMp)
        {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;
          this.MaxHp = MaxHp;
          this.CurrentHp = CurrentHp;
          this.MaxMp = MaxMp;
          this.CurrentMp = CurrentMp;
        }
        public string Name; 
        public int Level; 
        public string HeroType;
        public int MaxHp;
        public int CurrentHp;
        public int MaxMp;
        public int CurrentMp;

        public override string ToString()
        {
            return this.Name +" " + this.Level +" " + this.HeroType;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}