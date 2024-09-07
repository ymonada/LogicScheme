using LogicTranslator.Interfaces;
using LogicTranslator.Translators;

namespace LogicTranslator.Services;

public class DService : IDService
{
    public DTranslator dd { get; set; } 

    public DService()
    {

    }

    public void Create(List<string> inputs)
    {
        dd = new DTranslator(inputs);
    }
    public List<int> GetD1() => dd.D1;
    public List<int> GetD2() => dd.D2;
}