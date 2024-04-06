using System.Security.Cryptography;

int faces, sorteado;

Console.WriteLine("--- Rolagem de Dado ---\n");

Console.Write("Quantas Faces? ");
faces = Convert.ToInt32(Console.ReadLine());

sorteado = RandomNumberGenerator.GetInt32(1, faces + 1);

Console.WriteLine($"Rolagem: {sorteado}");
