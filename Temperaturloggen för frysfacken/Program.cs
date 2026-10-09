// Tre frysfack med två temperaturavläsningar i varje fack.
int[,] temperaturer =
{
    { -18, -22 },
    { -20, -16 },
    { -19, -21 }
};

// Börja med den första temperaturen, eftersom alla värden är negativa.
int varmasteTemperatur = temperaturer[0, 0];

// Gå igenom varje frysfack och båda mätpunkterna.
for (int fack = 0; fack < temperaturer.GetLength(0); fack++)
{
    for (int punkt = 0; punkt < temperaturer.GetLength(1); punkt++)
    {
        if (temperaturer[fack, punkt] > varmasteTemperatur)
        {
            varmasteTemperatur = temperaturer[fack, punkt];
        }
    }
}

Console.WriteLine($"Den varmaste temperaturen är {varmasteTemperatur} °C.");
