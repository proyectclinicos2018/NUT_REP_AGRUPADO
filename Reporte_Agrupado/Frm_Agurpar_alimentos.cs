using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using PreparacionDroga;

namespace Reporte_Agrupado
{
    public partial class Frm_Agurpar_alimentos : Form
    {

        #region Variables

        #region Variables Staticas

        static int cod_tipo_comida = 0;
        static int cod_estado = 0;


        #endregion

        #region Datatables

        DataTable dt_alimentos = new DataTable();

        #endregion

        #region Datos Conexion

        ConectarFalp CnnFalp;
        Configuration Config;
        string User = string.Empty;
        string[] Conexion = { "", "", "" };
        string PCK = "PCK_NUT001I";
        string PCK1 = "PCK_NUT001M";

        #endregion

        #endregion
        public Frm_Agurpar_alimentos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectar();
        }


        #region Cargar


        #region Cargar Conexion

        void conectar()
        {

            if (!(CnnFalp != null))
            {

                ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
                FileMap.ExeConfigFilename = Application.StartupPath + @"\..\WF.config";
                Config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

                CnnFalp = new ConectarFalp(Config.AppSettings.Settings["dbServer"].Value,//ConfigurationManager.AppSettings["dbServer"],
                                           Config.AppSettings.Settings["dbUser"].Value,//ConfigurationManager.AppSettings["dbUser"],
                                           Config.AppSettings.Settings["dbPass"].Value,//ConfigurationManager.AppSettings["dbPass"],
                                           ConectarFalp.TipoBase.Oracle);

                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir(); // abre la conexion

                Conexion[0] = Config.AppSettings.Settings["dbServer"].Value;
                Conexion[1] = Config.AppSettings.Settings["dbUser"].Value;
                Conexion[2] = Config.AppSettings.Settings["dbPass"].Value;
            }



            // this.Text = this.Text + " [Versión: " + Application.ProductVersion + "] [Conectado: " + Conexion[0] + "]";
            //User = ValidaMenu.LeeUsuarioMenu();
            User = "SICI";
            LblUsuario.Text = "Usuario: " + User;
            //LblUsuario.Text = "Usuario: " + User;
        }
        #endregion



        #region Cargar Grilla

        #region Listar Grilla

        protected void Cargar_grilla()
        {

            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            dt_alimentos.Clear();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_CARGAR_ALIMENTOS_AG");
            CnnFalp.ParametroBD("PIN_TIPO_COMIDA", cod_tipo_comida, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_ESTADO", cod_estado, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA", txtfecha.Text, DbType.String, ParameterDirection.Input);
            dt_alimentos.Load(CnnFalp.ExecuteReader());

            if (dt_alimentos.Rows.Count > 0)
            {
                grilla_alimentos.AutoGenerateColumns = false;
                grilla_alimentos.DataSource = dt_alimentos;



            }
            else
            {
                //no trajo datos
                // txtmsg.Text = "";
            }

            CnnFalp.Cerrar();
            //ocultar_grilla_menu();
        }

        #endregion

        #region Agrupar

     


        #endregion

        #region Agregar Imagen

     

        #endregion

        #region Ocultar Columnas


        void ocultar_grilla_turnos()
        {
           /* grilla_turnos.AutoResizeColumns();
            grilla_turnos.Columns["COD_HABITACIONS"].Visible = false;
            grilla_turnos.Columns["COD_CAMAS"].Visible = false;
            grilla_turnos.Columns["COD_TURNOS"].Visible = false;
            grilla_turnos.Columns["VIGENCIA"].Visible = false;
            grilla_turnos.Columns["ID_TURNOS"].Visible = false;*/

            //grilla_menu.Columns["ELIMINAR"].Visible = false;
        }

        #endregion

        #region Ordenar Columnas

        #endregion

        #region Pintar Grilla

