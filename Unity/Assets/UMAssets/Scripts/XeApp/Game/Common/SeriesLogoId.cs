namespace XeApp.Game.Common
{
	public class SeriesLogoId
	{
		public enum Type
		{
			None = 0,
			DeltaTV = 1,
			FrontiaTV = 2,
			SevenTV = 3,
			FirstTV = 4,
			FrontiaItsuwari = 5,
			FrontiaSayonara = 6,
			SevenMovie = 7,
			SevenOVA = 8,
			FirstMovie = 9,
			PulsTV = 10,
			Other = 11,
			Num = 12,
			Illegal = 13,
		}

		private static readonly Type[] tbl = new Type[6] {
			Type.None, Type.DeltaTV, Type.FrontiaTV, Type.SevenTV, Type.FirstTV, Type.PulsTV
		}; // 0x0

		// RVA: 0x1392164 Offset: 0x1392164 VA: 0x1392164
		public static Type ConvertFromAttr(SeriesAttr.Type logo)
		{
			return tbl[(int)logo];
		}
	}
}
