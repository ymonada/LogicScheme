using LogicTranslator.Translators;

namespace LogicTranslator.Interfaces;

public interface IDService
{
    List<int> GetD1(); 
    List<int> GetD2();
    void Create(List<string> input);
}