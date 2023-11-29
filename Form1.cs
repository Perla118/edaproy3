using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edaproy3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        //para ocultar los menu de los panels
        private void customizeDesign()
        {

            menuColas.Visible = false;
            Menumatrices.Visible = false;
            menuListas.Visible = false;
            MenuPilas.Visible = false;
        }
        //Para ocultar el submenu
        private void hideSubMenu()
        {
            if (Menumatrices.Visible == true)
                Menumatrices.Visible = false;

            if (menuColas.Visible == true)
                menuColas.Visible = false;

            if (menuListas.Visible == true)
                menuListas.Visible = false;

            if (MenuPilas.Visible == true)
                MenuPilas.Visible = false;
        }
        //metodo vacio para mostrar el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cambiar el color del fondo del formulario
            //this.BackColor = Color.White;
            // Cambiar el color de la barra de título
            //this.FormBorderStyle = FormBorderStyle.FixedSingle; // Cambia el estilo del borde
            //this.ControlBox = true; // Oculta los botones de cerrar, minimizar y maximizar
            //this.Text = ""; // Puedes eliminar el texto de la barra de título si lo deseas
        }

        private void BotonMatriz_Click(object sender, EventArgs e)
        {
            showSubMenu(Menumatrices);
        }

        private void GuardarMatriz_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EliminarMatriz_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EditarMatriz_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void MostrarMatriz_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void OrdenarMatriz_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BuscarMatriz_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Listas_Click(object sender, EventArgs e)
        {
            showSubMenu(menuListas);
        }

        private void GuardarLista_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EliminarLista_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EditarLista_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void MostrarLista_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void OrdenarLista_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BuscarLista_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Pilas_Click(object sender, EventArgs e)
        {
            showSubMenu(MenuPilas);
        }

        private void GuardarPila_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EliminarPila_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EditarPila_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void MostrarPila_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void OrdenarPila_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BuscarPila_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Colas_Click(object sender, EventArgs e)
        {
            showSubMenu(menuColas);
        }

        private void GuardarColas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EliminarColas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void EditarColas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void MostrarColas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void OrdenarColas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BuscarColas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm=null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            Paneldelformulario.Controls.Add(childForm);
            Paneldelformulario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
