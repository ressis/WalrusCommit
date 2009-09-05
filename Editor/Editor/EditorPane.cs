using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Editor
{
	public partial class EditorPane : Form
	{
		private string filename;
		private Dictionary<string, string> reasons;
		public EditorPane()
		{
			InitializeComponent();
			GetFileName();
			InitializeReasonsComboBox();
			InitializeEditorPane();
		}

		private void InitializeReasonsComboBox()
		{
			System.Xml.XmlDocument reasonsXML = new System.Xml.XmlDocument();
			reasonsXML.Load(Application.StartupPath + "\\" + "WalrusReasons.xml");
			reasons = new Dictionary<string, string>();
			foreach (System.Xml.XmlElement reason in reasonsXML["Reasons"])
			{
				reasons[reason.InnerText.Trim()] = reason.Name;
			}
			Reason.ComboBox.DataSource = new List<string>(reasons.Keys);
		}
		private void InitializeEditorPane()
		{
			EditArea.Text = System.IO.File.ReadAllText(filename);
		}
		private void GetFileName()
		{
			try
			{
				filename = Environment.GetCommandLineArgs()[1];
			}
			catch (IndexOutOfRangeException)
			{
				MessageBox.Show("This editor is designed to work with source control tools. You must specify a file to edit.");
				Environment.Exit(1);
			}
		}

		private void SaveAndCommit_Click(object sender, EventArgs e)
		{
			string reasonText;
			try
			{
				reasonText = reasons[Reason.Text];
			}
			catch (KeyNotFoundException)
			{
				if (MessageBox.Show("You have set a custom Reason, are you sure you wish to proceed?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				else
					reasonText = Reason.Text;
			}

			if (Issue.Text == string.Empty)
				if (MessageBox.Show("You have not set an Issue; are you sure you wish to proceed?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
			System.IO.StreamWriter writer = new System.IO.StreamWriter(filename);
			writer.WriteLine(reasonText + ": " + Issue.Text);
			writer.Write(EditArea.Text);
			writer.Close();
			Environment.Exit(0);
		}
	}
}
