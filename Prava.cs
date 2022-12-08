

int yas;


    Console.WriteLine("Yasinizi daxil edin: " );

yas = Convert.ToInt32(Console.ReadLine());


    if (yas >= 18)
    {
        Console.WriteLine("Suruculuk vesiqesi ala bilersiz.");
    }
    else
    {
    yas = 18 - yas;
    Console.WriteLine("Suruculuk vesiqesi ala bilmersiz.");
    Console.WriteLine("Suruculuk vesiqesi ala bilmeyiniz ucun qalan muddet:");
    Console.WriteLine(yas);
}



