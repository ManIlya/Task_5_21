namespace Task_5_21
{
    class ElectricGuitar : Guitar
    {
        public int NumberOfPickups { get; set; }
        public bool HasWhammyBar { get; set; }

        public override string ChangeStrings() => "Настройка струн на электро гитаре " + Name;

        public override string AdjustAction() => "Регулировка электро гитары " + Name;

        public string AddEffects(string effect) => "Добавлен эфект " + effect + "на электро гитаре " + Name;

        public string TogglePickup(int pickupNumber, bool isActive) => (isActive ? "Включен" : "Выключен") + " звукосниматель #" + pickupNumber + " на элекстрогиаре " + Name;
    }
}