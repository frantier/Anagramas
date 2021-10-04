using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Palindromos
Nombre del alumno: Pedro Victor Ruvalcaba Novelo
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/

namespace Anagramas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Anagramaprueba : ControllerBase
    {
        [HttpGet]
        public IActionResult Anagrama(string ana1, string ana2)
        {
            bool anagramas;
            var RoT = "";
            if (ana1.Length != ana2.Length)
            {
                anagramas = false;
            }
            else
            {
                char[] l1 = ana1.ToCharArray();
                Array.Sort(l1);
                char[] l2 = ana2.ToCharArray();
                Array.Sort(l2);



                string pal = new string(l1);
                string pal2 = new string(l2);
                if (pal == pal2)
                {
                    anagramas = true;
                }
                else
                {
                    anagramas = false;
                }
            }
            if (anagramas == true)
            {
                RoT = "Las palabras " + ana1 + " y " + ana2 + " Son Anagramas";
            }
            else
            {
                RoT = "Las palabras " + ana1 + " y " + ana2 + " No son Anagramas";
            }
            return Ok(RoT);
        }
    }
}
