namespace jogoRPG.src.entities
{
    public class hero
    {

        //caracteristicas
        public string Name;
        public int Level;
        public string HeroType;


        //construtor
       public hero(string Name, int Level, string HeroType)
       {
           this.Name=Name;
           this.Level=Level;
           this.HeroType=HeroType;
       }
        
        //conversao de WriteLine para string
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
          public virtual string ataque()
        {
            return this.Name + "Atacou com sua espada";
        }

    }
}