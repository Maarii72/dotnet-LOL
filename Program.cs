using System;
using dotnet_LOL.src.Entities;

namespace dotnet_LOL{
  class Program{
    static void Main (string[] args){
      Lutador C1 = new Lutador("Darius", 5, "lutador");
      Lutador C2 = new Lutador("Aatrox", 9, "lutador");

      

      Console.WriteLine(C1.Attack());
    }
  }
}
