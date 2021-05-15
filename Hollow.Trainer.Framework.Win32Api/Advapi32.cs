using System;
using System.Runtime.InteropServices;

namespace Hollow.Trainer.Framework.Win32Api
{
	internal class Advapi32
	{
		public struct LUID
		{
			public uint LowPart;

			public int HighPart;
		}

		public struct LUID_AND_ATTRIBUTES
		{
			public LUID Luid;

			public uint Attributes;
		}

		public struct TOKEN_PRIVILEGES
		{
			public uint PrivilegeCount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
			public LUID_AND_ATTRIBUTES[] Privileges;
		}

		private const int ANYSIZE_ARRAY = 1;

		public const uint TOKEN_QUERY = 8u;

		public const uint TOKEN_ADJUST_PRIVILEGES = 32u;

		public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

		public const string SE_AUDIT_NAME = "SeAuditPrivilege";

		public const string SE_BACKUP_NAME = "SeBackupPrivilege";

		public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

		public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

		public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

		public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

		public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

		public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

		public const string SE_DEBUG_NAME = "SeDebugPrivilege";

		public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

		public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

		public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

		public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

		public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

		public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

		public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

		public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

		public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

		public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

		public const string SE_RELABEL_NAME = "SeRelabelPrivilege";

		public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

		public const string SE_RESTORE_NAME = "SeRestorePrivilege";

		public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

		public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

		public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

		public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

		public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

		public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

		public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

		public const string SE_TCB_NAME = "SeTcbPrivilege";

		public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

		public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

		public const string SE_UNDOCK_NAME = "SeUndockPrivilege";

		public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

		public const uint SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1u;

		public const uint SE_PRIVILEGE_ENABLED = 2u;

		public const uint SE_PRIVILEGE_REMOVED = 4u;

		public const uint SE_PRIVILEGE_USED_FOR_ACCESS = 2147483648u;

		private const uint FILE_SHARE_READ = 1u;

		private const uint FILE_SHARE_WRITE = 2u;

		private const uint FILE_SHARE_DELETE = 4u;

		private const uint FILE_ATTRIBUTE_READONLY = 1u;

		private const uint FILE_ATTRIBUTE_HIDDEN = 2u;

		private const uint FILE_ATTRIBUTE_SYSTEM = 4u;

		private const uint FILE_ATTRIBUTE_DIRECTORY = 16u;

		private const uint FILE_ATTRIBUTE_ARCHIVE = 32u;

		private const uint FILE_ATTRIBUTE_DEVICE = 64u;

		private const uint FILE_ATTRIBUTE_NORMAL = 128u;

		private const uint FILE_ATTRIBUTE_TEMPORARY = 256u;

		private const uint FILE_ATTRIBUTE_SPARSE_FILE = 512u;

		private const uint FILE_ATTRIBUTE_REPARSE_POINT = 1024u;

		private const uint FILE_ATTRIBUTE_COMPRESSED = 2048u;

		private const uint FILE_ATTRIBUTE_OFFLINE = 4096u;

		private const uint FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192u;

		private const uint FILE_ATTRIBUTE_ENCRYPTED = 16384u;

		private const uint GENERIC_READ = 2147483648u;

		private const uint GENERIC_WRITE = 1073741824u;

		private const uint GENERIC_EXECUTE = 536870912u;

		private const uint GENERIC_ALL = 268435456u;

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, uint BufferLengthInBytes, ref TOKEN_PRIVILEGES PreviousState, out uint ReturnLengthInBytes);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, uint Zero, IntPtr Null1, IntPtr Null2);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, out LUID lpLuid);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
	}
}
