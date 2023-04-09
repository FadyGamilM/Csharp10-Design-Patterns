namespace Singleton;

public class SingletonLogger
{
   // private constructor so there is no one can instantiate this class
   private SingletonLogger() { }

   // backend field to manage if there is an instance created before or not 
   private static SingletonLogger? _instance;

   // public property so clients can interact with the class through it 
   public static SingletonLogger Instance
   {
      get
      {
         // if the instnace backend field is null, create a new one, else return the prviusoly created one
         return _instance is null ? new SingletonLogger() : _instance;
      }
      private set { }
   }

   // the signleton operation, which is an opertion that can be accessed through the public returned instance 
   public void Log(string msg)
   {
      Console.WriteLine($"[Logger] ➜  {msg}");
   }
}