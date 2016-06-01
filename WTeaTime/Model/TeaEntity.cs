namespace WTeaTime.Model
{
    public partial class TeaEntity
    {
        public string Title { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
        public string Message { get; set; }
        public string Action { get; set; }
        public bool Beep { get; set; }
        public bool ShowMex { get; set; }
        public bool RunAction { get; set; }
    }
}
