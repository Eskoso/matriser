// Taxibåten har 4 rader med 2 sittplatser på varje rad.
string[,] sittplatser =
{
    { "Ledig", "Ledig" },
    { "Ledig", "Ledig" },
    { "Ledig", "Ledig" },
    { "Ledig", "Ledig" }
};

// Ändra värdena på de platser där passagerarna sitter.
sittplatser[0, 0] = "Anna";
sittplatser[2, 1] = "Björn";

// Den yttre loopen går igenom raderna.
for (int rad = 0; rad < sittplatser.GetLength(0); rad++)
{
    // Den inre loopen går igenom sittplatserna på den aktuella raden.
    for (int kolumn = 0; kolumn < sittplatser.GetLength(1); kolumn++)
    {
        Console.Write(sittplatser[rad, kolumn] + "\t");
    }

    Console.WriteLine();
}
