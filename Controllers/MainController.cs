using LogicTranslator.Interfaces;
using LogicTranslator.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogicTranslator.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : ControllerBase
{
    private readonly ITService   _tService;
    private readonly IJKService _jkService;
    private readonly IDService   _dService;
    private readonly IRSService _rsService;

    public MainController(ITService tService
        , IJKService jkService
        , IDService dService
        , IRSService rsService)
    {
        _tService = tService;
        _jkService = jkService;
        _dService = dService;
        _rsService = rsService;
    }
    [HttpPost]
    public IActionResult Index([FromQuery] List<string> inputs, string trigger)
    {  
        if(inputs.Count != 16)
            return BadRequest();
        trigger = trigger.ToLower();
        switch (trigger)
        {
            case "d":
                _dService.Create(inputs);
                var d1 = _dService.GetD1();
                var d2 = _dService.GetD2();
                return Ok(new
                {
                    d1, d2
                    , KarnoD1 = Diagrams.Karno(d1)
                    , KarnoD2 = Diagrams.Karno(d2)
                    , VeychaD1 = Diagrams.Veycha(d1)
                    , VeychaD2 = Diagrams.Veycha(d2)
                });
            case "t":
                _tService.Create(inputs);
                var t1 = _tService.GetT1();
                var t2 = _tService.GetT2();
                return Ok(new
                {
                    t1, t2
                    , KarnoT1 = Diagrams.Karno(t1)
                    , KarnoT2 = Diagrams.Karno(t2)
                    , VeychaT1 = Diagrams.Veycha(t1)
                    , VeychaT2 = Diagrams.Veycha(t2)
                });
            case "jk":
                _jkService.Create(inputs);
                var j1 = _jkService.GetJ1();
                var j2 = _jkService.GetJ2();
                var k1 = _jkService.GetK1();
                var k2 = _jkService.GetK2();
                return Ok(new
                {
                    j1, j2, k1, k2
                    , KarnoJ1 = Diagrams.Karno(j1)
                    , KarnoJ2 = Diagrams.Karno(j2)
                    , KarnoK1 = Diagrams.Karno(k1)
                    , KarnoK2 = Diagrams.Karno(k2)
                    , VeychaJ1 = Diagrams.Veycha(j1)
                    , VeychaJ2 = Diagrams.Veycha(j2)
                    , VeychaK1 = Diagrams.Veycha(k1)
                    , VeychaK2 = Diagrams.Veycha(k2)
                });
            case "rs":
                _rsService.Create(inputs);
                var r1 = _rsService.GetR1();
                var r2 = _rsService.GetR2();
                var s1 = _rsService.GetS1();
                var s2 = _rsService.GetS2();
                return Ok(new
                {
                    r1, r2, s1, s2
                    , KarnoR1 = Diagrams.Karno(r1)
                    , KarnoR2 = Diagrams.Karno(r2)
                    , KarnoS1 = Diagrams.Karno(s1)
                    , KarnoS2 = Diagrams.Karno(s2)
                    , VeychaR1 = Diagrams.Veycha(r1)
                    , VeychaR2 = Diagrams.Veycha(r2)
                    , VeychaS1 = Diagrams.Veycha(s1)
                    , VeychaS2 = Diagrams.Veycha(s2)
                });
            default:
                return BadRequest("Unknown trigger");
        }
    }
}