public class ScreenRenderer
{
   public IScreenTheme CurrentTheme { get; set; } = new StandardScreenTheme();

   public void Clear() => Console.Clear();

   public void Render(bool clear=true)
   {
      if(clear)
         Clear();
      
      Console.SetCursorPosition(0,0);
      Console.Write(CurrentTheme.UpperRight);
   }
}
