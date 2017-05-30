using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public IQueryable<Usuario> GetUsuarios()
        {
            return dataSouceUsuarios(10);
        }

        public IQueryable<Usuario> dataSouceUsuarios(int quantidade)
        {
            var usuarios = new List<Usuario>();
            Byte[] b = new Byte[100];
            Random rnd = new Random();
            for (int i = 0 ; i <= quantidade; i++)
            {
                rnd.NextBytes(b);
                usuarios.Add(new Usuario() {
                    Id = i,
                    Nome = $"Nome usuario {i}",
                    salario = Convert.ToDecimal(i*100),
                    Idade = i,
                    Foto = b
                });
                b = new Byte[100];
            }
            return usuarios.AsQueryable();
        }

        // GET: api/Usuarios/5
        public IHttpActionResult GetUsuario(int quantidadeUsuarios)
        {
            var usuarios = dataSouceUsuarios(quantidadeUsuarios);
            if (usuarios.Count() == 0)
                return NotFound();
            return Ok(usuarios);
        }
    }
}