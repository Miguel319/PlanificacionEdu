using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public class AsignaturaValidacion
    {
        [Required]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
    }

    [MetadataType(typeof(AsignaturaValidacion))]
    public partial class Asignatura {}

}
