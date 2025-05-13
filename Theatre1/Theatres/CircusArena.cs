using TheatresSystem.Staff;
using TheatresSystem.Theatre;

namespace TheatreSystem.Theatres
{
    public class CircusArena : Theatre
    {
        public CircusArtist Artist { get; set; }
        public CircusArena(int seats, int rows, bool hasPit, double length, double width, CircusArtist artist)
        {
            NumberOfSeats = seats;
            NumberOfRows = rows;
            HasOrchestraPit = hasPit;
            StageLength = length;
            StageWidth = width;
            Artist = artist;
        }

        public override string GetInfo()
        {
            return $"Цирковая арена:\nМест: {NumberOfSeats}, Рядов: {NumberOfRows}, Оркестровая яма: {HasOrchestraPit}, Размер сцены: {StageLength}x{StageWidth}\n{Artist.GetRole()}";
        }
    }
}