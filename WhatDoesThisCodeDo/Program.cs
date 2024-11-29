//Originalt teller den hvor mange av hver bokstav som finnes i det som blir skrevet inn + legger det alfabetisk
//Den teller store og små bokstaver likt


var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    string upperCaseText = text.ToUpper();
    int totalCharacter = upperCaseText.Length;
    foreach (var character in upperCaseText ?? string.Empty)
    {
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            double percentage = counts[i]*100/totalCharacter;
            Console.WriteLine(character + " - " + counts[i] + " (Prosent:" + percentage + "%)");

        }
    }
}

//Character/Range