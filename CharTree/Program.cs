
CharTree();

void CharTree()
{
    string str = "abccddbeea"; //abccddbeea
    char[] distinctCharList = str.ToCharArray().Distinct().ToArray();

    Dictionary<char, int> dict = new Dictionary<char, int>();

    foreach (var ch in distinctCharList)
    {
        dict.Add(ch, 0);
    }

    for (int i = 0; i < distinctCharList.Length; i++)
    {
        var splittedStr = str.Split(distinctCharList[i]);

        if (splittedStr[1].Any())
        {
            foreach (var item in splittedStr[1].ToCharArray().Distinct().ToArray())
            {
                dict[item]++;
            }
        }
    }

    foreach (KeyValuePair<char, int> entry in dict)
    {
        string prefix = "";

        for (int i = 0; i < entry.Value; i++)
        {
            prefix += "-";
        }

        Console.WriteLine(prefix + entry.Key);
    }
}


//Belli bir formata göre hazırlanmış aşağıdaki stringden standard outputta aşağıdaki çıktıyı üreten bir
//kod
//Varsayımlar ve kurallar:
//•Verilen stringte her harf 2 defa kullanılır ve aynı 2 harf arasında kalan harfler child harflerdir.
//•Verilen stringin daima düzgün formatta verildiğini kabul ediyoruz. String formatını kontrol edilmesine
//gerek yok.
//•Program istenilen dilde yazılabilir (java, C#, plsql, js vb.).
//•Standart outputta ağaç yapısını gösterecek şekilde bir çıktı bekliyoruz.
//•Verilen string sonsuz derinlikte bir ağaç olabilir.
//Örnek 1:
//Input:
//abccbdeeda
//Output:
//a
//- b
//--c
//- d
//--e
//Örnek 2:
//Input:
//abccddbeea
//Output:
//a
//- b
//--c
//--d
//- e