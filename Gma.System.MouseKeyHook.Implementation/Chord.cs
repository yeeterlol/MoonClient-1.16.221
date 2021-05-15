using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gma.System.MouseKeyHook.Implementation
{
	internal class Chord : IEnumerable<Keys>, IEnumerable
	{
		private readonly Keys[] _keys;

		public int Count => _keys.Length;

		internal Chord(IEnumerable<Keys> additionalKeys)
		{
			_keys = Enumerable.ToArray<Keys>((IEnumerable<Keys>)Enumerable.OrderBy<Keys, Keys>(Enumerable.Select<Keys, Keys>(additionalKeys, (Func<Keys, Keys>)((Keys k) => k.Normalize())), (Func<Keys, Keys>)((Keys k) => k)));
		}

		public IEnumerator<Keys> GetEnumerator()
		{
			return Enumerable.Cast<Keys>((IEnumerable)_keys).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			return string.Join("+", _keys);
		}

		public static Chord FromString(string chord)
		{
			IEnumerable<Keys> enumerable = Enumerable.Cast<Keys>((IEnumerable)Enumerable.Select<string, object>((IEnumerable<string>)chord.Split(new char[1]
			{
				'+'
			}), (Func<string, object>)((string p) => Enum.Parse(typeof(Keys), p))));
			Stack<Keys> additionalKeys = new Stack<Keys>(enumerable);
			return new Chord((IEnumerable<Keys>)additionalKeys);
		}

		protected bool Equals(Chord other)
		{
			if (_keys.Length != other._keys.Length)
			{
				return false;
			}
			return Enumerable.SequenceEqual<Keys>((IEnumerable<Keys>)_keys, (IEnumerable<Keys>)other._keys);
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
			return Equals((Chord)obj);
		}

		public override int GetHashCode()
		{
			return (_keys.Length + 13) ^ (int)(((_keys.Length != 0) ? ((uint)_keys[0] ^ (uint)_keys[_keys.Length - 1]) : 0) * 397);
		}
	}
}
