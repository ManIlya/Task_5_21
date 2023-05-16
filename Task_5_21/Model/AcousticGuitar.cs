namespace Task_5_21
{
    class AcousticGuitar : Guitar
    {
        public string BodyShape { get; set; }
        public bool HasPickup { get; set; }

        public override string ChangeStrings()
        {
            return "Настройка струн на акустической гитаре " + Name;
        }

        public override string AdjustAction()
        {
            return "Регулировка акустической  гитары " + Name;
        }

        public string Strum()
        {
            return "Струминг на акустической гитаре" + Name;
        }

        public string Fingerpick()
        {
            return "Фингерпик на акустической гитаре" + Name;
        }
    }
}