using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BOL
{
    public class EmailUnico : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string emailValor = (string) value;

            PlanificacionDbEntities db = new PlanificacionDbEntities();
            int conteo = db.Usuario.Count(x => x.Email == emailValor);

            if(conteo != 0)
                return new ValidationResult("Ya hay existe un usuario con este correo electrónico");
            return ValidationResult.Success;
        }
    }

    public class CedulaUnica : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cedulaValor = (string)value;

            PlanificacionDbEntities db = new PlanificacionDbEntities();
            int conteo = db.Usuario.Count(x => x.Cedula == cedulaValor);

            if (conteo != 0)
                return new ValidationResult("Ya hay existe un usuario con esta cédula en el sistema");
            return ValidationResult.Success;
        }
    }
    public class UsuarioValidacion
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [CedulaUnica]
        [DisplayName("Cédula")]
        public string Cedula { get; set; }
        [DisplayName("Nivel")]
        public Nullable<int> NivelId { get; set; }
        [DisplayName("Institución")]
        public string Centro { get; set; }
        [EmailAddress]
        [EmailUnico]
        public string Email { get; set; }
        [DisplayName("Contraseña")]
        public string Contra { get; set; }

        public virtual Nivel Nivel { get; set; }
    }

    [MetadataType(typeof(UsuarioValidacion))]
    public partial class Usuario { }
}
