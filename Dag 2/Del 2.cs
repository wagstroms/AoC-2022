
List<string> lines = File.ReadAllLines("C:\\Users\\Simon\\OneDrive\\VS\\TestWPF\\ConsoleApp8\\ConsoleApp8\\TextFile1.txt").ToList();
List<string> resultat = new List<string>();

foreach(string x in lines)
{
    Console.WriteLine(x);
}

int myScore = 0, opScore = 0;

string WinPredicter(string c)
{
    switch (c)
    {
        case "A": 
            return "Y";
        case "B": 
            return "Z";
        case "C": 
            return "X";
    }
    return "0";
}
string LostPredicter(string c)
{
    switch (c)
    {
        case "A":
            return "Z";
        case "B":
            return "X";
        case "C":
            return "Y";
    }
    return "0";
}

int Str2Int(string c)
{
    switch (c)
    {
        case "A": return 1;
        case "B": return 2;
        case "C": return 3;

        case "X": return 1;
        case "Y": return 2;
        case "Z": return 3;

    }
    return 0;
}

foreach (string item in lines)
{

    //X = förlust
    //Y = lika
    //Z = vinst
    
    string[] split = item.Split(' ');

    if (split[1] == "X")
    {
        string opLetter = split[0];
        resultat.Add($"{Str2Int(opLetter)} {Str2Int(LostPredicter(opLetter))}  vinst");
    }

    if (split[1] == "Y")
    {
        string opLetter = split[0];
        resultat.Add($"{Str2Int(opLetter)} {Str2Int(opLetter)} lika ");
    }

    if (split[1] == "Z")
    {
        string opLetter = split[0];
        resultat.Add($"{Str2Int(opLetter)} {Str2Int(WinPredicter(opLetter))}");
    }
}

foreach(string item in resultat)
{
    Console.WriteLine(item);
}

foreach (string item in resultat)
{
    string[] split = item.Split(' ');


    //dec values int.
    int num1 = int.Parse(split[0]); 
    int num2 = int.Parse(split[1]);

    //methods
    void Win1()
    {
        opScore += 6 + num1;
        myScore += num2;
    }

    void Win2()
    {
        myScore += 6 + num2;
        opScore += num1;
    }
    //

    //spellogik
    if (num1 == num2)
    {
        opScore += num1 + 3;
        myScore += num2 + 3;
    }
    else
    {
        if (num1 == 1 && num2 == 2) { Win2(); }
        if (num1 == 1 && num2 == 3) { Win1(); }
        if (num1 == 2 && num2 == 1) { Win1(); }
        if (num1 == 2 && num2 == 3) { Win2(); }
        if (num1 == 3 && num2 == 1) { Win2(); }
        if (num1 == 3 && num2 == 2) { Win1(); }
    }
}


Console.WriteLine("Opponents score: " + opScore);
Console.WriteLine("My score: " + myScore);



















Console.ReadKey();