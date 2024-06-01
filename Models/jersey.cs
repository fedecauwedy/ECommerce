using System.ComponentModel.DataAnnotations;


// vecchio namespace
// namespace RazorPagesMovie.Models;


// nuovo namespace
namespace Cau.Tumidei._5h.ECommerce.Models;


public class Jersey
{
    public int? Id { get; set; }
    public string? Squadra { get; set; }
    public string? Tipologia { get; set; }
    public string? Taglia { get; set; }
    public double? Prezzo { get; set; }
}
