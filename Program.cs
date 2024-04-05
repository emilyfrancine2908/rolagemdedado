using System.Security.Cryptography;
Console.WriteLine("--- Rolagem de Dado ---\n");

Console.WriteLine("Quantidade de Faces: 20");
Console.Write("Rolagem: ");
Console.Write(RandomNumberGenerator.GetInt32(1, 21));
