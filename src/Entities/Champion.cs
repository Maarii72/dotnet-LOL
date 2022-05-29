namespace dotnet_LOL.srs.Entities
{
    public abstract class Champion
    {
        public Champion(string Name, int Level, string Classe){
            //this = esse //ta olhando para ele mesmo, para não se confundir com outro name de outra classe
            this.Name = Name;
            this.Level= Level;
            this.Classe = Classe;
        }
        public string Name;
        public int Level;
        public string Classe;


        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Classe;
        }

        //método para atacar
        //virtual:permite que qualquer um alterar o comportamento
        public virtual string Attack(){
            return this.Name + " Atacou";
        }

        
    }
}