namespace TheatreSystem
{
    public abstract class Theatre
    {
        public int NumberOfSeats { get; set; }
        public int NumberOfRows { get; set; }
        public bool HasOrchestraPit { get; set; }
        public double StageLength { get; set; }
        public double StageWidth { get; set; }

        public virtual string GetInfo()  
        {
            return $"Театр: Мест - {NumberOfSeats}, Рядов - {NumberOfRows}, Сцена: {StageLength}x{StageWidth}, Оркестровая яма: {HasOrchestraPit}";
        }
    }
}