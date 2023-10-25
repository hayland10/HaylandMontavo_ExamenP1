using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HaylandMontavo_ExamenP1.Models
{
    public class HaylandMontalvo_tabla
    //venta de bebida MOnster
    {
        //como mínimo, 1 campo de tipo int, 1 campo tipo decimal,
        //1 campo tipo string, 1 campo tipo bool y un campo de tipo fecha.
        
        [Required] // 1
        public DateTime hmDateTime { get; set; }
        
        [StringLength(30)] //2
        public string hmNombre { get; set; }
        [Max3] //3
        public int hmNumeroMonsters {  get; set; }
        [Pvp] //4
        public decimal hmPrecio { get; set; }
        [DisplayName("PRIMERA VEZ COMPRANDO?")] //5
        public bool hmPrimeraVez {  get; set; }

        
    }

    public class Max3 : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int valor = (int)value;
            if (valor <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    public class Pvp : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            double valor = (double)value;
            if (valor == 3.50)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }



}
