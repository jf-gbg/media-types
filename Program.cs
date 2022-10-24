// See https://aka.ms/new-console-template for more information
using media_types;

Console.Write("Enter file name: ");
string fileName = Console.ReadLine();
MediaFile mediaFile = new MediaFile(fileName);

Console.WriteLine(mediaFile.GetMIMEType());