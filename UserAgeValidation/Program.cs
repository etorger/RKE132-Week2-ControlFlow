// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal valida sugu (m/f)
//rakendus küsib kasutajalt perekonnanime
//lähtudes kasutaja valikust rakendus tervitab kastutajat järgmiselt
//"Welcome, Mr. (kasutaja perekonnanimi) / "Welcome, Ms. (kasutaja perekonnanimi)"
// loeb konsoolist maga andmeid string sõne formaadis
//char pmst lihtsamad andmed tuleks char salvestada sest sealt cpu jaoks "kergem" asjad kätte saada
//char parse pmst muudab sisu chariks mitte strigniks
//if vs else if, pigem kasutada else if kui kahe lihtsalt if, sest see arvutile kiirem
Console.WriteLine("Please select your gender (m/f)");

 char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();
 
if (userGender == 'm')
 {
     Console.WriteLine($"Welcome, Mr. {userLastName}!");
 }
 
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}

else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}








