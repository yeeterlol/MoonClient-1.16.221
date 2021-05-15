using System;
using System.Collections.Generic;
using System.Linq;

namespace Gma.System.MouseKeyHook
{
	public class Sequence : SequenceBase<Combination>
	{
		private Sequence(Combination[] combinations)
			: base(combinations)
		{
		}

		public static Sequence Of(params Combination[] combinations)
		{
			return new Sequence(combinations);
		}

		public static Sequence FromString(string text)
		{
			string[] array = text.Split(new char[1]
			{
				','
			});
			Combination[] combinations = Enumerable.ToArray<Combination>(Enumerable.Select<string, Combination>((IEnumerable<string>)array, (Func<string, Combination>)Combination.FromString));
			return new Sequence(combinations);
		}
	}
}
