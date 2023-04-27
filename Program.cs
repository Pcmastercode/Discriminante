using System;
class Program{
 
     static void Main(string[] args)
{ // ax^2 + bx + c = 0  a != 0
    //2x^2 + 3x + 4 = 0 
   var a = Convert.ToDouble(Console.ReadLine());
    var b = Convert.ToDouble(Console.ReadLine());
   var c = Convert.ToDouble(Console.ReadLine());
    var D = Math.Pow(b, 2) - 4 * a * c;
    if(D > 0){
      var x1 = (-b + Math.Sqrt(D)) / (2 * a);
      var x2 = (-b - Math.Sqrt(D)) / (2 * a);
      Console.WriteLine($"1 koren {x1}, 2 koren {x2}");
    } else if( D == 0){
        var x3 = -(b/2 * a);
        Console.WriteLine($"koren {x3}");
    } else{
        Console.WriteLine("Korney net");
    }
}
}

