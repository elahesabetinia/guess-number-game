int secret = Random.Shared.Next(1, 101);  
int attempts = 0;

Console.WriteLine("I picked a number between 1 and 100. Guess it!");

while (true)
{
    Console.Write("Your guess: ");

    
    if (!int.TryParse(Console.ReadLine(), out int guess))
    {
        Console.WriteLine("Invalid input! Please enter a number.");
        continue;   
    }

    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
        continue;
    }

    attempts++;   

    if (guess < secret)
    {
        Console.WriteLine("Higher! ⬆️");
    }
    else if (guess > secret)
    {
        Console.WriteLine("Lower! ⬇️");
    }
    else
    {
        Console.WriteLine($"\n🎉 Correct! You guessed it in {attempts} attempts.");
        break;   
    }
}
