using System.IO;

namespace FileManager {
  public class FileManager {
    public bool Copy(string source, string to){
      File.Copy(source, to, true);
      return true;
    }
  }
}