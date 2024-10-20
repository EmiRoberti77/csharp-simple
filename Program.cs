// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.IO;
using samples_emi;

namespace app {
  class Program {
   static void Main(string[] args){
      Console.WriteLine("Arguments " + string.Join(", ",  args));
      Console.WriteLine(args[0], args[1]);
      byte number = (byte)255;
      Console.WriteLine("value {0}", number);
      string a = "2";
      int b = Convert.ToInt32(a);
      Console.WriteLine(b);
      try{
        int val = Person.Add(1,1);
        Console.WriteLine("person value {0}", val);
        var p = new Person(){Age=3};
        Console.WriteLine("person age {0}", p.Age);
        p.Introduce();
        int[] numbers = new int[]{1,2,3,4};
        for(int i=0; i<numbers.Length;i++){
          Console.WriteLine(i);
        }
        var text = @"hello
new line1
new lin2
c:\programs\bin";
        Console.WriteLine(text);
        Console.WriteLine(RandomLetters.createRandomLetters());
        var list = new List<int>(){1,2};
        list.Add(3);
        foreach(int n in list){
          Console.WriteLine(n);
        }
        var dTime = new DateTime();
        var now = DateTime.Now;
        var today = DateTime.Today;
        Console.WriteLine(dTime);
        Console.WriteLine(now);
        Console.WriteLine(today);
        string message = "hello all how are you";
        string[] split = message.Split(' ');
        Console.WriteLine(string.Join(", ", split));
        var files = Directory.GetFiles(@"/Users/emiliano.roberti/code/c#/simple1");
        foreach(string f in files){
          Console.WriteLine(f);
        }

      }catch(Exception e){
        Console.WriteLine(e.ToString());
      }
    }
  } 
}

