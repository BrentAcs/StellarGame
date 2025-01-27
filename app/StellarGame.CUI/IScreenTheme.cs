public interface IScreenTheme
{
   int DisplayWidth { get; }
   int DisplayHeight { get; }
   
   char UpperRight { get; }
}

public abstract class ScreenTheme : IScreenTheme
{
   public abstract int DisplayWidth { get; }
   public abstract int DisplayHeight { get; }
   public abstract char UpperRight { get; }
}

public class StandardScreenTheme : ScreenTheme
{
   public override int DisplayWidth => Console.WindowWidth;
   public override int DisplayHeight => Console.WindowHeight;
   public override char UpperRight => '\u250F';
}

public class StandardMacOsScreenTheme : ScreenTheme
{
   public override int DisplayWidth => 80;
   public override int DisplayHeight => 25;
   public override char UpperRight => '+';
}
