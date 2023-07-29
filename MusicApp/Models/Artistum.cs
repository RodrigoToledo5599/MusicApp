using System;
using System.Collections.Generic;

namespace MusicApp.Models;

public partial class Artistum
{
    public int ArtistaId { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
}
