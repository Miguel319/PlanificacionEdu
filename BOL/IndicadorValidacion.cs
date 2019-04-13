using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public class IndicadorValidacion
    {
        [DisplayName("Planificación")]
        public Nullable<int> PlanificacionId { get; set; }
        [Required]
        [DisplayName("Acción")]
        public string Accion { get; set; }
        [Required]
        public string Conocimiento { get; set; }
        [Required]
        public string Condiciones { get; set; }
    }

    [MetadataType(typeof(IndicadorValidacion))]
    public partial class Indicador { }
}
