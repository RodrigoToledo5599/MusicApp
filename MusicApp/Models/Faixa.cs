using System;
using System.Collections.Generic;

namespace MusicApp.Models;

public partial class Faixa
{
    public int FaixaId { get; set; }

    public string Nome { get; set; } = null!;

    public int? AlbumId { get; set; }

    public int TipoMidiaId { get; set; }

    public int? GeneroId { get; set; }

    public string? Compositor { get; set; }

    public int Milissegundos { get; set; }

    public int? Bytes { get; set; }

    public decimal PrecoUnitario { get; set; }

    public virtual Album? Album { get; set; }

    public virtual Genero? Genero { get; set; }

    public virtual ICollection<ItemNotaFiscal> ItemNotaFiscals { get; set; } = new List<ItemNotaFiscal>();

    public virtual TipoMidium TipoMidia { get; set; } = null!;

    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
}
