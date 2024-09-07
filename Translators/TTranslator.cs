namespace LogicTranslator.Translators;

public class TTranslator
{
    public List<int> T1 { get; set; } = new List<int>();
    public List<int> T2 { get; set; } = new List<int>();

    public TTranslator(List<string> inputs)
    {
        for (int i = 0; i < inputs.Count; i++)
        {
            if (inputs[i] == "00" || inputs[i] == "01" ||
                inputs[i] == "10" || inputs[i] == "11")
            {
                var chars = inputs[i].ToCharArray();
                T1.Add(Transition(chars[0], q1q2Table.Table[i][0]));
                T2.Add(Transition(chars[1], q1q2Table.Table[i][1]));
            }
            else
            {
                T1.Add(-1);
                T2.Add(-1);
            }
        }
    }
    private int Transition(char input, int Q)
    {
        if (Q == 0)
        {
            if (input == '0')
            {
                return 0;
            }
            return 1;
        }

        if (input == '0')
        {
            return 1;
        }

        return 0;
    }
}
