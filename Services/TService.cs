using LogicTranslator.Interfaces;
using LogicTranslator.Translators;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LogicTranslator.Services;

public class TService : ITService
{
    public TTranslator tt { get; set; } 

    public TService()
    {

    }

    public void Create(List<string> inputs)
    {
        tt = new TTranslator(inputs);
    }
    public List<int> GetT1() => tt.T1;
    public List<int> GetT2() => tt.T2;

   
}