// 3 - LSP (Liskov's Substitution Principle)

// Barbara Liskov tarafından ortaya atılmıştır.

using LSP;

Daire daire = new Daire() { Yaricap = 4 };
Silindir silindir = new Silindir() { Yaricap = 4, Yukseklik = 10 };

Console.WriteLine(Hesaplayici.Hesapla(daire));
Console.WriteLine(Hesaplayici.Hesapla(silindir));
