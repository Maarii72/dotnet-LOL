using dotnet_LOL.srs.Entities;

namespace dotnet_LOL.src.Entities
{
    public class Lutador : Character
    {
        public Lutador(string Name, int Level, string Classe) : base(Name, Level, Classe)
        {
        }

        public override string Attack(){
            return this.Name + " : Os lutadores são combatentes corpo-a-corpo com capacidades tanto defensivas quanto ofensivas.";
        }

    }
}