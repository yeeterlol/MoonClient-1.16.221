using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook
{
	public static class KeyCombinationExtensions
	{
		public static void OnCombination(this IKeyboardEvents source, IEnumerable<KeyValuePair<Combination, Action>> map, Action reset = null)
		{
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			Dictionary<Keys, KeyValuePair<Combination, Action>[]> watchlists = Enumerable.ToDictionary<IGrouping<Keys, KeyValuePair<Combination, Action>>, Keys, KeyValuePair<Combination, Action>[]>(Enumerable.GroupBy<KeyValuePair<Combination, Action>, Keys>(map, (Func<KeyValuePair<Combination, Action>, Keys>)((KeyValuePair<Combination, Action> k) => k.Key.TriggerKey)), (Func<IGrouping<Keys, KeyValuePair<Combination, Action>>, Keys>)((IGrouping<Keys, KeyValuePair<Combination, Action>> g) => g.get_Key()), (Func<IGrouping<Keys, KeyValuePair<Combination, Action>>, KeyValuePair<Combination, Action>[]>)((IGrouping<Keys, KeyValuePair<Combination, Action>> g) => Enumerable.ToArray<KeyValuePair<Combination, Action>>((IEnumerable<KeyValuePair<Combination, Action>>)g)));
			source.KeyDown += (KeyEventHandler)delegate(object sender, KeyEventArgs e)
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				if (!watchlists.TryGetValue(e.get_KeyCode(), out var value))
				{
					reset?.Invoke();
				}
				else
				{
					KeyboardState current = KeyboardState.GetCurrent();
					Action action = reset;
					int num = 0;
					KeyValuePair<Combination, Action>[] array = value;
					for (int i = 0; i < array.Length; i++)
					{
						KeyValuePair<Combination, Action> keyValuePair = array[i];
						if (Enumerable.All<Keys>(keyValuePair.Key.Chord, (Func<Keys, bool>)current.IsDown) && num <= keyValuePair.Key.ChordLength)
						{
							num = keyValuePair.Key.ChordLength;
							action = keyValuePair.Value;
						}
					}
					action?.Invoke();
				}
			};
		}

		public static void OnSequence(this IKeyboardEvents source, IEnumerable<KeyValuePair<Sequence, Action>> map)
		{
			KeyValuePair<Sequence, Action>[] actBySeq = Enumerable.ToArray<KeyValuePair<Sequence, Action>>(map);
			Func<Queue<Combination>, Sequence, bool> endsWith = delegate(Queue<Combination> chords, Sequence sequence)
			{
				int num = chords.get_Count() - sequence.Length;
				return num >= 0 && Enumerable.SequenceEqual<Combination>(Enumerable.Skip<Combination>((IEnumerable<Combination>)chords, num), (IEnumerable<Combination>)sequence);
			};
			int max = Enumerable.Max<Sequence>(Enumerable.Select<KeyValuePair<Sequence, Action>, Sequence>((IEnumerable<KeyValuePair<Sequence, Action>>)actBySeq, (Func<KeyValuePair<Sequence, Action>, Sequence>)((KeyValuePair<Sequence, Action> p) => p.Key)), (Func<Sequence, int>)((Sequence c) => c.Length));
			int min = Enumerable.Min<Sequence>(Enumerable.Select<KeyValuePair<Sequence, Action>, Sequence>((IEnumerable<KeyValuePair<Sequence, Action>>)actBySeq, (Func<KeyValuePair<Sequence, Action>, Sequence>)((KeyValuePair<Sequence, Action> p) => p.Key)), (Func<Sequence, int>)((Sequence c) => c.Length));
			Queue<Combination> buffer = new Queue<Combination>(max);
			IEnumerable<KeyValuePair<Combination, Action>> map2 = Enumerable.Select<Combination, KeyValuePair<Combination, Action>>(Enumerable.SelectMany<KeyValuePair<Sequence, Action>, Combination>((IEnumerable<KeyValuePair<Sequence, Action>>)actBySeq, (Func<KeyValuePair<Sequence, Action>, IEnumerable<Combination>>)((KeyValuePair<Sequence, Action> p) => p.Key)), (Func<Combination, KeyValuePair<Combination, Action>>)((Combination c) => new KeyValuePair<Combination, Action>(c, delegate
			{
				buffer.Enqueue(c);
				if (buffer.get_Count() > max)
				{
					buffer.Dequeue();
				}
				if (buffer.get_Count() >= min)
				{
					Enumerable.LastOrDefault<Action>(Enumerable.Select<KeyValuePair<Sequence, Action>, Action>((IEnumerable<KeyValuePair<Sequence, Action>>)Enumerable.OrderBy<KeyValuePair<Sequence, Action>, int>(Enumerable.Where<KeyValuePair<Sequence, Action>>((IEnumerable<KeyValuePair<Sequence, Action>>)actBySeq, (Func<KeyValuePair<Sequence, Action>, bool>)((KeyValuePair<Sequence, Action> pair) => endsWith(buffer, pair.Key))), (Func<KeyValuePair<Sequence, Action>, int>)((KeyValuePair<Sequence, Action> pair) => pair.Key.Length)), (Func<KeyValuePair<Sequence, Action>, Action>)((KeyValuePair<Sequence, Action> pair) => pair.Value)))?.Invoke();
				}
			})));
			source.OnCombination(map2, (Action)buffer.Clear);
		}
	}
}
