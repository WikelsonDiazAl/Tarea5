using System;
using System.Collections.Generic;

public class Plataforma
{
    public int PlataformaID { get; set; }

    public string Nombre { get; set; } = "";

    public string Estado { get; set; } = "";

    public List<Videojuegos> Videojuegos { get; set; } = new List<Videojuegos>();
}

public class Videojuegos
{
    public int VideojuegosId { get; set; }

    public string Nombre { get; set; } = "";

    public string Desarrollador { get; set; } = "";

    public int PlataformaID { get; set; }

    public Plataforma Plataforma { get; set; }

    public string Genero { get; set; } = "";

    public DateTime Fecha_Lanzamiento { get; set; }

    public string Imagen_Portada { get; set; } = "";

    public string Descripcion { get; set; } = "";

    public List<Personajes_Videojuegos> Personajes { get; set; } = new List<Personajes_Videojuegos>();
}

public class Personajes_Videojuegos
{
    public int Personajes_VideojuegosId { get; set; }

    public string Nombre { get; set; } = "";

    public string Alias { get; set; } = "";

    public string Rol { get; set; } = "";

    public string Habilidad_Especial { get; set; } = "";

    public string Arma_Favorita { get; set; } = "";

    public int Nivel_Poder { get; set; }

    public string Imagen_Personaje { get; set; } = "";

    public int VideojuegoId { get; set; }

    public Videojuegos Videojuego { get; set; }
}
