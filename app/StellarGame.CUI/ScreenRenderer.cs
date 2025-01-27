public class ScreenRenderer
{
   public IScreenTheme CurrentTheme { get; init; } = new StandardScreenTheme();

   public ScreenRenderer()
   {
      // Set above
      // if (OperatingSystem.IsWindows)
      // {
      //    CurrentTheme = new StandardScreenTheme();
      // }

      if (OperatingSystem.IsMacOs)
      {
         CurrentTheme = new StandardMacOsScreenTheme();
      }
   }
   
   public void Clear() => Console.Clear();

   public void Render(bool clear=true)
   {
      if(clear)
         Clear();
      
      Console.SetCursorPosition(0,0);
      Console.Write(CurrentTheme.UpperRight);
   }
}
