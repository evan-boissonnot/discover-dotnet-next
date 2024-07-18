List<string> ensembleParent = new() { "Sam", "Frodo", "Grand pas" };

for (int i = 0; i < ensembleParent.Count; i++)
{
	Console.WriteLine(ensembleParent[i]);
}

foreach (string sdaCharacter in ensembleParent)
{
	Console.WriteLine(sdaCharacter);
}


Console.WriteLine("-----------------DIFFERE ------------------------");

var request = from character in ensembleParent
			  where character.Length > 3
			  select character;

foreach (string character in request)
{
	Console.WriteLine(character);
}

ensembleParent.Add("Gandalf");

foreach (string character in request)
{
	Console.WriteLine(character);
}

Console.WriteLine("============ IMMEDIAT ===========");

var resultRequest = request.ToList();
foreach (string character in resultRequest)
{
	Console.WriteLine(character);
}

ensembleParent.Add("Legolas");

foreach (string character in resultRequest)
{
	Console.WriteLine(character);
}

