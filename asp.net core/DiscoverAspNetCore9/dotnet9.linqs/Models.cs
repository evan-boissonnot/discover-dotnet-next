namespace dotnet9.linqs
{
    internal class Weapon(string label, int power = 10)
    {
        public string Label { get; set; } = label;

        public int Power { get; set; } = power;
    }

    internal class Jedi(string surname, Weapon weapon)
    {
        public string Surname { get; set; } = surname;

        public Weapon Weapon { get; set; } = weapon;
    }
}
