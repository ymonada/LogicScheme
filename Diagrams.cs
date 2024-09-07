namespace LogicTranslator;

public static class Diagrams
{
    public static List<List<int>> Veycha(List<int> input)
    {
        return new List<List<int>>()
        {
             new List<int>(){ input[12], input[13], input[9],  input[8]}
           , new List<int>(){ input[14], input[15], input[11], input[10]}
           , new List<int>(){ input[5],  input[7],  input[3],  input[2]}
           , new List<int>(){ input[4],  input[5],  input[1],  input[0]}
        };
    }
    public static List<List<int>> Karno(List<int> input)
    {
        return new List<List<int>>()
        {
              new List<int>(){ input[0],  input[1],  input[4],  input[3]}
            , new List<int>(){ input[5],  input[6],  input[8],  input[7]}
            , new List<int>(){ input[12], input[13], input[15], input[14]}
            , new List<int>(){ input[8],  input[9],  input[11], input[10]}
        };
    }
}