using System;

class Program
{
 public static void Main(string[] args)
 {
string user1, user2;
Console.WriteLine("Welcome to rock paper scissors, user 1 make first move:");
     user1 = Console.ReadLine();
Console.WriteLine("Now user 2 can make their move:");
    user2 = Console.ReadLine();

    if(user1=="rock")
    {

        if(user2=="paper")
        {
            Console.WriteLine("user 2 wins!");
        } 
        if(user2=="rock")
        {
            Console.WriteLine("Tie");
        } 
        if(user2=="scissors")
        {
            Console.WriteLine("User 1 wins!");
        }
    } else if(user1=="paper")
        {
        if(user2=="paper")
        {
            Console.WriteLine("Tie game");
        }
        if (user2=="rock") 
        {
            Console.WriteLine("User 1 wins");
        } 
        if (user2=="scissors") 
        {
            Console.WriteLine("User 2 wins");
        }
        } else if(user1=="Scissors") {
         if(user2=="Scissors")
         {
             Console.WriteLine("Tie Game");
         }
        if(user2=="Rock")
        {
            Console.WriteLine("User 2 wins!");
        }
        if(user2=="paper") {
            Console.WriteLine("User 1 wins!");
        }
    }
 }
}
