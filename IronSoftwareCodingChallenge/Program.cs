// See https://aka.ms/new-console-template for more information
using IronSoftwareCodingChallenge;
using System.Text;

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Enter keypad input (end with #):");
string input = Console.ReadLine();

if(input.LastOrDefault() != '#')
{
    Console.WriteLine("Input not completed. Please end with #.");
    return;
}

string result = KeyPadService.OldPhonePad(input);
Console.WriteLine($"Output: {result}");


//Console.WriteLine(KeyPadService.OldPhonePad("33#"));
//Console.WriteLine(KeyPadService.OldPhonePad("33"));
//Console.WriteLine(KeyPadService.OldPhonePad("227*#"));
//Console.WriteLine(KeyPadService.OldPhonePad("4433555 555666#"));
//Console.WriteLine(KeyPadService.OldPhonePad("4433*3555 555666*6#"));
//Console.WriteLine(KeyPadService.OldPhonePad("8 88777444666*664#"));