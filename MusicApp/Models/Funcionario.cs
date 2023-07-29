using System;
using System.Collections.Generic;

namespace MusicApp.Models;

public partial class Funcionario
{
    public int FuncionarioId { get; set; }

    public string Sobrenome { get; set; } = null!;

    public string PrimeiroNome { get; set; } = null!;

    public string? Titulo { get; set; }

    public int? SeReportaA { get; set; }

    public DateTime? DataNascimento { get; set; }

    public DateTime? DataAdmissao { get; set; }

    public string? Endereco { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? Pais { get; set; }

    public string? Cep { get; set; }

    public string? Fone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Funcionario> InverseSeReportaANavigation { get; set; } = new List<Funcionario>();

    public virtual Funcionario? SeReportaANavigation { get; set; }
}
