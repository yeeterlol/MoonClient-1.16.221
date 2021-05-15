using System;

namespace Memory
{
	internal struct MemoryRegionResult
	{
		public UIntPtr CurrentBaseAddress
		{
			get;
			set;
		}

		public long RegionSize
		{
			get;
			set;
		}

		public UIntPtr RegionBase
		{
			get;
			set;
		}
	}
}
