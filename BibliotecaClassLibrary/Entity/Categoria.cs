﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassLibrary.Entity
{
    public class Categoria
    {
        #region Campos
        private int idCategoria;
        private string nome;
        #endregion

        #region Campos
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion
    }
}
