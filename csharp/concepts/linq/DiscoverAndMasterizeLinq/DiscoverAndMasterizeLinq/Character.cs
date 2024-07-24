namespace DiscoverAndMasterizeLinq
{
	internal class Character
	{
		#region Properties
		public int Id { get; set; }
		public int Size { get; set; }
		public int Strength { get; set; }

		public required string Surname { get; set; }
		#endregion
	}
}
