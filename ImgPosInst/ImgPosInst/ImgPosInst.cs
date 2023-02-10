using ImgPosInst.Helper;
using ImgPosInst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void ImgPosInst_Load(object sender, EventArgs e)
        {
            ConfigValuesDefault();
        }
    }
}
