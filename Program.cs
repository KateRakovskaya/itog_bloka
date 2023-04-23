void Compare(string[] words, string[] result){
    for (int i = 0; i < words.Length; i++){
        if (words[i].Length > 3) continue;
        else result[i] = words[i];
    }
    for (int j = 0; j < result.Length; j++) Console.Write($"{result[j]} ");
}

Console.WriteLine("Введите массив строк: ");
string[] words = Console.ReadLine().Split(" ").ToArray();
string[] result = new string[words.Length];
Console.WriteLine("Строки с 3 или меньшим количеством символов: ");
Compare(words, result);

