﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
        //public int UsuarioRoId { get; set; }

        public int UsuarioRolID { get; set; }

        public string UsuarioRolDescripcion { get; set; }

        public DataTable Listar() 
        {
            DataTable R = new DataTable();

            //aqui va la programacion 

            return R;
        }
    }
}
