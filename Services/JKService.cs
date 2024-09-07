using LogicTranslator.Interfaces;
using LogicTranslator.Translators;

namespace LogicTranslator.Services;

public class JKService : IJKService
{
    public JKTranslator jk { get; set; }

    public List<int> GetJ1() => jk.J1;

    public List<int> GetJ2() => jk.J2;

    public List<int> GetK1() => jk.K1;

    public List<int> GetK2() => jk.K2;

    public JKService()
    {
        
    }

    public void Create(List<string> input)
    {
        jk = new JKTranslator(input);
    }
}