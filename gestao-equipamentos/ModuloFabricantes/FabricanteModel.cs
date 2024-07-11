using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{
    public class FabricanteModel : BaseModel
    {
        public string Nome {  get; set; }
        public DateTime Data {  get; set; }
        public string Fornecedor {  get; set; }

        public override string Validar()
        {
            string error = string.Empty;
            if (string.IsNullOrEmpty(Nome))
            {
                error += "O campo Nome é obrigatorio";
            }
            if (string.IsNullOrEmpty(Fornecedor))
            {
                error += "O campo Fornecedor é obrigatorio";
            }
            if (Data == null)
            {
                error += "O campo Data é obrigatorio";
            }
            return error;
        }

        public override string ToString()
        {
            return $"{Nome}, {Data}, {Fornecedor}";
        }

    }
}
