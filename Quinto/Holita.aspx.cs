using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quinto
{
    public partial class Holita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            futbolfinalEntities futbol = new futbolfinalEntities();
            GridView1.DataSource = (from EquipoFutbolista in futbol.EquiposFutbolistas
                                    select new
                                    {
                                        NombreFutbolista = EquipoFutbolista.Futbolistas.nomFutbolista,
                                        NombreEquipo = EquipoFutbolista.Equipoes.nomEquipo,
                                        FechaInicio = EquipoFutbolista.fechaInicio,
                                        FechaFin = EquipoFutbolista.fechaFin
                                    }).ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            futbolfinalEntities futbol = new futbolfinalEntities();
            EquipoFutbolista eq = new EquipoFutbolista()
            {
                equipoID = 3,
                futbolistaID = 2,
                fechaInicio = DateTime.Now
            };
            futbol.EquiposFutbolistas.Add(eq);
            futbol.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            /*
            futbolfinalEntities futbol = new futbolfinalEntities();
            EquipoFutbolista equipoencontrado = futbol.EquiposFutbolistas.FirstOrDefault(equipo => equipo.equipoID == 2);
            equipoencontrado.Futbolistas.EquiposFutbolistas.FirstOrDefault(futbolista => futbolista.futbolistaID == 1).Equipoes.EquiposFutbolistas.Remove(equipoencontrado);
            futbol.SaveChanges();
            */

            futbolfinalEntities futbol = new futbolfinalEntities();
            futbol.EquiposFutbolistas.Remove(futbol.EquiposFutbolistas.FirstOrDefault(equipo => equipo.equipoID == 2 && equipo.futbolistaID==3));
            futbol.SaveChanges();



            GridView1.DataBind();
        }
    }
}