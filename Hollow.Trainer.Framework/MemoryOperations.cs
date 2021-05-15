using System;
using System.Text;
using Hollow.Trainer.Framework.Win32Api;

namespace Hollow.Trainer.Framework
{
	public class MemoryOperations
	{
		private ProcessManager Process
		{
			get;
			set;
		}

		internal MemoryOperations(ProcessManager process)
		{
			Process = process;
		}

		public byte[] ReadMemory(IntPtr address, ulong length)
		{
			byte[] array = new byte[length];
			if (length > uint.MaxValue && !Process.Is64Bit)
			{
				throw new Exception("TODO: 32bit process using 64bit length");
			}
			UIntPtr lpNumberOfBytesRead;
			bool flag = Kernel32.ReadProcessMemory(Process.TargetProcessHandle, address, array, new UIntPtr(length), out lpNumberOfBytesRead);
			if (lpNumberOfBytesRead.ToUInt64() != length)
			{
				throw new Exception("TODO: Read size not same as input");
			}
			if (!flag)
			{
				throw new Exception("TODO: Error reading process memory");
			}
			return array;
		}

		public byte[] ReadMemory(IntPtr address, ulong length, params int[] offsets)
		{
			int num = offsets.Length - 1;
			if (offsets.Length != 0)
			{
				IntPtr pointer = ReadPointer(address);
				for (int i = 0; i < num; i++)
				{
					pointer = IntPtr.Add(pointer, offsets[i]);
					pointer = ReadPointer(pointer);
				}
				address = IntPtr.Add(pointer, offsets[num]);
			}
			return ReadMemory(address, length);
		}

		public byte ReadByte(IntPtr address, params int[] offsets)
		{
			byte[] array = ReadMemory(address, 1uL, offsets);
			return array[0];
		}

		public short ReadInt16(IntPtr address, params int[] offsets)
		{
			return BitConverter.ToInt16(ReadMemory(address, 2uL, offsets), 0);
		}

		public ushort ReadUInt16(IntPtr address, params int[] offsets)
		{
			return BitConverter.ToUInt16(ReadMemory(address, 2uL, offsets), 0);
		}

		public int ReadInt32(IntPtr address, params int[] offsets)
		{
			return BitConverter.ToInt32(ReadMemory(address, 4uL, offsets), 0);
		}

		public uint ReadUInt32(IntPtr address, params int[] offsets)
		{
			return BitConverter.ToUInt32(ReadMemory(address, 4uL, offsets), 0);
		}

		public float ReadFloat(IntPtr address, params int[] offsets)
		{
			return BitConverter.ToSingle(ReadMemory(address, 4uL, offsets), 0);
		}

		public double ReadDouble(IntPtr address, params int[] offsets)
		{
			return BitConverter.ToDouble(ReadMemory(address, 8uL, offsets), 0);
		}

		public IntPtr ReadPointer(IntPtr address)
		{
			int num = (Process.Is64Bit ? 8 : 4);
			byte[] value = ReadMemory(address, (ulong)num);
			if (Process.Is64Bit)
			{
				return new IntPtr(BitConverter.ToInt64(value, 0));
			}
			return new IntPtr(BitConverter.ToInt32(value, 0));
		}

		public void WriteMemory(IntPtr address, byte[] data)
		{
			if (data.LongLength > uint.MaxValue && !Process.Is64Bit)
			{
				throw new Exception("TODO: 32bit process using 64bit length");
			}
			UIntPtr lpNumberOfBytesWritten;
			bool flag = Kernel32.WriteProcessMemory(Process.TargetProcessHandle, address, data, new UIntPtr((uint)data.LongLength), out lpNumberOfBytesWritten);
			if (lpNumberOfBytesWritten.ToUInt64() != (ulong)data.LongLength)
			{
				throw new Exception("TODO: Write size not same as input size");
			}
			if (!flag)
			{
				throw new Exception("TODO: Error writing process memory");
			}
		}

		public void WriteMemory(IntPtr address, byte[] data, params int[] offsets)
		{
			int num = offsets.Length - 1;
			if (offsets.Length != 0)
			{
				IntPtr pointer = ReadPointer(address);
				for (int i = 0; i < num; i++)
				{
					pointer = IntPtr.Add(pointer, offsets[i]);
					pointer = ReadPointer(pointer);
				}
				address = IntPtr.Add(pointer, offsets[num]);
			}
			WriteMemory(address, data);
		}

