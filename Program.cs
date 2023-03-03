string frase, frase1, frase2, frase3, frase4, frase5;
frase = "} - Frutas Preferidas - {";
frase1 = "1° Maça";
frase2 = "2° Laranja";
frase3 = "3° Pera";
frase4 = "4° Mirtilo";
frase5 = "5° Atemoia";
string dialog(string text)
{
Console.WriteLine();
for (int i = 0; i < text.Length; i++)
{
    Console.Write(text[i]);
    Thread.Sleep(100);
}
return text;
}
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
dialog(frase);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
dialog(frase1);
dialog(frase2);
dialog(frase3);
dialog(frase4);
dialog(frase5);
Console.ResetColor();