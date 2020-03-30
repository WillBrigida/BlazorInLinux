using System;
using System.Collections.Generic;

namespace TesteWebApi.Models
{
    public partial class PessoaTbl
    {
        public uint Id { get; set; }
        public string Nome { get; set; }
        public short? Idade { get; set; }
    }
}
