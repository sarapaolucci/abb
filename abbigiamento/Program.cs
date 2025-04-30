
string filePath = "inflazione.txt";
string[] prodotti = File.ReadAllLines("prodotti_abbigliamento.csv");
string[] s = new string[5];
float prezzo;
string filePath1 = "Sport.txt";
StreamWriter writer1 = new StreamWriter(filePath1);
StreamWriter writer = new StreamWriter(filePath);
for(int i = 0; i < prodotti.Length; i++)
{
    s = prodotti[i].Split(",");
    for(int j = 0; j < s.Length; j++)
    {
        if(j == 3 && i != 0)
        {
            prezzo = float.Parse(s[j]);
            prezzo += prezzo * 10 / 100;
            s[3] = prezzo.ToString();
        }
        prezzo = 0;
        if (s[j]== "Sport" && i != 0)
        {
            for (int k = 0; k < s.Length; k++)
            {
                writer1.Write(s[k] + " ");
            }
            writer1.WriteLine();
        }
    }
    for(int j = 0;j < s.Length; j++)
    {
        writer.Write(s[j] + " ");
    }
    writer.WriteLine();
}
writer.Close();
writer1.Close();