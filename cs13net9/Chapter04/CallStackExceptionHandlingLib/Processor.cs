namespace CallStackExceptionHandlingLib;

public class Processor
{
    public static void Gamma() // public so it can be called from outside.
    {
      Console.WriteLine("In Gamma");
      Delta();
    }

    private static void Delta() // private so it can only called internally.
    {
      Console.WriteLine("In Delta");
      File.OpenText("bad file path");
    }
}
