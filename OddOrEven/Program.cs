

Console.WriteLine("Enter a number:");
int UserNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris voi paaritu

int result = UserNum % 2;

if (result != 0) //!= - ei ole
{
    Console.WriteLine("User numbebr is odd.");
}else
{
    Console.WriteLine("User number is even.");
}
