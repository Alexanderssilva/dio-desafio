namespace criando_um_jogo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int MaxHp, int CurrentHp, int MaxMp, int CurrentMp) : base(Name, Level, HeroType, MaxHp, CurrentHp, MaxMp, CurrentMp)
        {   
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MaxHp = MaxHp;
            this.CurrentHp = CurrentHp;
            this.MaxMp = MaxMp;
            this.CurrentMp = CurrentMp;
        }
        public override string Attack()
        {
            return this.Name + " lançou uma Shuriken";
        }

        public string Attack(int bonus)
        {
           if(bonus > 6 ){
            return this.Name + " lançou um ninjutsu com bonus de +" + bonus;

           }else{
            return this.Name + " lançou Shuriken com bonus de +" + bonus;
           }
        }
    }
}