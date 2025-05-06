// 1 - SRP (Single Responsibility Principle)

// soru: json, xml dosyalarından veri okuyan yapıları yazınız


// kotu SRP ornegi.
string DosyadanOku(string dosyaAdi)
{
    //...
    if(dosyaAdi.Contains("json"))
    {
        // json dosyasını oku        
    }
    else if (dosyaAdi.Contains("xml"))
    {
        // xml dosyasını oku        
    }
    else
    {
        throw new Exception("Dosya tipi desteklenmiyor");
    }
    return "";
}
