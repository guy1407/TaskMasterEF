using System.Linq;
using System.Windows.Forms;
using TaskMasterEF.Model;
namespace TaskMasterEF
{
   public partial class frmMain : Form
   {
      #region Variables

      private TaskMasterDBContext tmContext;

      #endregion Variables

      #region Constructor

      public frmMain()
      {

         InitializeComponent();

         tmContext = new TaskMasterDBContext();

         var statuses = tmContext.Statuses.ToList();

         foreach (Status s in statuses)
         {

            cboStatus.Items.Add(s);

         }//foreach

         refreshData();
      }


      #endregion Constructor

      #region Methods

      private void resetGUI()
      {
         cmdUpdateTask.Text = "Update";

         txtTask.Text = string.Empty;

         cboStatus.SelectedIndex = -1;

         dtpDueDate.Value = System.DateTime.Now;
      }
      private void refreshData()
      {

         BindingSource bi = new BindingSource();

         var query = from t in tmContext.Tasks
                     orderby t.DueDate
                     select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate};

         bi.DataSource = query.ToList();

         dgTasks.DataSource = bi;

         dgTasks.Refresh();

         if (dgTasks.Rows.Count>0)
         {
            dgTasks.Columns[1].Width = 500;
            dgTasks.Columns[2].Width = 250;
            dgTasks.Columns[3].Width = 200;
         }
      }//refreshData

      #endregion Methods

      #region Control Events


      private void cmdCreateTask_Click(object sender, System.EventArgs e)
      {
         if ((cboStatus.SelectedItem != null) & (txtTask.Text != string.Empty))
         {
            var newTask = new Model.Task
            {
               Name = txtTask.Text,

               StatusId = (cboStatus.SelectedItem as Model.Status).Id,

               DueDate = dtpDueDate.Value
            };

            tmContext.Tasks.Add(newTask);

            tmContext.SaveChanges();

            refreshData();

            MessageBox.Show(this, "Task created.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else
         {
            MessageBox.Show(this, "Please make sure all data has been entered.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void cmdUpdateTask_Click(object sender, System.EventArgs e)
      {
         if (cmdUpdateTask.Text == "Update")
         {
            txtTask.Text = dgTasks.SelectedRows[0].Cells[1].Value.ToString();

            cboStatus.SelectedIndex = cboStatus.FindString(dgTasks.SelectedRows[0].Cells[2].Value.ToString());

            dtpDueDate.Value = (System.DateTime)dgTasks.SelectedRows[0].Cells[3].Value;

            cmdUpdateTask.Text = "Save";
         }
         else if (cmdUpdateTask.Text == "Save")
         {
            Task t = null; 

            t = tmContext.Tasks.Find(dgTasks.SelectedRows[0].Cells[0].Value);

            t.Name = txtTask.Text;

            t.StatusId = (cboStatus.SelectedItem as Model.Status).Id;

            t.DueDate = dtpDueDate.Value;

            tmContext.SaveChanges();

            refreshData();

            restGUI();
         }
      }

      private void cmdDeleteTask_Click(object sender, System.EventArgs e)
      {

         Task t = null;

         if (dgTasks.SelectedRows.Count ==0)
         {
            MessageBox.Show(this, "Please make sure you selected a row.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
         else if (dgTasks.SelectedRows.Count > 1)
         {
            MessageBox.Show(this, "Please make sure you selected a single row.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
         else
         {
            t = tmContext.Tasks.Find(dgTasks.SelectedRows[0].Cells[0].Value);

            if (t != null)
            {
               tmContext.Tasks.Remove(t);

               tmContext.SaveChanges();
            }
            else
            {
               MessageBox.Show(this, "Task not found :(", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            refreshData();
         }
         
      }

      private void cmdCancelTask_Click(object sender, System.EventArgs e)
      {
         resetGUI();
      }

      #endregion Control Events

   }//class 
}//namespace
