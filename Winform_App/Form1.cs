using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Winform_App
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvpokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                Pbxpokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                Pbxpokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void cargar()
        {
            Pokemonnegocio negocio = new Pokemonnegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvpokemons.DataSource = listaPokemon;
                dgvpokemons.Columns["UrlImagen"].Visible = false;
                dgvpokemons.Columns["Id"].Visible = false;
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Pokemonnegocio negocio = new Pokemonnegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvpokemons.DataSource = listaPokemon;
                dgvpokemons.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvpokemons_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvpokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvpokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Frmaltapokemon alta = new Frmaltapokemon();
            alta.ShowDialog();
            cargar();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargar();
            cbocampo.Items.Add("Número");
            cbocampo.Items.Add("Nombre");
            cbocampo.Items.Add("Descripción");
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvpokemons.CurrentRow.DataBoundItem;

            Frmaltapokemon modificar = new Frmaltapokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void ocultarColumnas()
        {
            dgvpokemons.Columns["UrlImagen"].Visible = false;
            dgvpokemons.Columns["Id"].Visible = false;
        }


        private void eliminar(bool logico = false)
        {
            Pokemonnegocio negocio = new Pokemonnegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvpokemons.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtfiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaPokemon;
            }

            dgvpokemons.DataSource = null;
            dgvpokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbocampo.SelectedItem.ToString();
            if (opcion == "Número")
            {
                cbocriterio.Items.Clear();
                cbocriterio.Items.Add("Mayor a");
                cbocriterio.Items.Add("Menor a");
                cbocriterio.Items.Add("Igual a");
            }
            else
            {
                cbocriterio.Items.Clear();
                cbocriterio.Items.Add("Comienza con");
                cbocriterio.Items.Add("Termina con");
                cbocriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (cbocampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cbocriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cbocampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(txtfiltroavanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtfiltroavanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }



        private void btnfiltro_Click(object sender, EventArgs e)
        {
            Pokemonnegocio negocio = new Pokemonnegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbocampo.SelectedItem.ToString();
                string criterio = cbocriterio.SelectedItem.ToString();
                string filtro = txtfiltroavanzado.Text;
                dgvpokemons.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}


    
    


    

