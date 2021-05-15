using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Gma.System.MouseKeyHook
{
	public abstract class SequenceBase<T> : IEnumerable<T>, IEnumerable
	{
		private readonly T[] _elements;

		public int Length => _elements.Length;

		protected SequenceBase(params T[] elements)
		{
			_elements = elements;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return Enumerable.Cast<T>((IEnumerable)_elements).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			return string.Join(",", _elements);
		}

		protected bool Equals(SequenceBase<T> other)
		{
			if (_elements.Length != other._elements.Length)
			{
				return false;
			}
			return Enumerable.SequenceEqual<T>((IEnumerable<T>)_elements, (IEnumerable<T>)other._elements);
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
			return (_elements.Length + 13) ^ (((_elements.Length != 0) ? (_elements[0].GetHashCode() ^ _elements[_elements.Length - 1].GetHashCode()) : 0) * 397);
		}
	}
}
