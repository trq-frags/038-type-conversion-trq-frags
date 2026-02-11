namespace knightmoves;

public class Converter{
      public static (int, int) ToTuple(string position){
         char file = position[0];
         char rank = position[1];
   
         int x = file - 'a';
         int y = rank - '1';
   
         return (x, y);
      }
      public static string ToString((int, int) position){
         char file = (char)('a' + position.Item1);
         char rank = (char)('1' + position.Item2);
   
         return $"{file}{rank}";
      }
}