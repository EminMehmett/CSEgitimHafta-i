// See https://aka.ms/new-console-template for more information

Console.WriteLine("Tip Dönüşümleri!");

//C# Tip Dönüşümleri 
// 1- Implicit casting : otomatik dönüşüm 
//2- Explicit casting : manuel dönüşüm 
Console.WriteLine("Implicit casting");
int sayi = 2147483647;
double kesirliSayi = sayi; // int doubledan daha küçük yapıda olduğu için küçük değer otomatik olarak dönüşür

Console.WriteLine(sayi);
Console.WriteLine(kesirliSayi);

Console.WriteLine();

Console.WriteLine("Explicit casting");

double kesirliSayi2 = 2147483647;

int tamSayi = (int)kesirliSayi2;// Manuel dönüştürme

Console.WriteLine(kesirliSayi2);
Console.WriteLine(tamSayi);

//Diğer tür dönüştürme yöntemi 

Console.WriteLine("Diğer tür dönüştürme yöntemi ");

int tamSayi2 = 25;
double kesirliSayi3 = 84;
bool aktif = true;

Console.WriteLine(tamSayi2.ToString());
Console.WriteLine(Convert.ToDouble(tamSayi2));
Console.WriteLine(Convert.ToInt32(kesirliSayi3));
Console.WriteLine(Convert.ToString(aktif));
