using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alumno.Models;
using Alumno.Models.ViewModels;

namespace Alumno.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
			List<ListTablaViewModels> lst;
			using (AlumnoEntities db=new AlumnoEntities())
			{
				 lst = (from d in db.Tabla
						   select new ListTablaViewModels
						   {
							   Id = d.Id,
							   NombreAlumno = d.NombreAlumno,
							   ApellidoAlumno = d.ApellidoAlumno,
							   CalificacionAlumno = d.CalificacionAlumno,
							   Fecha = d.Fecha
						   }).ToList(); 
			}
			
            return View(lst);
        }

		public ActionResult Nuevo()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Nuevo(TablaViewModel model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					using (AlumnoEntities db=new AlumnoEntities())
					{
						var oTabla = new Tabla();
						oTabla.ApellidoAlumno = model.ApellidoAlumno;
						oTabla.NombreAlumno = model.NombreAlumno;
						oTabla.CalificacionAlumno = model.CalificacionAlumno;
						oTabla.Fecha = model.Fecha;

						db.Tabla.Add(oTabla);
						db.SaveChanges();

					}
					return Redirect("~/Tabla/");
				}
				return View(model);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public ActionResult Editar(int Id)
		{
			TablaViewModel model = new TablaViewModel();
			using (AlumnoEntities db=new AlumnoEntities())
			{
				var oTabla = db.Tabla.Find(Id);
				model.NombreAlumno = oTabla.NombreAlumno;
				model.ApellidoAlumno = oTabla.ApellidoAlumno;
				model.CalificacionAlumno = oTabla.CalificacionAlumno;
				model.Fecha = oTabla.Fecha;
				model.Id = oTabla.Id;
			}
			return View(model);
		}
		[HttpPost]
		public ActionResult Editar(TablaViewModel model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					using (AlumnoEntities db = new AlumnoEntities())
					{
						var oTabla = db.Tabla.Find(model.Id);
						oTabla.ApellidoAlumno = model.ApellidoAlumno;
						oTabla.NombreAlumno = model.NombreAlumno;
						oTabla.CalificacionAlumno = model.CalificacionAlumno;
						oTabla.Fecha = model.Fecha;

						db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
						db.SaveChanges();

					}
					return Redirect("~/Tabla/");
				}
				return View(model);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		[HttpGet]
		public ActionResult Eliminar(int Id)
		{
			
			using (AlumnoEntities db = new AlumnoEntities())
			{
				var oTabla = db.Tabla.Find(Id);
				db.Tabla.Remove(oTabla);
				db.SaveChanges();
			}
			return Redirect("~/Tabla/");
		}
	}
}