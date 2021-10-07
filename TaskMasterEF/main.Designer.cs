namespace TaskMasterEF
{
   partial class frmMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dgTasks = new System.Windows.Forms.DataGridView();
         this.fraTask = new System.Windows.Forms.GroupBox();
         this.lblDueDate = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lblTask = new System.Windows.Forms.Label();
         this.cmdDeleteTask = new System.Windows.Forms.Button();
         this.cmdCancelTask = new System.Windows.Forms.Button();
         this.cmdUpdateTask = new System.Windows.Forms.Button();
         this.cmdCreateTask = new System.Windows.Forms.Button();
         this.cboStatus = new System.Windows.Forms.ComboBox();
         this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
         this.txtTask = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgTasks)).BeginInit();
         this.fraTask.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgTasks
         // 
         this.dgTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgTasks.Location = new System.Drawing.Point(26, 238);
         this.dgTasks.MultiSelect = false;
         this.dgTasks.Name = "dgTasks";
         this.dgTasks.RowTemplate.Height = 24;
         this.dgTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgTasks.Size = new System.Drawing.Size(1150, 250);
         this.dgTasks.TabIndex = 0;
         // 
         // fraTask
         // 
         this.fraTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.fraTask.Controls.Add(this.lblDueDate);
         this.fraTask.Controls.Add(this.label2);
         this.fraTask.Controls.Add(this.lblTask);
         this.fraTask.Controls.Add(this.cmdDeleteTask);
         this.fraTask.Controls.Add(this.cmdCancelTask);
         this.fraTask.Controls.Add(this.cmdUpdateTask);
         this.fraTask.Controls.Add(this.cmdCreateTask);
         this.fraTask.Controls.Add(this.cboStatus);
         this.fraTask.Controls.Add(this.dtpDueDate);
         this.fraTask.Controls.Add(this.txtTask);
         this.fraTask.Location = new System.Drawing.Point(26, 12);
         this.fraTask.Name = "fraTask";
         this.fraTask.Size = new System.Drawing.Size(1150, 204);
         this.fraTask.TabIndex = 1;
         this.fraTask.TabStop = false;
         this.fraTask.Text = "Task";
         // 
         // lblDueDate
         // 
         this.lblDueDate.AutoSize = true;
         this.lblDueDate.Location = new System.Drawing.Point(675, 57);
         this.lblDueDate.Name = "lblDueDate";
         this.lblDueDate.Size = new System.Drawing.Size(118, 23);
         this.lblDueDate.TabIndex = 9;
         this.lblDueDate.Text = "Due date:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(28, 116);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(94, 23);
         this.label2.TabIndex = 8;
         this.label2.Text = "Status:";
         // 
         // lblTask
         // 
         this.lblTask.AutoSize = true;
         this.lblTask.Location = new System.Drawing.Point(28, 57);
         this.lblTask.Name = "lblTask";
         this.lblTask.Size = new System.Drawing.Size(70, 23);
         this.lblTask.TabIndex = 7;
         this.lblTask.Text = "Task:";
         // 
         // cmdDeleteTask
         // 
         this.cmdDeleteTask.Location = new System.Drawing.Point(638, 112);
         this.cmdDeleteTask.Name = "cmdDeleteTask";
         this.cmdDeleteTask.Size = new System.Drawing.Size(122, 30);
         this.cmdDeleteTask.TabIndex = 6;
         this.cmdDeleteTask.Text = "Delete";
         this.cmdDeleteTask.UseVisualStyleBackColor = true;
         this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
         // 
         // cmdCancelTask
         // 
         this.cmdCancelTask.Location = new System.Drawing.Point(510, 159);
         this.cmdCancelTask.Name = "cmdCancelTask";
         this.cmdCancelTask.Size = new System.Drawing.Size(122, 30);
         this.cmdCancelTask.TabIndex = 5;
         this.cmdCancelTask.Text = "Cancel";
         this.cmdCancelTask.UseVisualStyleBackColor = true;
         this.cmdCancelTask.Click += new System.EventHandler(this.cmdCancelTask_Click);
         // 
         // cmdUpdateTask
         // 
         this.cmdUpdateTask.Location = new System.Drawing.Point(510, 112);
         this.cmdUpdateTask.Name = "cmdUpdateTask";
         this.cmdUpdateTask.Size = new System.Drawing.Size(122, 30);
         this.cmdUpdateTask.TabIndex = 4;
         this.cmdUpdateTask.Text = "Update";
         this.cmdUpdateTask.UseVisualStyleBackColor = true;
         this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
         // 
         // cmdCreateTask
         // 
         this.cmdCreateTask.Location = new System.Drawing.Point(382, 112);
         this.cmdCreateTask.Name = "cmdCreateTask";
         this.cmdCreateTask.Size = new System.Drawing.Size(122, 30);
         this.cmdCreateTask.TabIndex = 3;
         this.cmdCreateTask.Text = "Create";
         this.cmdCreateTask.UseVisualStyleBackColor = true;
         this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
         // 
         // cboStatus
         // 
         this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboStatus.FormattingEnabled = true;
         this.cboStatus.Location = new System.Drawing.Point(143, 113);
         this.cboStatus.Name = "cboStatus";
         this.cboStatus.Size = new System.Drawing.Size(219, 31);
         this.cboStatus.TabIndex = 2;
         // 
         // dtpDueDate
         // 
         this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtpDueDate.Location = new System.Drawing.Point(799, 51);
         this.dtpDueDate.Name = "dtpDueDate";
         this.dtpDueDate.Size = new System.Drawing.Size(167, 30);
         this.dtpDueDate.TabIndex = 1;
         // 
         // txtTask
         // 
         this.txtTask.Location = new System.Drawing.Point(143, 54);
         this.txtTask.Name = "txtTask";
         this.txtTask.Size = new System.Drawing.Size(517, 30);
         this.txtTask.TabIndex = 0;
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 500);
         this.Controls.Add(this.fraTask);
         this.Controls.Add(this.dgTasks);
         this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.MaximizeBox = false;
         this.Name = "frmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Task Master";
         ((System.ComponentModel.ISupportInitialize)(this.dgTasks)).EndInit();
         this.fraTask.ResumeLayout(false);
         this.fraTask.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgTasks;
      private System.Windows.Forms.GroupBox fraTask;
      private System.Windows.Forms.Label lblDueDate;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblTask;
      private System.Windows.Forms.Button cmdDeleteTask;
      private System.Windows.Forms.Button cmdCancelTask;
      private System.Windows.Forms.Button cmdUpdateTask;
      private System.Windows.Forms.Button cmdCreateTask;
      private System.Windows.Forms.ComboBox cboStatus;
      private System.Windows.Forms.DateTimePicker dtpDueDate;
      private System.Windows.Forms.TextBox txtTask;
   }
}

