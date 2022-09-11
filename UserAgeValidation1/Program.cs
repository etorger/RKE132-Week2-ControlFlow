// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutaja vanust
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul kuvatakse "Welcom to Instagram"
//"13" - salvestatakse heap, 13 aga stacki
//console readline tagastab ainult stringi(sõna), ehk tuleb konvertida 
//int32 parse konverteerib selle "13" lihtsalt 13ks (aint number)
//et saaks int kasutada


Console.WriteLine("Enter your age:");
int userAge = Int32.Parse(Console.ReadLine());
if(userAge >= 13)
{
    Console.WriteLine("Welome to Instagram!");
} else
{
    Console.WriteLine("You are too young to use Instagram.");
}
 
