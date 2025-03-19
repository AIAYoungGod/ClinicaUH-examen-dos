using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CLINICAUH.Data;

namespace CLINICAUH.Views

{
    public partial class PACIENTES : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPacientes();
            }
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            gridPacientes.DataSource = PacientesDAO.ObtenerPacientes();
            gridPacientes.DataBind();
        }
    }
}
