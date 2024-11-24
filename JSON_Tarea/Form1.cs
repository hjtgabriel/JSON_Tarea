using System.ComponentModel;
using System.Text.Json;

namespace JSON_Tarea
{
    public partial class Form1 : Form
    {
        private string ruta = @"C:\Users\DELL 5590\source\repos\JSON_Tarea\estudiante.json";
        private BindingList<Estudiantes> estudiantes;
        public Form1()
        {
            InitializeComponent();
            estudiantes = new BindingList<Estudiantes>();
            dataGridView1.DataSource = estudiantes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarnet.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtedad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCarnet.Text, out int carnet))
            {
                MessageBox.Show("El número de carnet debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtedad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Estudiantes nuevoEstudiante = new Estudiantes
            {
                Carnet = carnet,
                Nombre = txtnombre.Text,
                Edad = edad
            };

            estudiantes.Add(nuevoEstudiante);
            GuardarEnJSON(estudiantes, ruta);
            LimpiarCampos();

            MessageBox.Show("Se guardó correctamente.");
        }
        private void LimpiarCampos()
        {
            txtCarnet.Clear();
            txtnombre.Clear();
            txtedad.Clear();
        }
        private void GuardarEnJSON(BindingList<Estudiantes> estudiantes, string ruta)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(estudiantes, opciones);
            File.WriteAllText(ruta, json);
        }
        private BindingList<Estudiantes> LeerDesdeJSON(string ruta)
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                return JsonSerializer.Deserialize<BindingList<Estudiantes>>(json);
            }
            return new BindingList<Estudiantes>();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                estudiantes = LeerDesdeJSON(ruta);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = estudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnElimanar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                estudiantes.RemoveAt(index);
                GuardarEnJSON(estudiantes, ruta); // Guarda los cambios en JSON
                MessageBox.Show("Elemento eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }


