namespace jogoRPG.src.entities
{
    public class Wizard : hero
    {
        public Wizard(string Name, int Level, string HeroType)
       {
           this.Name=Name;
           this.Level=Level;
           this.HeroType=HeroType;
       }

       public override string ataque()
        {
            return this.Name + "Atacou com magia";
        }

        public string ataque(int bonus)
        {
            if (bonus >6){
                return this.Name+ "lancou uma magia super efetiva com bonus de " + bonus;
            }else{
                return this.Name +"lancou uma magia com forca fraca com bonue de "+ bonus;
            }
        }
        
    }
}