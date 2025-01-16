using HeaderFooter.Interfaces;

namespace HeaderFooter;

public class Footer : IFooter
{

    public void DisplayFooter(char footerChar, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Yellow)
    {
        if (length <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Length must be greater than zero.");
        }

        ForegroundColor = foregroundColor;

        WriteLine($"\n{new string(footerChar, length)}\n");

        ResetColor();
    }

}