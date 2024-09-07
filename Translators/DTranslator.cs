namespace LogicTranslator.Translators;

public class DTranslator
{
    public List<int> D1 { get; set; }  = new List<int>();
    public List<int> D2 { get; set; }  = new List<int>();

    public DTranslator(List<string> inputs)
    {
        for (int i = 0; i < inputs.Count; i++)
        {
            if (inputs[i] == "00" || inputs[i] == "01" ||
                inputs[i] == "10" || inputs[i] == "11")
            {
                var chars = inputs[i].ToCharArray();
                D1.Add(int.Parse(chars[0].ToString()));
                D2.Add(int.Parse(chars[1].ToString()));
            }
            else
            {
                D1.Add(-1);
                D2.Add(-1);
            }
        }
    }
}