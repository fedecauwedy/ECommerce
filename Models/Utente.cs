using System.ComponentModel.DataAnnotations;
namespace Cau.Tumidei._5h.ECommerce.Models;

public class Utente 
{
    public int Id {get; set; }
    public DateTime? Datanascita {get; set; }   
    public string? Email {get; set;}
    public string? NomeUtente {get; set; }
    public string? Psw {get; set;}  
} 
