// Ce premier programme multiplie 3 nombre entre eux 
do
{
    Console.WriteLine("Choisi 3 nombres qui vont être multiplier entre eux ");
    string str= Console.ReadLine();
        if(str == "stop")
        break;
    int a = Convert.ToInt32(str)    ;
    Console.WriteLine("Choisi un second nombre");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choisi un dernier nombre");
    int c = Convert.ToInt32(Console.ReadLine());
    int sum = a * b * c;
    Console.WriteLine("Le résultat est {0}\n", sum);
    Console.WriteLine("Marque stop si tu veux arrêter le programme\n");
}
while(true);

// Le second programme est là pour vérifier l'âge de la personne 

do
{
    Console.WriteLine("\nQuel est votre age ?");
    string str = Console.ReadLine();
    if (str == "stop")
        break;
    int a = Convert.ToInt32(str);
  
    switch (a)
    {
        case 18:
            Console.WriteLine("Enfin le droit de vote !");
            break;
        case < 18:
            Console.WriteLine("Dommage vous êtes mineur :(");
            break;
        default:
            Console.WriteLine("Vous êtes majeur trop bien !!");
            break;
    }
}
while (true);