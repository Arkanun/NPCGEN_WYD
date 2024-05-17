using Microsoft.VisualBasic;
using System;
using static System.Windows.Forms.AxHost;

namespace NPCGEN_WYD
{
    public partial class Form1 : Form
    {

        private string MinuteGenerate;
        private string MaxNumMob;
        private string MinGroup;
        private string MaxGroup;
        private string selectedLeader;
        private string selectedFollower;
        private string RouteType;
        private string Formation;
        private string StartX;
        private string StartY;
        private string StartRange;
        private string StartWait;
        private string DestX;
        private string DestY;
        private string DestRange;
        private string DestWait;


        public Form1()
        {
            InitializeComponent();
            LoadFilesIntoComboBoxes();

        }

        private void LoadFilesIntoComboBoxes()
        {
            try
            {
                var files = Directory.GetFiles("npc"); // Ajuste o filtro se necessário
                foreach (var file in files)
                {
                    comboBoxLeader.Items.Add(Path.GetFileName(file));
                    comboBoxFollower.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os arquivos: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MinuteGenerate = textBox1.Text;

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MaxGroup = textBox4.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MaxNumMob = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MinGroup = textBox3.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLeader.SelectedIndex != -1)
            {
                selectedLeader = comboBoxLeader.SelectedItem.ToString();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFollower.SelectedIndex != -1)
            {
                selectedFollower = comboBoxFollower.SelectedItem.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            RouteType = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Formation = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            StartX = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            StartY = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            StartRange = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            StartWait = textBox10.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            DestX = textBox11.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            DestY = textBox12.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            DestRange = textBox13.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            DestWait = textBox14.Text;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Coletar os dados
            string minuteGenerate = textBox1.Text;  // Asumindo que você tenha variáveis de controle com esses nomes
            string maxNumMob = textBox2.Text;
            string minGroup = textBox3.Text;
            string maxGroup = textBox4.Text;
            string leader = comboBoxLeader.SelectedItem?.ToString();  // Usando ?.ToString() para evitar NullReferenceException
            string follower = comboBoxFollower.SelectedItem?.ToString();
            string routeType = textBox5.Text;
            string formation = textBox6.Text;
            string startX = textBox7.Text;
            string startY = textBox8.Text;
            string startRange = textBox9.Text;
            string startWait = textBox10.Text;
            string destX = textBox11.Text;
            string destY = textBox12.Text;
            string destRange = textBox13.Text;
            string destWait = textBox14.Text;

            // Criar a string formatada para salvar
            string contentToSave = $@"
// ********************************************
        #	[   0]
        MinuteGenerate: {minuteGenerate}
        MaxNumMob: {maxNumMob}
        MinGroup: {minGroup}
        MaxGroup: {maxGroup}
        Leader: {leader}
        Follower: {follower}
        RouteType: {routeType}
        Formation: {formation}
        StartX: {startX}
        StartY: {startY}
        StartRange: {startRange}
        StartWait: {startWait}
        DestX: {destX}
        DestY: {destY}
        DestRange: {destRange}
        DestWait: {destWait}
        ";
            // Escolher o caminho do arquivo - Salvamento de teste
            // string filePath = "Output.txt";  // Ou escolha outro nome ou caminho de arquivo conforme necessário

            string[] filePaths = { "NPCGener.new.txt", "NPCGener.txt" };

            // Adicionar conteúdo a cada arquivo
            foreach (var filePath in filePaths)
            {
                try
                {
                    // Verifica se o arquivo existe, cria se não existir
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Close(); // Cria e fecha para liberar o arquivo
                    }

                    // Adiciona o texto no final do arquivo
                    File.AppendAllText(filePath, contentToSave);
                    MessageBox.Show($"Dados adicionados com sucesso em {filePath}!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar dados ao arquivo {filePath}: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] filePaths = { "NPCGener.new.txt", "NPCGener.txt" };

            foreach (var filePath in filePaths)
            {
                try
                {
                    int lastNumber = GetLastNumberFromFile(filePath);
                    int newNumber = lastNumber + 1;

                    string contentToSave = FormatContentToSave(newNumber);

                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Close();
                    }

                    File.AppendAllText(filePath, contentToSave);
                    MessageBox.Show($"Dados adicionados com sucesso em {filePath}!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar dados ao arquivo {filePath}: {ex.Message}");
                }
            }
        }

        private int GetLastNumberFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string lastLineWithNumber = lines.LastOrDefault(line => line.Contains("#\t["));

                if (lastLineWithNumber != null)
                {
                    int startIndex = lastLineWithNumber.IndexOf("[") + 1;
                    int endIndex = lastLineWithNumber.IndexOf("]");
                    string numberStr = lastLineWithNumber.Substring(startIndex, endIndex - startIndex).Trim();

                    if (int.TryParse(numberStr, out int lastNumber))
                    {
                        return lastNumber;
                    }
                }
            }

            return 0; // Se nenhum número for encontrado ou o arquivo não existir, comece do 0
        }


        private string FormatContentToSave(int number)
        {
            return $@"
// ********************************************
#	[{number}]
    MinuteGenerate: {textBox1.Text}
    MaxNumMob: {textBox2.Text}
    MinGroup: {textBox3.Text}
    MaxGroup: {textBox4.Text}
    Leader: {comboBoxLeader.SelectedItem?.ToString() ?? "N/A"}
    Follower: {comboBoxFollower.SelectedItem?.ToString() ?? "N/A"}
    RouteType: {textBox5.Text}
    Formation: {textBox6.Text}
    StartX: {textBox7.Text}
    StartY: {textBox8.Text}
    StartRange: {textBox9.Text}
    StartWait: {textBox10.Text}
    DestX: {textBox11.Text}
    DestY: {textBox12.Text}
    DestRange: {textBox13.Text}
    DestWait: {textBox14.Text}
";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
