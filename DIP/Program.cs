// 5 - DIP (Dependency Inversion Principles)

/* 3 şekilde uyarlanır
 * 1. Constructor Injection
 * 2. Property Injection
 * 3. Method Injection
 */

using DIP.IyiYontem;

SqlDatabase sqlDatabase = new SqlDatabase();
OracleDatabase oracleDatabase = new OracleDatabase();

void EkranaYaz(IEnumerable<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

DatabaseManager manager1 = new DatabaseManager(sqlDatabase);
EkranaYaz(manager1.VerileriListele());

DatabaseManager manager2 = new DatabaseManager(oracleDatabase);
EkranaYaz(manager2.VerileriListele());

DatabaseManager manager3 = new DatabaseManager();
manager3.MethodInjection(sqlDatabase); // kullanmazsak nullreferance hatası alınır
EkranaYaz(manager3.VerileriListele());

DatabaseManager manager4 = new DatabaseManager();
manager4.PropertyInjection = oracleDatabase; // kullanmazsak nullreferance hatası alınır
EkranaYaz(manager4.VerileriListele());