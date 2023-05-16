namespace Task_5_21
{
    abstract class Guitar : IMusicalInstrument
    {
        public string Name { get; set; }
        public int NumberOfStrings { get; set; }
        public string Material { get; set; }

        public string Play() => "Игра на гитаре " + Name;

        public string Info() => "Гитара " + Name + " с " + NumberOfStrings + " струнами и сдеданая из " + Material;

        public abstract string ChangeStrings();
        public abstract string AdjustAction();
    }
}