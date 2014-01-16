using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Gerente de operaciones");
            comboBox1.Items.Add("Gerente de tecnología");
            comboBox1.Items.Add("Gerente de marketing");
            comboBox1.Items.Add("Gerente de RRHH");
            comboBox1.Items.Add("Gerente de finanzas");
            comboBox1.Items.Add("Gerente de proyectos");
            comboBox1.Items.Add("Jefe de proyectos");
            comboBox1.Items.Add("Jefe de sucursal");
            comboBox1.Items.Add("Encargado de adquisiciones");
            comboBox1.Items.Add("Jefe de prevención de riesgos");
            comboBox1.Items.Add("Jefe de personal");
            comboBox1.Items.Add("Jefe de ventas");
            comboBox1.Items.Add("Programador");
            comboBox1.Items.Add("Vendedor");
            comboBox1.Items.Add("Testeador");
            comboBox1.Items.Add("Diseñador");
            comboBox1.Items.Add("Contador");
            comboBox1.Items.Add("Secretaria");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux= "";
            if (comboBox1.Text.Contains("Gerente de operaciones"))
                aux = ("Habilidades:\r\n mandatario \r\n futurista\r\n competitivo\r\n emprendedor\r\n\r\n Competencias:\r\n Administración\r\n procesos\r\n ofimática\r\n tecnología.");
            textBox1.Text = aux;
            if(comboBox1.Text.Contains("Gerente de tecnología"))
                textBox1.Text = "Habilidades: \r\nmandatario\r\nfuturista\r\nemprendedor\r\n\r\nCompetencias: \r\nAdministración\r\n procesos\r\n ofimática\r\n tecnología.";
            if(comboBox1.Text.Contains("Gerente de marketing"))
                textBox1.Text = "Habilidades: \r\nmandatario\r\n futurista\r\n emprendedor\r\n\r\n Competencias: Administración\r\n procesos\r\n ofimática\r\n tecnología\r\n publicidad.";
            if(comboBox1.Text.Contains("Gerente de RRHH"))
                textBox1.Text = "Habilidades\r\n mandatario\r\n futurista\r\n emprendedor \r\n\r\nCompetencias:\r\n Administración\r\n procesos\r\nofimática\r\n gestión de personal.";
            if(comboBox1.Text.Contains("Gerente de finanzas"))
                textBox1.Text = "Habilidades:\r\n mandatario, responsable\r\n emprendedor\r\n\r\nCompetencias:\r\n Administración\r\n procesos\r\n ofimática\r\n comercio internacional\r\n contabilidad.";
            if(comboBox1.Text.Contains("Gerente de proyectos"))
                textBox1.Text = "Habilidades:\r\n mandatario\r\n disciplinado\r\n emprendedor\r\n\r\n Competencias:\r\n Administración\r\n procesos\r\n ofimática\r\n tecnología\r\n gestión de proyectos.";
            if(comboBox1.Text.Contains("Jefe de proyectos"))
                textBox1.Text = "Habilidades:\r\n analítico\r\n competitivo\r\n emprendedor\r\n\r\n Competencias:\r\n Gestión de proyectos\r\n gestión de personal\r\n tecnología.";
            if(comboBox1.Text.Contains("Jefe de sucursal"))
                textBox1.Text = "Habilidades:\r\n disciplinado\r\n emprendedor\r\n comunicador\r\n\r\nCompetencias:\r\n Ventas\r\n administración\r\n gestión de personal.";
            if(comboBox1.Text.Contains("Encargado de adquisiciones"))
                textBox1.Text = "Habilidades:\r\n futurista\r\n comunicador\r\n flexible\r\n\r\n Competencias:\r\n Tecnología\r\n comercio internacional\r\n gestión de proyectos.";
            if(comboBox1.Text.Contains("Jefe de prevención de riesgos"))
                textBox1.Text = "Habilidades:\r\n comunicador\r\n mandatario\r\n disciplinado\r\n\r\nCompetencias:\r\n Prevención de riesgos\r\n seguridad\r\n gestión de personal.";
            if(comboBox1.Text.Contains("Jefe de personal"))
                textBox1.Text = "Habilidades:\r\n desarrollador\r\n competitivo\r\n mandatario\r\n\r\n Competencias:\r\n Gestión de personal\r\n administración.";
            if(comboBox1.Text.Contains("Jefe de ventas"))
                textBox1.Text = "Habilidades:\r\n desarrollador\r\n emprendedor\r\n mandatario\r\n\r\n Competencias\r\n: Ventas\r\n relaciones públicas\r\n gestión de personal.";
            if(comboBox1.Text.Contains("Programador"))
                textBox1.Text = "Habilidades:\r\n responsable\r\n disciplinado\r\n armónico\r\n\r\nCompetencias:\r\n Programación\r\n modelamiento de datos\r\n ofimática.";
            if(comboBox1.Text.Contains("Vendedor"))
                textBox1.Text = "Habilidades:\r\n empático\r\n competitivo\r\n comunicador\r\n\r\n Competencias:\r\n Relaciones públicas\r\n ventas. ";
            if(comboBox1.Text.Contains("Testeador"))
                textBox1.Text = "Habilidades:\r\n armónico\r\n flexible\r\n futurista\r\n\r\nCompetencias:\r\n Testing\r\n programación\r\n ofimática.";
            if(comboBox1.Text.Contains("Diseñador"))
                textBox1.Text = "Habilidades:\r\n empático\r\n futurista\r\n responsable\r\n\r\nCompetencias:\r\n Diseño web\r\n diseño gráfico.";
            if(comboBox1.Text.Contains("Contador"))
                textBox1.Text = "Habilidades:\r\n responsable\r\n disciplinado\r\n analítico\r\n\r\n Competencias:\r\n Contabilidad\r\n ofimática.";
            if(comboBox1.Text.Contains("Secretaria"))
                textBox1.Text = "Habilidades:\r\n armónico\r\n flexible\r\n empático\r\n\r\n Competencias:\r\n Mecanografía\r\n comunicaciones\r\n ofimática.";
        }
    }
}
