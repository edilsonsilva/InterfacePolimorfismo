using System;

namespace Dominio.Interfaces
{
    public interface ICliente
    {
        string Salvar();
        string Apagar();

        string Alterar();

        string[] Pesquisar();

    }
}