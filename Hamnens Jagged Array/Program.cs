// Varje brygga är en egen underarray med olika antal båtplatser.
string[][] hamn =
{
    new string[] { "Tom", "Tom", "Tom" },
    new string[] { "Tom", "Tom", "Tom", "Tom", "Tom" },
    new string[] { "Tom", "Tom" }
};

int totalKapacitet = 0;

// Length på varje underarray anger antalet platser på den bryggan.
for (int brygga = 0; brygga < hamn.Length; brygga++)
{
    totalKapacitet += hamn[brygga].Length;
}

Console.WriteLine($"Hamnens totala kapacitet är {totalKapacitet} båtplatser.");
