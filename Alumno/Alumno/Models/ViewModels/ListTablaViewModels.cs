using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alumno.Models.ViewModels
{
	public class ListTablaViewModels
	{
		public int Id { get; set; }
		public string NombreAlumno { get; set; }
		public string ApellidoAlumno { get; set; }
		public int CalificacionAlumno { get; set; }
		public DateTime Fecha { get; set; }
	}
}