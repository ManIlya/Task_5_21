namespace Task_5_21
{
    class BassGuitar : Guitar
    {
        public bool HasFretlessNeck { get; set; }

        public override string ChangeStrings()
        {
            return "Настройка струн на басс гитаре " + Name;
        }

        public override string AdjustAction()
        {
            return "Регулировка басс гитары " + Name;
        }

        public string Slap()
        {
            return "Cлеппинг на басс гитаре" + Name;
        }

        public string PlayHarmonics()
        {
            return "Игра гармоник на басс гитаре" + Name;
        }
    }
}