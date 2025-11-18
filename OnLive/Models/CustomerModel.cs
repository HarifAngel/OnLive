using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Configuration;

namespace OnLive.Models
{
    public class CustomerModel
    {
        //Fields
        private int id;
        private string name;
        //Properties - Validations
        //Validations
        [DisplayName("Identificador de Cliente")]
        public int Id { get => id; set => id = value; }
        //Validations
        [DisplayName("Nombre del Cliente")]
        [Required(ErrorMessage ="Nombre de cliente vacio :s Ingresar nombre!.")]
        [StringLength(50,MinimumLength =4, ErrorMessage ="El nombre debe tener al menos 4 letras :s")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo solo puede tener letras.")]
        public string Name { get => name; set => name = value; }
    }
}
