namespace BlazingPizza;

/// <summary>
/// Controla los parametros de longitus y latitud que van a ser utilizados para la ubicacion del pedido y del cliente.
/// </summary>

public class LatLong
{
    public LatLong()
    {
    }

    public LatLong(double latitude, double longitude) : this()
    {
        Latitude = 40.416775;
        Longitude = -3.70379;
    }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public static LatLong Interpolate(LatLong start, LatLong end, double proportion)
    {
        // The Earth is flat, right? So no need for spherical interpolation.
        return new LatLong(
                start.Latitude + (end.Latitude - start.Latitude) * proportion,
                start.Longitude + (end.Longitude - start.Longitude) * proportion);
    }
}