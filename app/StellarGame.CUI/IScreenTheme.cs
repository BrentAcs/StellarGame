public interface IScreenTheme
{
   char UpperRight { get; }
}

public abstract class ScreenTheme : IScreenTheme
{
   public abstract char UpperRight { get; }
}

public class StandardScreenTheme : ScreenTheme
{
   public override char UpperRight => '\u250F';
}
