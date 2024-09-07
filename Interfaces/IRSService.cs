namespace LogicTranslator.Interfaces;

public interface IRSService
{
    List<int> GetR1(); 
    List<int> GetR2();
    List<int> GetS1(); 
    List<int> GetS2();
    void Create(List<string> input);
}