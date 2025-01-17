namespace HeaderFooter.Interfaces;

public interface IFooter
{
    void DisplayFooter(char footerChar, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Yellow);
}
