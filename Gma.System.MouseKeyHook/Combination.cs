using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook
{
	public class Combination
	{
		private readonly Chord _chord;

		public Keys TriggerKey
		{
			get;
		}

		public IEnumerable<Keys> Chord => _chord;

		public int ChordLength => _chord.Count;

		private Combination(Keys triggerKey, IEnumerable<Keys> chordKeys)
			: this(triggerKey, new Chord(chordKeys))
		{
		}//IL_0001: Unknown result type (might be due to invalid IL or missing references)


		private Combination(Keys triggerKey, Chord chord)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			TriggerKey = triggerKey.Normalize();
			_chord = chord;
		}

		public static Combination TriggeredBy(Keys key)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return new Combination(key, (IEnumerable<Keys>)new Chord(Enumerable.Empty<Keys>()));
		}

		public Combination With(Keys key)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			return new Combination(TriggerKey, Enumerable.Concat<Keys>(Chord, Enumerable.Repeat<Keys>(key, 1)));
		}

		public Combination Control()
		{
			return With((Keys)131072);
		}

		public Combination Alt()
		{
			return With((Keys)262144);
		}

		public Combination Shift()
		{
			return With((Keys)65536);
		}

		public override string ToString()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			return string.Join("+", Enumerable.Concat<Keys>(Chord, Enumerable.Repeat<Keys>(TriggerKey, 1)));
		}

		public static Combination FromString(string trigger)
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			IEnumerable<Keys> enumerable = Enumerable.Cast<Keys>((IEnumerable)Enumerable.Select<string, object>((IEnumerable<string>)trigger.Split(new char[1]
			{
				'+'
			}), (Func<string, object>)((string p) => Enum.Parse(typeof(Keys), p))));
			Stack<Keys> val = new Stack<Keys>(enumerable);
			Keys triggerKey = val.Pop();
			return new Combination(triggerKey, (IEnumerable<Keys>)val);
		}

		protected bool Equals(Combination other)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return TriggerKey == other.TriggerKey && Chord.Equals(other.Chord);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (obj.GetType() != GetType())
			{
				return false;
			}
			return Equals((Combination)obj);
		}

		public override int GetHashCode()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
			return Chord.GetHashCode() ^ TriggerKey;
		}
	}
}
