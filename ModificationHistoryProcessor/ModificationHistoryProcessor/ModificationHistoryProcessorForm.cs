// 10.10.2018 [DaliborLysak] wrong last history line detection #3

using System;
using System.Windows.Forms;

namespace ModificationHistoryProcessor
{
    public partial class ModificationHistoryProcessorForm : Form
    {
        public ModificationHistoryProcessorForm()
        {
            InitializeComponent();

            PropertyGridHelper = new PropertyGridHelper(propertyGridSettings);
            PropertyGridHelper.SetSettings();
            PropertyGridHelper.ResetCategoriesSettings(); // todo file load

            ProcessUX();
        }

        public string[] Data;
        PropertyGridHelper PropertyGridHelper;

        private void ProcessUX()
        {
            var enableFileButtons = listBoxFiles.Items.Count != 0;
            toolStripButtonWriteToFiles.Enabled = enableFileButtons;
            toolStripButtonClearFiles.Enabled = enableFileButtons;
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            Process(DragDropFiles, sender, e);
        }

        private void DragDropFiles(object sender, EventArgs e)
        {
            if (e is DragEventArgs dragEventArgs)
            {
                var data = dragEventArgs.Data.GetData(DataFormats.FileDrop);
                AddFilesToListBox(data as string[], sender as ListBox);
            }
        }

        private void AddFilesToListBox(string[] fileNames, ListBox listBox)
        {
            listBox = listBox ?? listBoxFiles;
            listBox.Items.Clear();
            listBox.Items.AddRange(fileNames);
        }

        private void Process(EventHandler handler, object sender, EventArgs e)
        {
            var control = FindFocusedControl(tabControlMain);
            try
            {
                handler?.Invoke(sender, e);
                ProcessUX();
                // todo error hendling
                // todo logs
                // todo history view
            }
            finally
            {
                if (control.CanFocus)
                {
                    control.Focus();
                }
            }
        }

        private Control FindFocusedControl(Control control)
        {
            ContainerControl container = control as ContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as ContainerControl;
            }

            return control;
        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            Process(DragEnterFiles, sender, e);
        }

        private void DragEnterFiles(object sender, EventArgs e)
        {
            if (e is DragEventArgs dragEventArgs)
            {
                dragEventArgs.Effect = DragDropEffects.All;
            }
        }

        private void ModificationHistoryProcessorForm_Shown(object sender, EventArgs e)
        {
            Process(FormShown, sender, e);
        }

        private void FormShown(object sender, EventArgs e)
        {
            AddFilesToListBox(Data as string[], listBoxFiles);

        }

        private void ModificationHistoryProcessorForm_Load(object sender, EventArgs e)
        {

        }

        private string HistoryLine = String.Empty;

        private void toolStripButtonProcessLine_Click(object sender, EventArgs e)
        {
            Process(ProcessLine, sender, e);
        }

        private void ProcessLine(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                var settings = propertyGridSettings.SelectedObject as ModificationHistorySettings;
                HistoryLine = new ModificationHistoryLine().Get(settings, Clipboard.GetText());
                richTextBoxGet.Text = $"{settings.HeaderInplacePattern.Replace("\\r\\n", Environment.NewLine)}{HistoryLine}";
            }
        }

        private void toolStripButtonWriteToFiles_Click(object sender, EventArgs e)
        {
            Process(WriteToFiles, sender, e);
        }

        private void WriteToFiles(object sender, EventArgs e)
        {
            foreach (string path in listBoxFiles.Items)
            {
                WriteToFile(path);
            }
        }

        private void WriteToFile(string path)
        {
            if (propertyGridSettings.SelectedObject is ModificationHistorySettings settings)
            {
                new ModificationHistoryFile(settings, path, richTextBoxGet.Text).WriteToFile();
            }
        }

        private void ToolStripButtonClearFiles_Click(object sender, EventArgs e)
        {
            Process(ClearFiles, sender, e);
        }

        private void ClearFiles(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
        }
    }
}
