using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eniac.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Sexo Sexo { get; set; }

        public Cliente()
        {
               
        
        }

        public Cliente(int id, string nome, string email, DateTime dataNascimento, EstadoCivil estadoCivil, Sexo sexo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            EstadoCivil = estadoCivil;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return string.Format($"Id: {Id} Nome: {Nome} E-mail: {Email} Data de Nascimento: {DataNascimento} Sexo: {Sexo} Estado Civíl: {EstadoCivil} ");
        }

    }
}
