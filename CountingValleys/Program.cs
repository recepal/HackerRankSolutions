CountingValleys(8, "UDDDUDUU");

void CountingValleys(int steps, string path)
{
    int result = 0;
    var listPaths = path.ToCharArray().ToList();
    int seaLevel = 0;
    for (int i = 0; i < steps; i++)
    {
        if (listPaths[i] == 'U')
        {
            seaLevel++;

            if (seaLevel == 0)
            {
                result++;
            }
        }
        else
        {
            seaLevel--;
        }
    }

    Console.WriteLine(result);
}

