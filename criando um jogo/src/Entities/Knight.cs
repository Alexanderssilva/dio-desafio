namespace criando_um_jogo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int MaxHp, int CurrentHp, int MaxMp, int CurrentMp) : base(Name, Level, HeroType, MaxHp, CurrentHp, MaxMp, CurrentMp)
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
            return this.Name + " Atacou com sua espada";
        }

        public string Attack(int bonus)
        {
           if(bonus > 6 ){
            return this.Name + " Atacou com sua espada  com bonus de +" + bonus;

           }else{
            return this.Name + "Atacou com seu escudo com bonus de +" + bonus;
           }
        }
    }
}