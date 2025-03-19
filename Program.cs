using System;
using System.Dynamic;

public class Cassette{

    //ATRIBUTOS 
    public string NombreAlbum {get; set;}
    public string NombreArtista {get; set;}
    public int  NumEdicion {get; set;}
    public double Duracion {get; set;}

    //METODOS

    public void MostrarInformacionCassette()
    {
        Console.WriteLine($"Cassette:{NombreAlbum} - Artista:{NombreArtista}");
        Console.WriteLine($"Duración:{Duracion}");
    }
    public void ReproducirCassette()
    {
        Console.WriteLine($"Estas Escuchando{NombreAlbum}");
    }

}

public class Fanzine{
    //ATRIBUTOS

    public string Titulo {get;set;}
    public string  NombreAutor {get; set;}
    public int NumPaginas{get; set;}
    public DateTime FechaPublicacion{get; set;}

    //METODOS

        public void MostrarInformacionFanzine()
    {
        Console.WriteLine($"Fanzine:{Titulo} - Autor:{NombreAutor}");
        Console.WriteLine($"Fecha Publicacion:{FechaPublicacion}");
        Console.WriteLine($"Número de páginas {NumPaginas}");
    }
        public void LeerFanzine()
        {
            Console.WriteLine($"Estas Leyendo el {Titulo}");
        }

        public void IrAPagina(int pagina)
{
    if (pagina > 0 && pagina <= NumPaginas)  
    {
        Console.WriteLine($"Estás en la página {pagina} de '{Titulo}'.");
    }
    else
    {
        Console.WriteLine($"¡Error! El fanzine solo tiene {NumPaginas} páginas. No existe la página {pagina}.");
    }
}

    }


