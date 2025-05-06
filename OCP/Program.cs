// OCP (Open/Closed Principle)
// Open Extention - Closed Modification

// json, xml dosyalarından veri okuyan yapılar sorusunu çözüyoruz

// 1- interface 2- kalıtım kullanarak yapılabilir. 
// Interface esneklik sağlar. Kalıtım hiyerarşi sağlar.

using OCP;

JsonDosya json = new();
XmlDosya xml = new();

DosyaYoneticisi dosyaYoneticisi = new DosyaYoneticisi();

Console.WriteLine(json.Oku());
Console.WriteLine(xml.Oku());