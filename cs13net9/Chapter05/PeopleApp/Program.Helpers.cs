using System.Globalization; // To use cultureInfo.

partial class Program 
{
  private static void ConfigureConsole(
    string culture = "en-US",
    bool useComputerCulture = false,
    bool showCulture = true)
  {
    OutputEncoding = System.Text.Encoding.UTF8;

    if (!useComputerCulture)
    {
      CultureInfo.CurrentCulture = CultrueInfo.GetCultureInfo(culture);
    }

    if (showCultrue)
    {
      Console.WriteLine($"Current cultrue: {CultureInfo.CurrentCultrue.DisplayName}.");
    }
  }
}
