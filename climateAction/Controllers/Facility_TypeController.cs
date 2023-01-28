using climateAction.data;
using climateAction.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Facility_TypeController : ControllerBase
    {
        IGeneric<Facility_Type> generic;
        public Facility_TypeController(IGeneric<Facility_Type> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Facility_Type answers)
        {
            generic.insert(answers);
        }
        [HttpGet]
        public List<Facility_Type> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Facility_Type loadByid(int id)
        {
            return generic.loadId(id);
        }
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
        {
            generic.Delete(id);
        }
        [HttpPost]
        [Route("update")]
        public void update(Facility_Type c)
        {
            generic.update(c);
        }
    }
}
