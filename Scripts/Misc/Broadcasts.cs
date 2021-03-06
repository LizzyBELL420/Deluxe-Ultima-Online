namespace Server.Misc
{
	public class Broadcasts
	{
		public static void Initialize()
		{
			EventSink.Crashed += EventSink_Crashed;
			EventSink.Shutdown += EventSink_Shutdown;
		}

		public static void EventSink_Crashed( CrashedEventArgs e )
		{
			try
			{
			    World.Broadcast(0x35, true, "Deluxe: The server has crashed, attempting to restart automatically...");
            }
			catch
			{
			}
		}

		public static void EventSink_Shutdown( ShutdownEventArgs e )
		{
			try
			{
				World.Broadcast( 0x35, true, "Deluxe: The server has shut down, be back up shortly..." );
			}
			catch
			{
			}
		}
	}
}