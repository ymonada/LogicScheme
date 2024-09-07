namespace LogicTranslator.Translators;

public class RSTranslator
{
    public List<int> R1 { get; set; } = new List<int>();
    public List<int> R2 { get; set; } = new List<int>();
    public List<int> S1 { get; set; } = new List<int>();
    public List<int> S2 { get; set; } = new List<int>();

    public RSTranslator(List<string> inputs)
    {
        for (int i = 0; i < inputs.Count; i++)
        {
            if (inputs[i] == "00" || inputs[i] == "01" ||
                inputs[i] == "10" || inputs[i] == "11")
            {
                var chars = inputs[i].ToCharArray();
                R1.Add(TransitionR(chars[0], q1q2Table.Table[i][0]));
                R2.Add(TransitionR(chars[1], q1q2Table.Table[i][1]));
                S1.Add(TransitionS(chars[0], q1q2Table.Table[i][0]));
                S2.Add(TransitionS(chars[1], q1q2Table.Table[i][1]));
            }
            else
            {
                R1.Add(-1);
                R2.Add(-1);
                S1.Add(-1);
                S2.Add(-1);
            }
        }
    }
    private int TransitionR(char input, int Q)
    {
        if (Q == 0)
        {
            if (input == '0')
            {
                return -1;
            }
            return 0;
        }
        if (input == '0')
        {
            return 1;
        }
        return 0;
    }
    private int TransitionS(char input, int Q)
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
            return 0;
        }

        return -1;
    }
}