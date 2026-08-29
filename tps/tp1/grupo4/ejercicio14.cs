// Ejercicio 14
// Dadas dos fechas calcular la diferencia en días entre una y la otra.

string fecha_hoy = DateTime.Now.ToString("yyyyMMdd");
string fecha_ayer = DateTime.Now.AddDays(-5).ToString("yyyyMMdd");

DateTime hoy = DateTime.ParseExact(fecha_hoy, "yyyyMMdd", null);
DateTime ayer = DateTime.ParseExact(fecha_ayer, "yyyyMMdd", null);

TimeSpan diferencia = hoy - ayer;

Console.WriteLine("Diferencia: " + diferencia.Days + " días");