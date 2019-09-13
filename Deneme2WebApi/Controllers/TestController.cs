using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Deneme2WebApi.Controllers
{
    public class TestController : Controller
    {
        private IRepository _repository;
        public TestController(IRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Insert([FromQuery] string name)
        {
            Ulker ulker = new Ulker()
            {
                Name = name
            };

            _repository.Insert(ulker);

            return new JsonResult(ulker);
        }

        public JsonResult Update([FromForm] Ulker ulker)
        {
            _repository.Update(ulker);
            return new JsonResult(ulker);
        }

        public JsonResult Delete([FromQuery] int id)
        {
            _repository.Delete(id);
            return new JsonResult(id);
        }

        public JsonResult List()
        {
           var list= _repository.List();
            return new JsonResult(list);
        }
    }
}