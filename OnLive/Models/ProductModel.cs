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
    public class ProductModel
    {
        //Fields
        private int id;
        private string name;
        private int price;
        private int live;
        private int paid;
        private int id_customer;
        //Properties - Validations
        //Validations
        [DisplayName("Identificador de Producto")]
        public int Id 
            { 
                get => id; 
                set => id = value; 
            }
        //Validations
        [DisplayName("Nombre del Producto")]
        [Required(ErrorMessage = "Nombre del producto vacio :s Ingresar nombre!.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El nombre del producto debe tener al menos 4 letras :s")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "El campo solo puede tener letras y numeros.")]
        public string Name 
            { 
                get => name; 
                set => name = value; 
            }
        //Validations
        [DisplayName("Precio")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo solo puede tener numeros.")]
        public int Price 
            { 
                get => price; 
                set => price = value; 
            }
        //Validations
        [DisplayName("Numero de Live")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo solo puede tener numeros.")]
        public int Live 
            { 
                get => live; 
                set => live = value; 
            }
        //Validations
        [DisplayName("Pagado (palomear si esta pagado)")]
        [RegularExpression("^[0-1]+$")]
        public int Paid 
            { 
                get => paid; 
                set => paid = value; 
            }
        //Validations
        [DisplayName("Identificador de Cliente")]
        public int Id_customer 
            { 
                get => id_customer; 
                set => id_customer = value; 
            }
    }
}
