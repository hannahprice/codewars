using System;

public static class Kata
{
    public static string Order(string words)
    {
        if (string.IsNullOrWhiteSpace(words))
        {
            return words;
        }
        else
        {
            string[] individualWords = words.Split(' ');
            string reorderedSentence = null;
            int counter = 1;

            for (int k = 0; k < individualWords.Length; k++)
            {
                for (int i = 0; i < individualWords.Length; i++)
                {
                    bool numberFound = false;
                    for (int j = 0; j < individualWords[i].Length; j++)
                    {
                        if (
                            Char.IsDigit(individualWords[i][j]) &&
                            individualWords[i][j].ToString() ==
                            counter.ToString()
                        )
                        {
                            if (
                                k.ToString() ==
                                (individualWords.Length - 1).ToString()
                            )
                            {
                                reorderedSentence += individualWords[i];
                                numberFound = true;
                                break;
                            }
                            else
                            {
                                reorderedSentence += $"{individualWords[i]} ";
                                counter++;
                                numberFound = true;
                                break;
                            }
                        }
                    }
                    if (numberFound)
                    {
                        numberFound = false;
                        break;
                    }
                }
            }

            return reorderedSentence;
        }
    }
}
