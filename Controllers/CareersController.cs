using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UnicFormatos.Models;

namespace UnicFormatos.Controllers {

    [Route ("test")]
    public class CareersController : Controller {

        [HttpPut]
        public IActionResult PutdotInscripcion ([FromBody] Inscripcion data) {
            System.Console.WriteLine ($"Received data!");
            if (data == null) return BadRequest ();
            using (var context = new CareerContext ()) {
                context.Add<Inscripcion> (data);
            }
            return Ok ();
        }

        [HttpGet]
        public Inscripcion GetInscripcion () {
            return Inscripcion.FromJson (json);
        }

        private const string json = "{\"matricula\":\"308633184\",\"licenciatura\":\"Ingeniería en Computación\",\"semestre\":\"2010-1\",\"generacion\":\"2010\",\"personal\":{\"nombre\":\"Omar\",\"apPaterno\":\"Rodríguez\",\"apMaterno\":\"Pérez\",\"nacionalidad\":\"Mexicana\",\"lugarNacimiento\":\"Cuernavac, Morelos\",\"contacto\":{\"telParticular\":\"9189538\",\"telCelular\":\"7771481259\",\"email\":\"omar.rodpe@gmail.com\"},\"fechaNacimiento\":{\"year\":1991,\"month\":12,\"day\":23}},\"domicilio\":{\"calle\":\"Av. Los Cizos\",\"numero\":\"2\",\"colonia\":\"Acapatzingo\",\"municipio\":\"Cuernavaca\",\"poblacion\":\"Acapatzingo\",\"cp\":\"62440\",\"estado\":\"Morelos\"},\"padre\":{\"contacto\":{\"telParticular\":\"na\",\"telCelular\":\"na\",\"email\":\"na\"},\"parentesco\":\"padre\",\"nombre\":\"Alfonso Rodríguez Nájera\",\"domicilio\":\"na\",\"empresa\":\"na\"},\"madre\":{\"contacto\":{\"telParticular\":\"3189538\",\"telCelular\":\"7771234526\",\"email\":\"dpbrito@hotmail.com\"},\"parentesco\":\"madre\",\"nombre\":\"Diana Pérez Brito\",\"domicilio\":\"Av. Los Cizos #2\",\"empresa\":\"UNIC\"},\"emergencia\":{\"contacto\":{\"contacto\":{\"telParticular\":\"3189538\",\"telCelular\":\"7771234526\",\"email\":\"\"},\"parentesco\":\"madre\",\"nombre\":\"Diana Pérez Brito\",\"domicilio\":\"Av. Los Cizos 2\",\"empresa\":\"UNIC\"},\"tipoSangre\":\"O+\"},\"trabajo\":{\"nombre\":\"WASD\",\"telefono\":\"na\",\"domicilio\":{\"calle\":\"no me acuerdo\",\"numero\":0,\"colonia\":\"Napoles\",\"municipio\":\"Ciudad de México\"}}}";

        /*

                [HttpGet]
                public IEnumerable<Career> GetAll () {
                    var list = new List<Career> ();
                    list.Add (new Career { Name = "Ingeniería Industrial" });
                    return list;
                }

                [HttpGet ("{name}")]
                public Career Get (string name) {
                    //TODO: Implement Realistic Implementation
                    return new Career { Name = name };
                }

                [HttpPost]
                public IActionResult Post([FromBody] Career model)
                {
                    //TODO: Implement Realistic Implementation
                    
                    return Created("", null);
                }

                [HttpPut]
                public IActionResult Put([FromBody] Career model)
                {
                    //TODO: Implement Realistic Implementation
                    return Ok();
                }

                [HttpDelete]
                public IActionResult Delete(Career id)
                {
                    //TODO: Implement Realistic Implementation
                    return Ok();
                }
                */
    }
}