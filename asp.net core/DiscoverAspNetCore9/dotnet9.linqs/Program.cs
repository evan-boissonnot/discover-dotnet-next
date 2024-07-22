


using dotnet9.linqs;

List<Jedi> jedis = new() { new Jedi("Vador", new("Sabre laser", power: 15)), new Jedi("Leia", new("Taser")), new Jedi("Luke 2", new("Sabre laser")), new Jedi("Jar jar", new("PistoLaser", power: 20)) };

var list = jedis.CountBy(item => item.Weapon.Label);
foreach (var item in list)
{
    Console.WriteLine("{0} {1}", item.Key, item.Value);
}

Console.WriteLine("-".PadLeft(10, '='));

var result = jedis.AggregateBy(keySelector: item => item.Weapon.Label, seed: 0, (result, jedi) => result + jedi.Weapon.Power);
foreach (var item in result)
{
    Console.WriteLine("{0} {1}", item.Key, item.Value);
}


Console.WriteLine("-".PadLeft(10, '='));
var resultIndexs = jedis.Index();
foreach (var item in resultIndexs)
{
    Console.WriteLine("{0} {1}", item.Index, item.Item.Surname);
}