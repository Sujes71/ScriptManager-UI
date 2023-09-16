using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TaskerManager
{
    public partial class TaskerManager : Form
    {
        public const string scriptsFolderPath = "C:\\AutoHotkey";
        public int page = 1;
        public int totalPages = 1;
        public int startIndex = 0;
        public int endIndex = 10;
        string[] scriptFiles;

        public TaskerManager()
        {
            InitializeComponent();
        }

        private void LoadScripts(object sender, EventArgs e)
        {
            scriptFiles = Directory.GetFiles(scriptsFolderPath, "*.ahk");
            assignStartEndIndex();
            LoadNextScripts(startIndex, endIndex);
        }

        private void ScriptButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string scriptFilePath = (string)clickedButton.Tag;

            if (File.Exists(scriptFilePath))
            {
                System.Diagnostics.Process.Start(scriptFilePath);
            }
            else
            {
                MessageBox.Show("El archivo de script no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string scriptFilePath = (string)clickedButton.Tag;

            if (File.Exists(scriptFilePath))
            {
                // Abre el script en un editor de texto (por ejemplo, Notepad).
                System.Diagnostics.Process.Start("notepad.exe", scriptFilePath);
            }
            else
            {
                MessageBox.Show("El archivo de script no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (page < totalPages)
            {
                page++;
                assignStartEndIndex();
                LoadNextScripts(startIndex, endIndex);

                prevVerification();
                nextVerification();
            }
        }

        public void assignStartEndIndex()
        {
            startIndex = (this.page * 10) - 10;
            endIndex = Math.Min(scriptFiles.Length, startIndex + 10);
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                assignStartEndIndex();
                LoadNextScripts(startIndex, endIndex);

                prevVerification();
                nextVerification();
            }
        }

        private void LoadNextScripts(int startIndex, int endIndex)
        {
            // Limpia cualquier control previamente agregado al TableLayoutPanel.
            scriptsTableLayoutPanel.Controls.Clear();
            scriptFiles = Directory.GetFiles(scriptsFolderPath, "*.ahk");

            int count = startIndex;
            int row_count = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                string scriptFile = scriptFiles[count];
                string scriptName = Path.GetFileNameWithoutExtension(scriptFile);

                // Crear un TextBox en modo de solo lectura para mostrar el nombre del script.
                TextBox scriptTextBox = new TextBox();
                scriptTextBox.Text = scriptName;
                scriptTextBox.Anchor = AnchorStyles.None;
                scriptTextBox.Dock = DockStyle.None;
                scriptTextBox.AutoSize = true;
                scriptTextBox.ReadOnly = true;
                scriptTextBox.DoubleClick += ScriptTextBox_DoubleClick;
                scriptTextBox.Leave += ScriptTextBox_Leave;
                scriptTextBox.KeyDown += ScriptTextBox_KeyDown;
                scriptTextBox.Tag = scriptFile; // Almacena la ruta del archivo.
                scriptTextBox.TextAlign = HorizontalAlignment.Center;

                // Crear un botón de ejecución.
                Button startButton = new Button();
                startButton.Text = "Start";
                startButton.Tag = scriptFile;
                startButton.Click += ScriptButton_Click;
                startButton.Anchor = AnchorStyles.None;
                startButton.Size = new Size(40, 20);
                startButton.Font = new Font(startButton.Font.FontFamily, 6.5f);

                // Crear un botón de edición.
                Button editButton = new Button();
                editButton.Text = "Edit";
                editButton.Tag = scriptsFolderPath + "\\" + scriptTextBox.Text + ".ahk"; // Almacena el TextBox correspondiente.
                editButton.Click += EditButton_Click;
                editButton.Anchor = AnchorStyles.None;
                editButton.Size = new Size(40, 20);
                editButton.Font = new Font(editButton.Font.FontFamily, 6.5f);

                // Crear un botón de Eliminar.
                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Tag = scriptFile;
                deleteButton.Click += DeleteButton_Click;
                deleteButton.Anchor = AnchorStyles.None;
                deleteButton.Size = new Size(40, 20);
                deleteButton.Font = new Font(deleteButton.Font.FontFamily, 6.5f);

                // Agregar el TextBox y los botones al TableLayoutPanel en la fila actual.
                scriptsTableLayoutPanel.Controls.Add(scriptTextBox, 0, row_count);
                scriptsTableLayoutPanel.Controls.Add(startButton, 1, row_count);
                scriptsTableLayoutPanel.Controls.Add(editButton, 2, row_count);
                scriptsTableLayoutPanel.Controls.Add(deleteButton, 3, row_count);

                count++;
                row_count++;
            }

            totalPages = (int)Math.Ceiling((double)(scriptFiles.Length - startIndex) / 10);

            nextVerification();
            prevVerification();
        }

        private void prevVerification()
        {
            PrevButton.Enabled = page > 1;
        }

        private void nextVerification()
        {
            NextButton.Enabled = page < totalPages;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            // Aquí puedes abrir un cuadro de diálogo para que el usuario seleccione la ubicación y el nombre del nuevo script AHK.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Script AHK (*.ahk)|*.ahk";

            // Establece la ruta inicial deseada para guardar el archivo.
            saveFileDialog.InitialDirectory = scriptsFolderPath; // Reemplaza "scriptsFolderPath" con la ruta deseada.

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Puedes abrir el archivo AHK con Notepad usando Process.Start.
                try
                {
                    System.Diagnostics.Process.Start("notepad.exe", filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir Notepad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            nextVerification();
            prevVerification();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadScripts(this, EventArgs.Empty);
        }

        private void ScriptTextBox_DoubleClick(object sender, EventArgs e)
        {
            TextBox scriptTextBox = (TextBox)sender;
            scriptTextBox.ReadOnly = false;
            scriptTextBox.Focus();
            scriptTextBox.SelectAll();
        }

        private void ScriptTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.ReadOnly = true;
            string newName = textBox.Text.Trim();
            string originalFilePath = (string)textBox.Tag;

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("El nombre del script no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = Path.GetFileNameWithoutExtension(originalFilePath);
                textBox.Focus(); // Vuelve a poner el foco en el TextBox después de mostrar el mensaje de error.
                return;
            }

            // Construimos el nuevo nombre de archivo.
            string newFilePath = Path.Combine(Path.GetDirectoryName(originalFilePath), newName + ".ahk");

            try
            {
                if (File.Exists(newFilePath) && newFilePath == originalFilePath)
                {
                    textBox.Text = Path.GetFileNameWithoutExtension(originalFilePath);
                }
                else
                {
                    // Renombramos el archivo en el sistema de archivos.
                    File.Move(originalFilePath, newFilePath);

                    // Actualizamos el nombre original en el TextBox y el Tag.
                    textBox.Text = newName;
                    textBox.Tag = newFilePath;
                    LoadScripts(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores aquí, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al renombrar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = Path.GetFileNameWithoutExtension(originalFilePath);
                textBox.Focus(); // Vuelve a poner el foco en el TextBox después de mostrar el mensaje de error.
            }
        }

        private void ScriptTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.ReadOnly = true;
                string newName = textBox.Text.Trim();
                string originalFilePath = (string)textBox.Tag;

                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("El nombre del script no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = Path.GetFileNameWithoutExtension(originalFilePath);
                    textBox.Focus(); // Vuelve a poner el foco en el TextBox después de mostrar el mensaje de error.
                    return;
                }

                // Construimos el nuevo nombre de archivo.
                string newFilePath = Path.Combine(Path.GetDirectoryName(originalFilePath), newName + ".ahk");

                try
                {
                    if (File.Exists(newFilePath) && newFilePath != originalFilePath)
                    {
                        MessageBox.Show("Ya existe un script con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = Path.GetFileNameWithoutExtension(originalFilePath);
                        textBox.Focus(); // Vuelve a poner el foco en el TextBox después de mostrar el mensaje de error.
                    }
                    else
                    {
                        // Renombramos el archivo en el sistema de archivos.
                        File.Move(originalFilePath, newFilePath);

                        // Actualizamos el nombre original en el TextBox y el Tag.
                        textBox.Text = newName;
                        textBox.Tag = newFilePath;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores aquí, por ejemplo, mostrar un mensaje de error.
                    MessageBox.Show("Error al renombrar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = Path.GetFileNameWithoutExtension(originalFilePath);
                    textBox.Focus(); // Vuelve a poner el foco en el TextBox después de mostrar el mensaje de error.
                }
                LoadScripts(this, EventArgs.Empty);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string scriptFilePath = (string)deleteButton.Tag;

            if (!string.IsNullOrEmpty(scriptFilePath))
            {
                try
                {
                    // Verifica si el archivo existe antes de intentar eliminarlo.
                    if (File.Exists(scriptFilePath))
                    {
                        // Muestra un cuadro de diálogo de confirmación.
                        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este script?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Elimina el archivo.
                            File.Delete(scriptFilePath);

                            // Actualiza la interfaz de usuario para reflejar el cambio.
                            // Puedes eliminar la fila correspondiente del TableLayoutPanel.

                            // Mensaje de éxito.
                            MessageBox.Show("El script ha sido eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Después de eliminar, recarga la lista de scripts para reflejar los cambios.
                            LoadScripts(this, EventArgs.Empty);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo de script no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el script: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo determinar el archivo de script para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
