using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public class PlanificacionValidacion
    {
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Asignatura { get; set; }
        [Required]
        public string Curso { get; set; }
        [Required]
        [DisplayName("Año escolar")]
        public int AnioEscolar { get; set; }
        [Required]
        public string Tema { get; set; }
        [Required]
        [DisplayName("Competencias")]
        public string CompetenciasFundamentales { get; set; }
        [Required]
        [DisplayName("Específicos")]
        public string CompetenciasEspecificas { get; set; }
        [Required]
        public string Escenario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime Fecha { get; set; }
        [DisplayName("Método")]
        public Nullable<int> MetodoId { get; set; }
        [DisplayName("Sistematización")]
        public Nullable<int> SistematizacionId { get; set; }
        [DisplayName("Evaluación")]
        public Nullable<int> TrabajoId { get; set; }
    }

    [MetadataType(typeof(PlanificacionValidacion))]
    public partial class Planificacion {}
}
