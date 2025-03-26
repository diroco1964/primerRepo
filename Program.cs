using System;
using System.Dynamic;

public class FormatoMusical{

    //ATRIBUTOS 
    public string tipo{get; set;}
    public string nombreAlbum {get; set;}
    public string nombreArtista {get; set;}
    public int  numEdicion {get; set;}
    public double duracion {get; set;}

    //METODOS

    public void MostrarInformacionEdicion()
    {
        Console.WriteLine($"Esta edición vienen en formato{tipo}");
        Console.WriteLine($"Album:{nombreAlbum} - Artista:{nombreArtista}");
        Console.WriteLine($"Duración:{duracion}");
    }
    public void ReproducirFormato()
    {
        Console.WriteLine($"Estas Escuchando{nombreAlbum}");
    }

}

public class Fanzine{
    //ATRIBUTOS

    public string titulo {get;set;}
    public string  nombreAutor {get; set;}
    public int numPaginas{get; set;}
    public DateTime fechaPublicacion{get; set;}

    //METODOS

        public void MostrarInformacionFanzine()
    {
        Console.WriteLine($"Fanzine:{titulo} - Autor:{nombreAutor}");
        Console.WriteLine($"Fecha Publicacion:{fechaPublicacion}");
        Console.WriteLine($"Número de páginas {numPaginas}");
    }
        public void LeerFanzine()
        {
            Console.WriteLine($"Estas Leyendo el {titulo}");
        }

        public void IrAPagina(int pagina)
{
    if (pagina > 0 && pagina <= numPaginas)  
    {
        Console.WriteLine($"Estás en la página {pagina} de '{titulo}'.");
    }
    else
    {
        Console.WriteLine($"¡Error! El fanzine solo tiene {numPaginas} páginas. No existe la página {pagina}.");
    }
}

    }


