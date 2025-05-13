namespace TheatresSystem.Staff 
{
    public class Puppeteer 
    {
         public string Name {get; set;}
         public Puppeteer (string name)
         {
            Name = name;
         }
         public string GetRole()
         {
            return $"Кукловод: {Name}";
         }
         
    }
}
 