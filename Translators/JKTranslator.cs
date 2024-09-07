namespace LogicTranslator.Translators;

public class JKTranslator
{
    public List<int> J1 { get; set; } = new List<int>();
    public List<int> J2 { get; set; } = new List<int>();
    public List<int> K1 { get; set; } = new List<int>();
    public List<int> K2 { get; set; } = new List<int>();

    public JKTranslator(List<string> inputs)
    {
        for (int i = 0; i < inputs.Count; i++)
        {
            if (inputs[i] == "00" || inputs[i] == "01" ||
                inputs[i] == "10" || inputs[i] == "11")
            {
                var chars = inputs[i].ToCharArray();
                J1.Add(TransitionJ(chars[0], q1q2Table.Table[i][0]));
                J2.Add(TransitionJ(chars[1], q1q2Table.Table[i][1]));
                K1.Add(TransitionK(chars[0], q1q2Table.Table[i][0]));
                K2.Add(TransitionK(chars[1], q1q2Table.Table[i][1]));
            }
            else
            {
                J1.Add(-1);
                J2.Add(-1);
                K1.Add(-1);
                K2.Add(-1);
            }
        }
    }
    private int TransitionJ(char input, int Q)
    {
        if (Q == 0)
        {
            if (input == '0')
            {
                return 0;
            }
            return 1;
        }
        return -1;
    }
    private int TransitionK(char input, int Q)
    {
        if (Q == 0)
        {
            return -1;
        }

        if (input == '0')
        {
            return 1;
        }

        return 0;
    }
}