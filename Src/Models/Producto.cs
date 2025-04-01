using System.ComponentModel.DataAnnotations;

namespace TrabajoClases.Src.Models
{
    public class Producto
    {
        [Key]
        public int Id {get;set;} =new Random().Next(1,int.MaxValue);
        public int TiendaId {get;set;}
        public string Nombre {get;set;}
        public int Precio {get;set;}
    }
}