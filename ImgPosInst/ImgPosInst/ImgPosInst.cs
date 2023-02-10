using ImgPosInst.Helper;
using ImgPosInst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgPosInst
{
    public partial class ImgPosInst : Form
    {
        public Config config;

        public ImgPosInst()
        {
            InitializeComponent();
        }

        private void SetInformacoes_OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Changed)
            {
                string logText = File.ReadAllText(e.FullPath);
                if (txtInformacoes.InvokeRequired)
                {
                    txtInformacoes.Invoke(new Action(() => txtInformacoes.AppendText(logText + Environment.NewLine)));
                }
                else
                {
                    txtInformacoes.AppendText(logText + Environment.NewLine);
                }
            }
        }
        private void ConfigComponentes()
        {
            txtHostname.MaxLength = 15;

            SetConfigComboBox(cbBoxUnidades, config.unidades, "Nome", ComboBoxStyle.DropDownList);
            SetConfigComboBox(cbBoxTipoMaquina, config.machineTypeList, "", ComboBoxStyle.DropDownList);
            SetConfigComboBox(cbControleAtivos, config.controleAtivos, "", ComboBoxStyle.DropDownList);

            List<String> listaOpcoes = new List<string>() 
            {
                "Apps do Windows",
                "Plano de Energia",
                "Office 365",
                "Bloquear Loja",
                "Conexão Remota",
                "Serviços"
            };

            ckdListBoxOpcoes.Items.AddRange(listaOpcoes.ToArray());
        }
        private void ConfigValuesDefault()
        {
            //Default Config in start
            StartDefault startDefault = config.startDefault;
            if (startDefault != null)
            {
                //TextBox
                SetTextBoxValue(txtBoxUsuario, startDefault.idColaborador);

                //ComboBox
                SetComboBoxValue(cbBoxUnidades, startDefault.unidade);
                SetComboBoxValue(cbControleAtivos, startDefault.controleAtivo);
                SetComboBoxValue(cbBoxTipoMaquina, startDefault.tipoMaquina);

                //CheckBoxList
                SetCheckedListBoxItem("Apps do Windows", startDefault.appsWindows);
                SetCheckedListBoxItem("Plano de Energia", startDefault.planoEnergia);
                SetCheckedListBoxItem("Office 365", startDefault.office365);
                SetCheckedListBoxItem("Bloquear Loja", startDefault.bloquearLoja);
                SetCheckedListBoxItem("Conexão Remota", startDefault.conexaoRemota);
                SetCheckedListBoxItem("Serviços", startDefault.servicos);
            }
            else
            {
                Logger.Log(Logger.LogType.INFO, "Não foram encontradas configurações padrões a serem carregadas");
            }
        }
        private void SetConfigComboBox(ComboBox comboBox, object fonteDados, string propriedadeExibida, ComboBoxStyle estiloExibicao)
        {
            comboBox.DataSource = fonteDados;
            comboBox.SelectedIndex = 0;
            comboBox.DisplayMember = propriedadeExibida;
            comboBox.DropDownStyle = estiloExibicao;
        }
        private void SetTextBoxValue(TextBox textBox, string value)
        {
            value = value.Trim();

            if (!string.IsNullOrEmpty(value))
            {
                textBox.Text = value;
            }
        }
        private void SetComboBoxValue(ComboBox comboBox, string value)
        {
            value = value.Trim();

            if (!string.IsNullOrEmpty(value))
            {
                int index = comboBox.FindStringExact(value);
                if (index != -1)
                {
                    comboBox.SelectedIndex = index;
                }
            }
        }
        private void SetCheckedListBoxItem(string item, int value)
        {
            if (value >= 0 && value <= 1)
            {
                int index = ckdListBoxOpcoes.FindStringExact(item);

                if (index != -1)
                {
                    if (value == 1)
                    {
                        ckdListBoxOpcoes.SetItemChecked(index, true);
                    }
                    else
                    {
                        ckdListBoxOpcoes.SetItemChecked(index, false);
                    }
                }
            }
        }
        private void DesabilitarBotoes()
        {
            btnIniciar.Enabled = false;
            txtBoxUsuario.Enabled = false;
            mskTxtBoxSenha.Enabled = false;
            cbBoxTipoMaquina.Enabled = false;
            cbBoxUnidades.Enabled = false;
            cbControleAtivos.Enabled = false;
            txtHostname.Enabled = false;
            btnGerarHostname.Enabled = false;
            ckdListBoxOpcoes.Enabled = false;
        }
        private void ImgPosInst_Load(object sender, EventArgs e)
        {
            ConfigComponentes();

            ConfigValuesDefault();

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Logger.GetLogDestination();
            watcher.Filter = Logger.GetLogFilename();
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(SetInformacoes_OnChanged);
            watcher.EnableRaisingEvents = true;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            Logger.Log(Logger.LogType.INFO, "Executando processo...");
        }
    }
}
