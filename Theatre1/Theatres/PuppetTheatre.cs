using TheatresSystem.Staff;
using TheatresSystem.Theatre;

namespace TheatreSystem.Theatres
{
    public class PuppetTheatre : Theatre
    {
        public Puppeteer Puppeteer { get; set; }

        public PuppetTheatre(int seats, int rows, bool hasPit, double length, double width, Puppeteer puppeteer)
        {
            NumberOfSeats = seats;
            NumberOfRows = rows;
            HasOrchestraPit = hasPit;
            StageLength = length;
            StageWidth = width;
            Puppeteer = puppeteer;
        }

        public override string GetInfo()
        {
            return $"Кукольный театр:\nМест: {NumberOfSeats}, Рядов: {NumberOfRows}, Оркестровая яма: {HasOrchestraPit}, Размер сцены: {StageLength}x{StageWidth}\n{Puppeteer.GetRole()}";
        }
    }
}