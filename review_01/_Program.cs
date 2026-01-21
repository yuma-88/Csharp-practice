// class Program
// {
//   private static double dblFirstNum;
//   private static double dblSecondNum;
//   private static double dblresult;
//   static void Main()
//   {
//     Console.WriteLine();
//     Console.WriteLine("=== 四則計算コンソールアプリ ===");

//     while(true)
//     {
//       Console.Write("一つ目の値を入力してください:");
//       string? strFirstInput = Console.ReadLine();

//       if (double.TryParse(strFirstInput, out dblFirstNum))
//       {
//         break;
//       }

//       Console.WriteLine("正しい数値を入力してください。");
//     }

//     while(true)
//     {
//       Console.Write("二つ目の値を入力してください:");
//       string? strSecondInput = Console.ReadLine();

//       if (double.TryParse(strSecondInput, out dblSecondNum))
//       {
//         break;
//       }

//       Console.WriteLine("正しい数値を入力してください。");
//     }

//     Console.WriteLine("下記から演算子を選択してください。");
//     Console.WriteLine("1: + ");
//     Console.WriteLine("2: - ");
//     Console.WriteLine("3: * ");
//     Console.WriteLine("4: / ");

//     while(true)
//     {
//       Console.WriteLine();
//       Console.Write("選択番号:");
//       string? strSelectNum = Console.ReadLine();

//       switch (strSelectNum)
//       {
//         case "1":
//         {
//           dblresult = Sum();
//           break;
//         }
//         case "2":
//         {
//           dblresult = Difference();
//           break;
//         }
//         case "3":
//         {
//           dblresult = Product();
//           break;
//         }
//         case "4":
//         {
//           dblresult = Quotient();
//           break;
//         }
//         default:
//         {
//           Console.WriteLine("選択肢から選んでください。");
//           continue;
//         }
//       }

//       Console.WriteLine($"計算結果: {dblresult}");
//       return;
//     }
//   }

//   static double Sum()
//   {
//     return dblFirstNum + dblSecondNum;
//   }

//   static double Difference()
//   {
//     return dblFirstNum - dblSecondNum;
//   }

//   static double Product()
//   {
//     return dblFirstNum * dblSecondNum;
//   }

//   static double Quotient()
//   {
//     if (dblSecondNum == 0)
//     {
//       Console.WriteLine("0では割れません。");
//       return 0;
//     }
//     return dblFirstNum / dblSecondNum;
//   }
// }