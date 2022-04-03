using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PagMemory
{
    /*Instituto Tecnológico de Puebla
     * Materia: Arquitectura de Computadoras
     * @author: Valeria Alvarado Palma
    */

    public partial class FSimulador : Form
    {
        private int n = 0;
        public FSimulador()
        {
            InitializeComponent();
        }
        
        private void bAgregarP_Click(object sender, EventArgs e)
        {
            String procesoAgrega = TbProceso1.Text; //Text Box de Proceso 1 (Para agregar)
            int tamañoAgrega;
            //se convierte un string (tamaño textbox) a int
            if (!Int32.TryParse(tBTamaño.Text, out tamañoAgrega))
            {
                tamañoAgrega = 0;
            }
            //se establece un limite al DGV
            int contador = dGVMemory.Rows.Count;
            if (contador < 22)
            {
                if (tamañoAgrega < 22)
                {
                    //ciclo para que se agregen los procesos a DGV 
                    for (int i = 0; i < tamañoAgrega; i++)
                    {
                        //agrega un nuevo renglon
                        int n = dGVMemory.Rows.Add();
                        //Colocamos info
                        dGVMemory.Rows[n].Cells[0].Value = TbProceso1.Text;
                        dGVMemory.Rows[n].Cells[1].Value = tBTamaño.Text;
                    }

                    //en caso de que los text box sean vacios hacer... 
                    if ((procesoAgrega == "") || (tBTamaño.Text == ""))
                    {
                        MessageBox.Show("DEBES LLENAR TODOS LOS DATOS!");
                    }
                    else //Sí no son vacíos entonces...
                    {
                        //se agrega la información al List Box
                        LbEjecucion.Items.Add(procesoAgrega);
                        //Limpiamos 
                        TbProceso1.Text = "";
                        tBTamaño.Text = "";
                        TbProceso1.Focus();
                    }
                }
                else
                {
                    //Limpiamos 
                    TbProceso1.Text = "";
                    tBTamaño.Text = "";
                    TbProceso1.Focus();

                    //en caso de llenarse el DGV...
                    MessageBox.Show("Memoria llena");
                    //se agrega proceso a ESPERA
                    LbEspera.Items.Add(procesoAgrega);
                    LbEspera2.Items.Add(tamañoAgrega);
                }
            }
            else //si se excede el tamaño de la memoria...
            {
                //Limpiamos 
                TbProceso1.Text = "";
                tBTamaño.Text = "";
                TbProceso1.Focus();

                //en caso de llenarse el DGV...
                MessageBox.Show("Memoria llena");
                //se agrega proceso a ESPERA
                LbEspera.Items.Add(procesoAgrega);
                LbEspera2.Items.Add(tamañoAgrega);
                
            }
        }
        private void bFinalizarP_Click(object sender, EventArgs e)
        {
            //si la fila NO está vacía
            if (n != -1)
            {
                string texto = (string)dGVMemory.Rows[n].Cells[0].Value;
                for (int i = dGVMemory.Rows.Count - 1; i >= 0; i--)
                {
                    if (texto.Equals((string)dGVMemory.Rows[i].Cells[0].Value))
                    {
                        dGVMemory.Rows.RemoveAt(i); //se elimina la fila del DGV
                    }
                }

                //recorrer :D
                for (int i = 0; i < LbEjecucion.Items.Count; i++)
                {
                    if (texto.Equals(LbEjecucion.Items[i].ToString()))
                    {
                        //Se elimina proceso del List Box "En Ejecución"
                        LbEjecucion.Items.RemoveAt(i);
                        lblInforma.Text = ""; //Limpia la información del label que está en el grupo de terminar
                        //Se agrega el proceso que se eliminó en el ListBox de finalizados
                        LbFinalizado.Items.Add(texto);
                    }

                }
            }

            String procesoAgrega = LbEspera.Items[0].ToString(); //Se selecciona el primer elemento
            int tamañoAgrega;
            //se convierte un string (tamaño de LbEspera) a int
            if (!Int32.TryParse(LbEspera2.Items[0].ToString(), out tamañoAgrega))
            {
                tamañoAgrega = 0;
            }

            int contador = dGVMemory.Rows.Count;
            if (contador < 22) //se establece un limite al DGV
            {
                LbEjecucion.Items.Add(procesoAgrega); //agregamos le proceso a ejecución
                //eliminamos elementos de las ListBox de espera
                LbEspera.Items.Remove(procesoAgrega); 
                LbEspera2.Items.Remove(tamañoAgrega);
                //ciclo para que se agregen los procesos a DGV 
                for (int i = 0; i < tamañoAgrega; i++)
                {
                    //agrega un nuevo renglon
                    int n = dGVMemory.Rows.Add();
                    //Colocamos info
                    dGVMemory.Rows[n].Cells[0].Value = procesoAgrega;
                    dGVMemory.Rows[n].Cells[1].Value = tamañoAgrega;
                }
            }
            else
            {
                //Limpiamos 
                TbProceso1.Text = "";
                tBTamaño.Text = "";
                TbProceso1.Focus();

                //en caso de llenarse el DGV...
                MessageBox.Show("Memoria llena");
                //se agrega proceso a ESPERA
                LbEspera.Items.Add(procesoAgrega);
                LbEspera2.Items.Add(tamañoAgrega);
            }

        }
       
        private void dGVMemory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                lblInforma.Text = (string)dGVMemory.Rows[n].Cells[0].Value;

            }
        }
        private void salirbutton_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra la aplicación
        }

        //No le haga caso a esto, no afecta al programa
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void dGVMemory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FSimulador_Load(object sender, EventArgs e)
        {

        }
    }
}
