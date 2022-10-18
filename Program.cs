//Manuel Leyva
//10-18-22
//Asking question
//You will be asked two questions and the user will input his answer
//Peer review;

string Useri = "";
do{

Console.Clear();
Console.WriteLine("What is your Name");
string myName = Console.ReadLine();
Console.WriteLine("Nice to Meet You " + myName);

Console.WriteLine("What time did you wake up");
string myTime = Console.ReadLine();
Console.WriteLine("Your name is " + myName + " and you woke up at " + myTime );

do
{
    Console.WriteLine("Do you want to continue: Yes or No?");
    Useri = Console.ReadLine().ToUpper();
    if(Useri != "YES" && Useri != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (Useri !="YES" && Useri != "NO");
}while(Useri == "YES");