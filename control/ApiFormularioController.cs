using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcore.model;
using Newtonsoft.Json;

namespace netcore.control {

    [ApiController]
    [Route ("api/apiFormulario")]
    public class ApiFormularioController : ControllerBase {

        [HttpPut]
        public ActionResult<StatusResponse> registrarFormulario ([FromBody] FormWS pFormulario) {
            StatusResponse sr = new StatusResponse();
            sr.StatusCode="200";
            sr.StatusDesc="Gracias por responder la encuesta";
            return sr;
        }
    }
}