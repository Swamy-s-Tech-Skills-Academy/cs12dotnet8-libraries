namespace ConsoleColorStyleLib;

/// <summary>
/// Provides helper methods for working with console color styles.
/// </summary>
public static class ConsoleColorStyleHelper
{

    /// <summary>
    /// Gets the corresponding <see cref="ConsoleColor"/> for a given <see cref="ConsoleColorStyle"/>.
    /// </summary>
    /// <param name="style">The console color style.</param>
    /// <returns>The corresponding <see cref="ConsoleColor"/>.</returns>
    public static ConsoleColor GetConsoleForegroundColor(ConsoleColorStyle style) => (ConsoleColor)style;

    /// <summary>
    /// Sets the console foreground color based on the specified style.
    /// </summary>
    /// <param name="style">The console color style to set.</param>
    public static void SetConsoleForegroundColor(ConsoleColorStyle style) => ForegroundColor = (ConsoleColor)style;


    /// <summary>
    /// Resets the console foreground color to the default.
    /// </summary>
    public static void ResetConsoleColor() => ResetColor();
}
