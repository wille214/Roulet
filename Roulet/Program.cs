//intagning till kontot
Console.WriteLine(" Hur mycket vill du lägga in ");
string input  = Console.ReadLine();
int number = Convert.ToInt32(input);
//Starta Programet
Console.WriteLine(" Vill du starta [Y] [N] [E]");
string yesorno = Console.ReadLine();
Random rand = new Random();
Random random = new Random();
bool ContiniuRuning = true;
while (ContiniuRuning)
{
   
    if (yesorno == "Y"|| yesorno== "y")
    {
        //slut på pengar
        if (number == 0)
        {
            Console.WriteLine(" du har slut");
            Console.WriteLine(" Vill du lägga in pengar [Y] [E]");
            yesorno = Console.ReadLine();
            if(yesorno == "Y" || yesorno == "y")
            {
                Console.WriteLine(" hur mycket vill du lägga till ");
                input = Console.ReadLine();
                int number3 = Convert.ToInt32(input);
                number = number3;
            }
            }
        else
        {
            //Kontot
            Console.WriteLine(" Du har " + number + " på kontot ");
            Console.WriteLine(" Hur mycket vill du sattsa nu ");
            input = Console.ReadLine();
            int number2 = Convert.ToInt32(input);

            if (number2 > number)
            {
                Console.WriteLine(" You dont have " + number2 + " på kontot ");
                Console.WriteLine(" Vill du lägga in pengar [Y] [E]");
                yesorno = Console.ReadLine();
                //För lite på konto
                if (yesorno == "Y" || yesorno == "y")
                {
                    Console.WriteLine(" Hur myckt vill du lägga till ");
                    input = Console.ReadLine();
                    int number3 = Convert.ToInt32(input);
                    number = number + number3;
                }
            }
            else
            {
                //vad som spelas
                Console.WriteLine(" Vad vill du spela färg[1] Nummer[2] jämn,ojämn[3] ");
                input = Console.ReadLine();
                int gamemode = Convert.ToInt32(input);
                //om du valde ett gamemode som inte fanns
                if (gamemode > 3)
                {
                    Console.WriteLine(" Det finns bara 3 gamemodes " + gamemode );
                    Console.WriteLine(" Starta om [Y] [E] ");
                    yesorno = Console.ReadLine();
                }

                //färg roulet
                if (gamemode == 1)
                {
                    Console.WriteLine(" Villken färg " + " röd[1] " + " svart[2] " + " Grön[3] ");
                    input = Console.ReadLine();
                    int color = Convert.ToInt32(input);
                        if(color > 3)
                        {
                            Console.WriteLine(" 1,2,3 inte " + color );
                            Console.WriteLine("starta om [Y] [E]");
                            yesorno = Console.ReadLine();
                        }
                        else
                        {
                            int randomtall = random.Next(38);
                            //röd
                            if (randomtall % 2 == 0 && color == 1)
                            {
                                number = number2 * 2 + number;
                                Console.WriteLine(" You won " + number2 * 2 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();

                            }
                            //svart
                            else if (randomtall % 2 == 1 && color == 2)
                            {
                                number = number2 * 2 + number;
                                Console.WriteLine(" You won " + number2 * 2 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();

                            }
                            //grön
                            else if (randomtall == 0 && color == 3)
                            {
                                number = number2 * 10 + number;
                                Console.WriteLine(" You won " + number2 * 10 + " kr");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();
                            }
                            //lost
                            else
                            {
                                number = number - number2;
                                Console.WriteLine(" You Lost " + number2 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();
                            } 
                        }
                }   
                else if (gamemode == 2)
                {

                    // nummer roulet
                    Console.WriteLine(" Vilket nummer mellan 0 och 36 ");
                    input = Console.ReadLine();
                    int weel = Convert.ToInt32(input);
                    for (int i = 0; i < 1; i++)
                    {
                        if (weel >= 36)
                        {
                            Console.WriteLine(" mellan 0-36 inte " + weel);
                            while (weel > 36) 
                            {
                                Console.WriteLine("testa igen");
                                input = Console.ReadLine();
                                int weel2 = Convert.ToInt32(input);
                                weel = weel2;
                            }
                                int randomtal = rand.Next(1);
                                Console.WriteLine(randomtal);
                            //won
                            if (weel == randomtal)
                            {
                                number = number2 * 5 + number;
                                Console.WriteLine(" You won " + number2 * 5 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();
                            }
                            //lost
                            else if (randomtal != weel)
                            {
                                number = number - number2;
                                Console.WriteLine(" You lost " + number2 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();
                            }
                        }
                        else
                        {
                            int randomtal = rand.Next(1);
                            Console.WriteLine(randomtal);
                            //won
                            if (weel == randomtal)
                            {
                                number = number2 * 5 + number;
                                Console.WriteLine(" You won " + number2 * 5 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();
                            }
                            //lost
                            else if (randomtal != weel)
                            {
                                number = number - number2;
                                Console.WriteLine(" You lost " + number2 + " kr ");
                                Console.WriteLine(" Start [Y] leave [E] ");
                                yesorno = Console.ReadLine();
                            }
                        }
                    }
                }
                else if (gamemode == 3)
                {
                    Console.WriteLine(" Ojämn[1] eller jämn[2] ");
                    input = Console.ReadLine();
                    int jemn = Convert.ToInt32(input);
                    if (jemn > 2)
                    {
                        Console.WriteLine(" 1,2 inte " + jemn);
                        Console.WriteLine("starta om [Y] [E]");
                        yesorno = Console.ReadLine();
                    }
                    else
                    {  
                        int randomtall = rand.Next(38);
                        //won jämn
                        if (randomtall % 2 == 0 && jemn == 2)
                        {
                            number = number2 * 2 + number;
                            Console.WriteLine(" You won " + number2 * 2 + " kr ");
                            Console.WriteLine(" Start [Y] leave [E] ");
                            yesorno = Console.ReadLine();
                        }
                        //won ojämn
                        else if (randomtall == 0 && jemn == 1)
                        {
                            number = number2 * 2 + number;
                            Console.WriteLine(" You won " + number2 * 2 + " kr ");
                            Console.WriteLine(" Start [Y] leave [E] ");
                            yesorno = Console.ReadLine();
                        }
                        //lost
                        else
                        {
                            number = number - number2;
                            Console.WriteLine(" You lost " + number2 + " kr ");
                            Console.WriteLine(" Start [Y] leave [E] ");
                            yesorno = Console.ReadLine();
                        } 
                    }
                }   
            }
        }   
    }//Om du sa Nej Och ska lägga in nytt summa//
    else if(yesorno == "N" || yesorno == "n") 
    {
        Console.WriteLine(" Hur mycket vill du lägga in ");
        input = Console.ReadLine();
        int numer4 = Convert.ToInt32(input);
        number = numer4;
        Console.WriteLine(" Starta [Y] leave [E]");
        yesorno = Console.ReadLine();
    }
    //leave
     else if (yesorno == "E" || yesorno == "e")
    {
        ContiniuRuning = false;
    }
    else 
    {
        Console.WriteLine(" Det är inget komado ");
        Console.WriteLine(" Vill du starta om [Y] eller vill du avsluta [E] ");
        yesorno = Console.ReadLine();
    }
}



/*
Random rand = new Random();

Console.WriteLine("a number 0-36");
string input = Console.ReadLine();
int weel = Convert.ToInt32(input);


if (weel >= 36)
{
    Console.WriteLine(" mellan 0-36 inte " + weel);

    waile(well > 36)
    {
        Console.WriteLine("testa igen");
        input = Console.ReadLine();
        int weel2 = Convert.ToInt32(input);
        weel = weel2;
        
    }
    int randomtal = rand.Next(1);
    Console.WriteLine(randomtal);
}
    

    /*


Random random = new Random();
Random rand = new Random();
Console.WriteLine("vill du spela med färjg[1] nummer[2] eller båda[3] ");
string input = Console.ReadLine();
int gamemode = Convert.ToInt32(input);
if (gamemode == 1)
{

    //18röd 18svarat ojämn 1 grön
    Console.WriteLine("villken färg " + "röd[1]" + "svart[2]" + "Grön[3]");
    Console.WriteLine("vilken färg");
    input = Console.ReadLine();
    int color = Convert.ToInt32(input);
    for (int i = 0; i < 1; i++)
    {
        int randomtall = random.Next(38);

        if (randomtall % 2 == 0 && color == 1)
        {
            Console.WriteLine("you won");
        }
        else if (randomtall % 2 == 1 && color == 2)
        {
            Console.WriteLine("You won");

        }
        else if (randomtall == 0 && color == 3)
        {
            Console.WriteLine("You won");
        }
        else
        {
            Console.WriteLine("You Lost");
        }

    }
}
else if (gamemode == 2)
{
    Console.WriteLine("villket nummber mellan 0 -36");
    input = Console.ReadLine();
    int weel = Convert.ToInt32(input);
    for (int i = 0; i < 1; i++)
    {
        int randomtal = rand.Next(38);
        Console.WriteLine(randomtal);

        if (weel == randomtal)
        {
            Console.WriteLine("you Won");
        }
    }
}
    /*
}else if(gamemode == 3)
{
    Console.WriteLine("villken färg " + "röd[1]" + "svart[2]" + "Grön[3]");
    Console.WriteLine("vilken färg");
    input = Console.ReadLine();
    int color = Convert.ToInt32(input);
    Console.WriteLine("villket nummber mellan 0 -36");
    input = Console.ReadLine();
    int weel = Convert.ToInt32(input);
    for (int i = 0; i < 1; i++)
    {
        //nummer
        int randomtal = rand.Next(38);
        //färg
        int randomtall = rand.Next(38);
        Console.WriteLine(randomtal);

        if (randomtall % 2 == 0 && weel == randomtal)
        {
            Console.WriteLine("röd won");
        }
        else if (randomtall % 2 == 1 && weel == randomtal)
        {
            Console.WriteLine("SVart won");

        }
        else if (randomtall == 0)
        {
            Console.WriteLine("görn won");
        }
    }

}
*/





