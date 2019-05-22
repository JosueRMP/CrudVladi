using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alumno.Models.ViewModels
{
	public class TablaViewModel
	{
		public int Id { get; set; }
		[Required]
		[Display(Name = "Nombre")]
		[StringLength(50)]
		public string NombreAlumno { get; set; }
		[Required]
		[Display(Name = "Apellido")]
		[StringLength(50)]
		public string ApellidoAlumno { get; set; }
		[Required]
		[Display(Name = "Calificaiones")]
		public int CalificacionAlumno { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Fecha")]
		[DisplayFormat(DataFormatString ="{0:yyy-MM-dd}",ApplyFormatInEditMode =true)]
		public DateTime Fecha { get; set; }
	}
}