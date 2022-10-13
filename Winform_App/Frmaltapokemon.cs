using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_App
{
    public partial class Frmaltapokemon : Form
    {
        private Pokemon pokemon = null;
        public Frmaltapokemon()
        {
            InitializeComponent();
        }
        public Frmaltapokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Pokemonnegocio negocio = new Pokemonnegocio();

            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txtnumero.Text);
                pokemon.Nombre = txtnombre.Text;
                pokemon.Descripcion = txtdescripcion.Text;
                pokemon.UrlImagen = txtUrlimagen.Text;
                pokemon.Tipo = (Elemento)cbotipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbodebilidad.SelectedItem;

                if (pokemon.Id != 0)
                {
                    negocio.modficar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmaltapokemon_Load(object sender, EventArgs e)
        {
            Elementonegocio elementoNegocio = new Elementonegocio();
            try
            {
                cbotipo.DataSource = elementoNegocio.listar();
                cbotipo.ValueMember = "Id";
                cbotipo.DisplayMember = "Descripcion";
                cbodebilidad.DataSource = elementoNegocio.listar();
                cbodebilidad.ValueMember = "Id";
                cbodebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txtnumero.Text = pokemon.Numero.ToString();
                    txtnombre.Text = pokemon.Nombre;
                    txtdescripcion.Text = pokemon.Descripcion;
                    txtUrlimagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cbotipo.SelectedValue = pokemon.Tipo.Id;
                    cbodebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void txtUrlimagen_Leave_1(object sender, EventArgs e)
        {
            cargarImagen(txtUrlimagen.Text);
        }
    }
}




