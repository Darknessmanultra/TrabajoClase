using System.ComponentModel.DataAnnotations;

namespace TrabajoClases.Src.Models
{
    public class Tienda
    {
        [Key]
        public int Id {get;set;} =new Random().Next(1,int.MaxValue);

        public string Nombre {get;set;}
        public string Ciudad {get;set;}

        public List<Producto> productos {get;set;}=new();
    }
}