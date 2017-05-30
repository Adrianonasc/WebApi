using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal salario { get; set; }
        public byte[] Foto { get; set; }

        public Usuario()
        {

        }

    }

}
