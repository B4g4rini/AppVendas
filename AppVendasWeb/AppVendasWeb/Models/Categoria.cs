using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        public string CategoriaNome { get; set; }
    }
}
