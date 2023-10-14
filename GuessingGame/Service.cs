namespace GuessingGame
{
public class Service
{
    public int getAmount()
    {
        //  var amount=Console.ReadLine();
        if (!int.TryParse(Console.ReadLine(), out int amount))
        {
            Console.WriteLine("Invalid input. Please enter a valid whole number.");
            getAmount();
        }

        return Convert.ToInt32(amount);

    }

    public int getNumber()
    {
        //   var number=Console.ReadLine();
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid whole number.");
        }

        return Convert.ToInt32(number);
    }

    public string getLevel(string difficulty)
    {


        int minRange, maxRange, multiplier;
        while (true)
        {
            switch (difficulty.ToLower())
            {

                case "easy":
                    minRange = 1;
                    maxRange = 5;
                    multiplier = 5;
                    break;
                case "medium":
                    minRange = 1;
                    maxRange = 10;
                    multiplier = 10;
                    break;
                case "hard":
                    minRange = 1;
                    maxRange = 20;
                    multiplier = 20;
                    break;
            }
            continue;
        }
        Random random = new Random();
        int randomNumber = random.Next(minRange, maxRange + 1);

        if (getNumber() == randomNumber)
        {
            int winnings = getAmount() * multiplier;
            Console.WriteLine($"Congratulations! You won {winnings} dollars.");
        }
        else
        {
            Console.WriteLine($"Sorry, you lost. The correct number was {randomNumber}.");
        }
    }

}

}
