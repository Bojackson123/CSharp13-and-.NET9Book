// Do not define a namespace so this class goes in the defaulot empty
// namespace just like the auto-generated partial Program class.

partial class Program
{
  static void WhatsMyNamespace() // Define a static function
  {
    Console.WriteLine("Namespace of Program class: {0}", 
      arg0: typeof(Program).Namespace ?? "null");
  }
}