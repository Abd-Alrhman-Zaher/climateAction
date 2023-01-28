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
    public class FacilityGeneralInfoController : ControllerBase
    {
        IGeneric<FacilityGeneralInfo> generic;
        public FacilityGeneralInfoController(IGeneric<FacilityGeneralInfo> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(FacilityGeneralInfo facilityGeneralInfo)
        {
            generic.insert(facilityGeneralInfo);
        }
        [HttpGet]
        public List<FacilityGeneralInfo> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public FacilityGeneralInfo loadByid(int id)
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
        public void update(FacilityGeneralInfo f)
        {
            generic.update(f);
        }
    }
}
