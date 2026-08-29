// Ejercicio 15
// Informar cuantos días faltan para el 25/12/2020.

string fecha_hoy = DateTime.Now.ToString("yyyyMMdd");
string fecha_especifica = "20260825";

DateTime hoy = DateTime.ParseExact(fecha_hoy, "yyyyMMdd", null);
DateTime especifica = DateTime.ParseExact(fecha_especifica, "yyyyMMdd", null);

TimeSpan diferencia = especifica - hoy;

Console.WriteLine("faltan " + diferencia.Days + " dias");