using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea_Lab3.ArbolBinario;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Tarea_Lab3.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostFileBase)
        {/*
            string FilePath = "";
            if (postedFile != null)             {                 string path = Server.MapPath("~/uploads/");                 if (!Directory.Exists(path))                 {                     Directory.CreateDirectory(path);                 }                 FilePath = path + Path.GetFileName(postedFile.FileName);                 string extension = Path.GetExtension(postedFile.FileName);                 postedFile.SaveAs(FilePath);                  string csvData = System.IO.File.ReadAllText(FilePath);                 foreach (string row in csvData.Split('#'))                 {
                    if (!string.IsNullOrEmpty(row))
                    {
                        trabajador.Add(new Trabajador
                        {
                            Cod_empleado = row.Split(',')[0],
                            Nombre = row.Split(',')[1],
                            Total_horas_trabajadas = Convert.ToDouble(row.Split(',')[2]),
                            EstadiaOficina = row.Split(',')[3],
                            Salario = Convert.ToDouble(row.Split(',')[4])
                        });
                    }                 }
                */

            }

        public class HttpPostFileBase
        {
        }
    }
}
