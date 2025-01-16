using HeaderFooter.Interfaces;

namespace HeaderFooter;

public class Header : IHeader
{

    public void DisplayHeader(char headerChar, string title, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Yellow)
    {
        if (length <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Length must be greater than zero.");
        }

        if (string.IsNullOrEmpty(title))
        {
            throw new ArgumentNullException(nameof(title), "Title cannot be null or empty.");
        }

        int padding = (length - title.Length) / 2;
        string headerLine = new(headerChar, length);

        ForegroundColor = foregroundColor;

        WriteLine($"\n\n{headerLine}");
        WriteLine($"{new string(' ', padding)}{title}");
        WriteLine($"{headerLine}\n");

        ResetColor();
    }

}
