using System.ComponentModel.DataAnnotations;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class icons
    {
        [Key]
        public int id { get; set; }
        public string icon { get; set; }
        public string link { get; set; }

    }
}