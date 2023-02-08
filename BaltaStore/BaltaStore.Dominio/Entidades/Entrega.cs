using System;

namespace BaltaStore.Dominio.Entidades;

public class Entrega
{
    public DateTime DataCriacao { get; set; }
    public DateTime DataEntregaEstimada { get; set; }
    public string Status { get; set; }
}