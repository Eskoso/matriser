// Lagret har tre rader med fyra förvaringsboxar i varje rad.
int[,] paket =
{
    { 5, 8, 3, 6 },
    { 10, 4, 7, 9 },
    { 2, 6, 8, 5 }
};

int totaltAntalPaket = 0;

// Radindex 1 är den andra raden. Gå igenom dess fyra boxar.
for (int box = 0; box < paket.GetLength(1); box++)
{
    totaltAntalPaket += paket[1, box];
}

Console.WriteLine($"Den andra raden i tullagret innehåller totalt {totaltAntalPaket} paket.");
