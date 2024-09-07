using LogicTranslator.Interfaces;
using LogicTranslator.Translators;
namespace LogicTranslator.Services;

public class RSService : IRSService
{
    public RSTranslator rs { get; set; }

    public List<int> GetR1() => rs.R1;

    public List<int> GetR2() => rs.R2;

    public List<int> GetS1() => rs.S1;

    public List<int> GetS2() => rs.S2;

    public RSService()
    {
        
    }

    public void Create(List<string> input)
    {
        rs = new RSTranslator(input);
    }
}