		public void WriteMemory(IntPtr address, byte data, params int[] offsets)
		{
			WriteMemory(address, new byte[1]
			{
				data
			}, offsets);
		}

		public void WriteMemory(IntPtr address, short data, params int[] offsets)
		{
			WriteMemory(address, BitConverter.GetBytes(data), offsets);
		}

		public void WriteMemory(IntPtr address, ushort data, params int[] offsets)
		{
			WriteMemory(address, BitConverter.GetBytes(data), offsets);
		}

		public void WriteMemory(IntPtr address, int data, params int[] offsets)
		{
			WriteMemory(address, BitConverter.GetBytes(data), offsets);
		}

		public void WriteMemory(IntPtr address, uint data, params int[] offsets)
		{
			WriteMemory(address, BitConverter.GetBytes(data), offsets);
		}

		public void WriteMemory(IntPtr address, float data, params int[] offsets)
		{
			WriteMemory(address, BitConverter.GetBytes(data), offsets);
		}

		public void WriteMemory(IntPtr address, double data, params int[] offsets)
		{
			WriteMemory(address, BitConverter.GetBytes(data), offsets);
		}

		public IntPtr AllocateMemory(uint size)
		{
			IntPtr intPtr = Kernel32.VirtualAllocEx(Process.TargetProcessHandle, IntPtr.Zero, size, Kernel32.MemoryAllocateType.Commit | Kernel32.MemoryAllocateType.Reserve, Kernel32.PageProtection.ExecuteReadWrite);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception("TODO: Error allocating memory");
			}
			return intPtr;
		}

		public bool FreeMemory(IntPtr address)
		{
			return Kernel32.VirtualFreeEx(Process.TargetProcessHandle, address, 0, Kernel32.MemoryFreeType.Release);
		}

		public IntPtr InjectCode(IntPtr address, byte[] newBytes, byte[] orginalBytes)
		{
			if (orginalBytes.Length < 5)
			{
				throw new Exception("TODO: Please ensure orginalbytes is at least 5 bytes");
			}
			IntPtr intPtr = AllocateMemory((uint)(newBytes.Length + 5));
			int num = ((orginalBytes.Length > 5) ? (orginalBytes.Length - 5) : 0);
			int value = intPtr.ToInt32() - address.ToInt32() - 5;
			WriteMemory(address, (byte)233, new int[0]);
			address = IntPtr.Add(address, 1);
			WriteMemory(address, BitConverter.GetBytes(value));
			address = IntPtr.Add(address, 4);
			if (num > 0)
			{
				byte[] array = new byte[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = 144;
				}
				WriteMemory(address, array);
				address = IntPtr.Add(address, num);
			}
			WriteMemory(intPtr, newBytes);
			IntPtr intPtr2 = IntPtr.Add(intPtr, newBytes.Length);
			value = address.ToInt32() - intPtr2.ToInt32() - 5;
			WriteMemory(intPtr2, (byte)233, new int[0]);
			WriteMemory(IntPtr.Add(intPtr2, 1), BitConverter.GetBytes(value));
			return intPtr;
		}

		public bool RemoveCode(IntPtr orginalAddress, IntPtr codeCave, byte[] orginalBytes)
		{
			WriteMemory(orginalAddress, orginalBytes);
			return FreeMemory(codeCave);
		}

		public uint InjectThread(IntPtr fnFunction, string argument)
		{
			char[] chars = new char[1];
			int size = Encoding.Unicode.GetByteCount(argument) + Encoding.Unicode.GetByteCount(chars);
			byte[] bytes = Encoding.Unicode.GetBytes(argument);
			byte[] bytes2 = Encoding.Unicode.GetBytes(chars);
			IntPtr intPtr = AllocateMemory((uint)size);
			WriteMemory(intPtr, bytes);
			WriteMemory(intPtr + bytes.Length, bytes2);
			IntPtr intPtr2 = Kernel32.CreateRemoteThread(Process.TargetProcessHandle, IntPtr.Zero, 0u, fnFunction, intPtr, 0u, IntPtr.Zero);
			Kernel32.WaitForSingleObject(intPtr2, uint.MaxValue);
			FreeMemory(intPtr);
			uint lpExitCode = 0u;
			Kernel32.GetExitCodeThread(intPtr2, out lpExitCode);
			Kernel32.CloseHandle(intPtr2);
			return lpExitCode;
		}
	}
}
