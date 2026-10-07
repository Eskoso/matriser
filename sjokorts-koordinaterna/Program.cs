// Ett enkelt sjökort över ett litet område i Egeiska havet.
string[,] sjokort =
{
    { "Öppet hav", "Ö", "Öppet hav" },
    { "Klippa", "Ö", "Öppet hav" },
    { "Öppet hav", "Öppet hav", "Klippa" }
};

// Mittrutan ligger på rad 1 och kolumn 1 eftersom index börjar på 0.
Console.WriteLine(sjokort[1, 1]);
