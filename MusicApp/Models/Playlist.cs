using System;
using System.Collections.Generic;

namespace MusicApp.Models;

public partial class Playlist
{
    public int PlaylistId { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Faixa> Faixas { get; set; } = new List<Faixa>();
}
