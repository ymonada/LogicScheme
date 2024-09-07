using Microsoft.AspNetCore.Http.HttpResults;

namespace LogicTranslator.Interfaces;
using Translators;
public interface ITService
{
    List<int> GetT1(); 
    List<int> GetT2();
    void Create(List<string> input);
    
}