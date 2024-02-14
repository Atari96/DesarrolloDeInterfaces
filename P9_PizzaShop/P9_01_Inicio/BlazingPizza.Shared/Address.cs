using System.ComponentModel.DataAnnotations; // Incorporamos las anotaciones de campos obligatorios y longitudes en el servidor
namespace BlazingPizza;

public class Address
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Debe introducir un nombre.")]
    [MaxLength(100)]
    [Display(Name = "Nombre")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe introducir una dirección de envío.")]
    [MaxLength(100)]
    [Display(Name = "Dirección")]
    public string Line1 { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe introducir un número de teléfono.")]
    [MaxLength(100)]
    [Display(Name = "Teléfono")]
    public string Line2 { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe introducir una ciudad.")]
    [MaxLength(100)]
    [Display(Name = "Ciudad")]
    public string City { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Region { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe introducir un código postal.")]
    [MaxLength(100)]
    [Display(Name = "CódigoPostal")]
    public string PostalCode { get; set; } = string.Empty;
}
