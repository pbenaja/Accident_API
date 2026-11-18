using AccidentAPI.models;
using AccidentAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace AccidentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidentController : ControllerBase
    {
        private readonly IAccidentService service;
        public AccidentController(IAccidentService service)
        {
            this.service = service;
        }
        [HttpPost]
        public ActionResult<AccidentResponse> EnregistrerAccident(AccidentRequest request)
        {
            var accident = new Accident(request.description, request.lieu, request.date, request.type, request.gravite);
            var acc = service.Enregistrer(accident);
            var response = new AccidentResponse(acc.Description, acc.Lieu, acc.Date, acc.Type1, acc.Gravite1);
            return Created($"/api/accident/{acc.Id}", response);
        }
        [HttpGet]
        public ActionResult<IEnumerable<AccidentResponse>> GetAll()
        {
            List<AccidentResponse> result = new List<AccidentResponse>();
            foreach (var acc in service.GetAll())
            {
                result.Add(new AccidentResponse(acc.Description, acc.Lieu, acc.Date, acc.Type1, acc.Gravite1));
            }
            return Ok(result);
        }
    }
}
