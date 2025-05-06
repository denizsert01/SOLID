using System.Diagnostics;
using System.Threading.Tasks;


void Islem1()
{
    Console.WriteLine("Islem 1");
    Thread.Sleep(5000);
    Console.WriteLine("Islem 1 bitti");
}
void Islem2()
{
    Console.WriteLine("Islem 2");
    Thread.Sleep(8000);
    Console.WriteLine("Islem 2 bitti");
}
void Islem3()
{
    Console.WriteLine("Islem 3");
    Thread.Sleep(7000);
    Console.WriteLine("Islem 3 bitti");
}

// Senkron
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();

//Islem1();
//Islem2();
//Islem3();

//stopwatch.Stop();
//Console.WriteLine("Gecen süre = " + stopwatch.ElapsedMilliseconds);



async Task Islem1Async()
{
    Console.WriteLine("Islem 1");
     await Task.Delay(5000);
    Console.WriteLine("Islem 1 bitti");
}
async Task Islem2Async()
{
    Console.WriteLine("Islem 2");
    await Task.Delay(8000);
    Console.WriteLine("Islem 2 bitti");
}
async Task Islem3Async()
{
    Console.WriteLine("Islem 3");
    await Task.Delay(7000);
    Console.WriteLine("Islem 3 bitti");
}

// Asenkron
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Task.WaitAll(
    Islem1Async(),
    Islem2Async(),
    Islem3Async()
);

stopwatch.Stop();
Console.WriteLine("Gecen süre = " + stopwatch.ElapsedMilliseconds);