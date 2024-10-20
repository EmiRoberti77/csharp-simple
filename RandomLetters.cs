namespace samples_emi {
  public class RandomLetters {
    public static string createRandomLetters() {
      Random r = new Random();
      char[] letters = new char[10];
      for(int i=0; i<10; i++){
        letters[i]=(char)r.Next(97, 122);
      }
      return new string(letters);
    }
  }
}