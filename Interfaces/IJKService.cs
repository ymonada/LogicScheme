namespace LogicTranslator.Interfaces;

public interface IJKService
{
    List<int> GetJ1(); 
    List<int> GetJ2();
    List<int> GetK1(); 
    List<int> GetK2();
    void Create(List<string> input);
}