using System.Runtime.InteropServices;

public static class OperatingSystem
{
   public static bool IsWindows => IsPlatformWindows();
   public static bool IsMacOs => IsPlatformMacOs();
   
   public static bool IsPlatformWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
   public static bool IsPlatformMacOs() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
}