        private void grilla_comida_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                e.PaintBackground(e.ClipBounds, false);
                Font drawFont = new Font("Trebuchet MS", 8, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;
                StrFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawImage(Reporte_Agrupado.Properties.Resources.HeaderGV, e.CellBounds);
                e.Graphics.DrawString(grilla_alimentos.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }

        #endregion

        #region Pintar Extraer grilla

        private void grilla_turnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    DialogResult opc = MessageBox.Show("Estimado usuario, Esta seguro de Eliminar la Cama", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opc == DialogResult.Yes)
                    {
                      //  int id_turno = Convert.ToInt32(grilla_turnos.Rows[e.RowIndex].Cells["ID_TURNOS"].Value.ToString());


                    }
                    else
                    {
                        MessageBox.Show("Estimado usuario, El N° Cama no se puede Eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            ocultar_grilla_turnos();
    

        }

        #endregion

        #endregion

        #region Cargar DataTables

        #endregion


        #endregion

        #region Botones

        private void btn_tipo_comida_Click(object sender, EventArgs e)
        {
            txttipo_comida.Text = "";
            Cargar_tipo_comida();

            if (Convert.ToInt32(cod_tipo_comida) == 0)
            {
                txttipo_comida.Enabled = false;
                txttipo_comida.Focus();


            }
            else
            {
                txtestado.Enabled = true;
                btn_estado.Enabled = true;
                txtestado.Focus();

            }
        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            txtestado.Text = "";
            cod_estado = 0;
            Cargar_estado();

            btn_buscar.Focus();
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cod_tipo_comida > 0)
            {
                Cargar_grilla();

            }
            else
            {
                MessageBox.Show("Estimado usuario, El Campo Tipo de Comida se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
        }

  

        #endregion

        #region Metodos

        #region Cargar Tipo menu

        protected void Cargar_tipo_comida()
        {
            Cargar_datos_tipo_comida(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_tipo_comida = Convert.ToInt32(Ayuda.Fields(0));
                txttipo_comida.Text = Ayuda.Fields(1);
            }
           


        }

        private  void Cargar_datos_tipo_comida(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Tipo de Comida";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_COMIDA_AG";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txttipo_comida.Text.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }



        protected void Cargar_estado()
        {
            Cargar_datos_estados(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_estado = Convert.ToInt32(Ayuda.Fields(0));
                txtestado.Text = Ayuda.Fields(1);
            }



        }


        void Cargar_datos_estados(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Estado";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_ESTADO_AG";
            Ayuda.EjecutarSql();

        }

        #endregion



        private void Limpiar()
        {
            cod_tipo_comida = 0;
            txttipo_comida.Text = "";
            cod_estado = 0;
            txtestado.Text = "";
            dt_alimentos.Clear();


        }

        private void CambiarBlanco_TextLeave(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.White;

        }

        private void CambiarColor_TextEnter(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.FromArgb(255, 224, 192);
        }

        #endregion


        #region Validaciones


   




        #endregion

        private void txttipo_comida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
                Cargar_tipo_comida();
                if (e.KeyChar == (char)13)
                {


                    if (Convert.ToInt32(cod_tipo_comida) == 0 || txttipo_comida.Text == "")
                    {
                        txttipo_comida.Focus();}
                      Cargar_grilla();

                    }
                    else
                    {

                    
                        txtestado.Focus();
                    }

            }
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {

                txtestado.Focus();
                
            }
        }

        private void txtestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
                Cargar_estado();
                if (e.KeyChar == (char)13)
                {

                    btn_buscar.Focus();

                }
            }
        }

        private void grilla_alimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (cod_tipo_comida > 0)
            {
                cambiar_estado();
                ReporteParam Reporte = new ReporteParam();
                Reporte.Base_de_Datos = Conexion[0];
                Reporte.User_de_Datos = Conexion[1];
                Reporte.Pass_de_Datos = Conexion[2];


                if(cod_estado==0)
                {
                    cod_estado = 2;
                }


                Reporte.Ruta_Reporte = System.Windows.Forms.Application.StartupPath + @"/../Reportes/NUT001/Rpt_General_Alimentos.rpt";
                Reporte.GenerarParametro("PIN_TIPO_COMIDA", cod_tipo_comida);
                Reporte.GenerarParametro("PIN_ESTADO", Convert.ToInt32(cod_estado));
                Reporte.GenerarParametro("PIN_FECHA", txtfecha.Text);
                Reporte.GenerarParametro("PIN_NOM_TIPO_COMIDA", txttipo_comida.Text);
                FrmImprime Frm = new FrmImprime(Reporte);
                Frm.Show(this);


                Limpiar();
            }

            else
            {
                MessageBox.Show("Estimado usuario, El Campo Tipo de Comida se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
          
        }


        protected void cambiar_estado()
        {


            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_CAMBIAR_EST_ALMIENTO");
            CnnFalp.ParametroBD("PIN_TIPO_COMIDA", cod_tipo_comida, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_ESTADO", cod_estado, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA", txtfecha.Text, DbType.String, ParameterDirection.Input);

            int registro = CnnFalp.ExecuteNonQuery();

            CnnFalp.Cerrar();

       

        }
     

   

       

    

    }
}
