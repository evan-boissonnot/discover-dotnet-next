#region Travail sur les classes
using DiscoverAndMasterizeLinq;

List<Character> persons = new() {
	new() { Surname = "Grand pas", Id = 1, Size = 185, Strength = 250 },
	new() { Surname = "Sam", Id = 2, Size = 100, Strength = 150 },
	new() { Surname = "Frodo", Id = 3, Size = 102, Strength = 100 },
};

var queryPersons = from item in persons
				   where item.Size > 100
				   select item;
//select item.Strength;

//var results = queryPersons.Sum();
var results = queryPersons.Sum(item => item.Strength);

Console.WriteLine("Force cumulée : {0}", results);

var queryPersonsBis = from item in persons
					  let isBig = item.Size > 100
					  where item.Size > 100
					  select new { Surname = item.Surname, Strength = item.Strength, IsBig = isBig };
foreach (var item in queryPersonsBis)
{
	Console.WriteLine($"{item.Surname} => {item.Strength} / {item.IsBig}");
}

//foreach (var item in queryPersons)
//{
//	Console.WriteLine($"Perso : {item.Surname}");
//}
#endregion

Console.WriteLine("-----------------SIMPLES STRINGS------------------------");

#region Travail sur les chaines
List<string> ensembleParent = new() { "sam", "frodo", "grand pas" };

for (int i = 0; i < ensembleParent.Count; i++)
{
	Console.WriteLine(ensembleParent[i]);
}

foreach (string sdaCharacter in ensembleParent)
{
	Console.WriteLine(sdaCharacter);
}

Console.WriteLine("-----------------DIFFERE WITH EXTENSION------------------------");
foreach (var item in ensembleParent
					.Where(item => item.Length > 3)
					.Select(x => x.Substring(0, 1).ToUpper() + x.Substring(1))
					.OrderByDescending(item => item))
{
	Console.WriteLine(item);
}

Console.WriteLine("-----------------DIFFERE ------------------------");

var request = from character in ensembleParent
			  where character.Length > 3
			  orderby character descending
			  select character[0].ToString().ToUpper() + character.Substring(1);

foreach (string character in request)
{
	Console.WriteLine(character);
}

//ensembleParent.Add("Gandalf");

//foreach (string character in request)
//{
//	Console.WriteLine(character);
//}

//Console.WriteLine("============ IMMEDIAT ===========");

//var resultRequest = request.ToList();
//foreach (string character in resultRequest)
//{
//	Console.WriteLine(character);
//}

//ensembleParent.Add("Legolas");

//foreach (string character in resultRequest)
//{
//	Console.WriteLine(character);
//}
#endregion
