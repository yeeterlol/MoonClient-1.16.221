using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook
{
	public static class Hook
	{
		public static IKeyboardMouseEvents AppEvents()
		{
			return new AppEventFacade();
		}

		public static IKeyboardMouseEvents GlobalEvents()
		{
			return new GlobalEventFacade();
		}
	}
}
