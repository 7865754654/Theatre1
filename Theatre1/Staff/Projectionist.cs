namespace TheatresSystem.Staff 
{
    public class Projectionist 
    {
         public string Name {get; set;}
         public Projectionist  (string name)
         {
            Name = name;
         }
         public string GetRole()
         {
            return $"Киномеханик: {Name}";
         }
         
    }
}
 