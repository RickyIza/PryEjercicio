﻿using BEUEjercicio;
using BEUEjercicio.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApiEscolastico.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class MaquinariaController : ApiController
    {
        public IHttpActionResult Post(Maquinaria Maquinaria)
        {
            try
            {
                MaquinariaBLL.Create(Maquinaria);
                return Content(HttpStatusCode.Created, "Maquinaria creado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Get()
        {
            try
            {
                List<Maquinaria> todos = MaquinariaBLL.List();
                return Content(HttpStatusCode.OK, todos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        public IHttpActionResult Put(Maquinaria Maquinaria)
        {
            try
            {
                MaquinariaBLL.Update(Maquinaria);
                return Content(HttpStatusCode.OK, "Maquinaria actualizado correctamente");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        public IHttpActionResult Get(int id)
        {
            try
            {
                Maquinaria result = MaquinariaBLL.Get(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Content(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                MaquinariaBLL.Delete(id);
                return Ok("Maquinaria eliminado correctamente");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}