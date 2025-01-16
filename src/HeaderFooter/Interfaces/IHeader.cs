namespace HeaderFooter.Interfaces;

public interface IHeader
{
    void DisplayHeader(char headerChar, string title, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Yellow);
}
