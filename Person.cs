using System.Security.Cryptography;

namespace app {
  public struct PersonDetails {
    public string firstName;
    public string lastName;
  }

  public class Person {
    public PersonDetails pd;
    public int Age;

    public Person(){
      this.pd.firstName = "emi";
      this.pd.lastName = "roberti";
    }
    public static int Add(int a, int b){
      return a + b;
    }

    public void Introduce(){

      Console.WriteLine("{0} {1}", this.pd.firstName, this.pd.lastName);
    }
  }
}