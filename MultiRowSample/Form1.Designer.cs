namespace MultiRowSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ユーザーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDataSet = new MultiRowSample.SampleDataSet();
            this.ユーザーTableAdapter = new MultiRowSample.SampleDataSetTableAdapters.ユーザーTableAdapter();
            this.tableAdapterManager = new MultiRowSample.SampleDataSetTableAdapters.TableAdapterManager();
            this.gcMultiRow1 = new GrapeCity.Win.MultiRow.GcMultiRow();
            this.sampleTemplate1 = new MultiRowSample.SampleTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.ユーザーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).BeginInit();
            this.SuspendLayout();
            // 
            // ユーザーBindingSource
            // 
            this.ユーザーBindingSource.DataMember = "ユーザー";
            this.ユーザーBindingSource.DataSource = this.sampleDataSet;
            // 
            // sampleDataSet
            // 
            this.sampleDataSet.DataSetName = "SampleDataSet";
            this.sampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ユーザーTableAdapter
            // 
            this.ユーザーTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MultiRowSample.SampleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ユーザーTableAdapter = this.ユーザーTableAdapter;
            // 
            // gcMultiRow1
            // 
            this.gcMultiRow1.DataSource = this.ユーザーBindingSource;
            this.gcMultiRow1.Location = new System.Drawing.Point(32, 36);
            this.gcMultiRow1.Name = "gcMultiRow1";
            this.gcMultiRow1.Size = new System.Drawing.Size(345, 425);
            this.gcMultiRow1.TabIndex = 0;
            this.gcMultiRow1.Template = this.sampleTemplate1;
            this.gcMultiRow1.Text = "gcMultiRow1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 523);
            this.Controls.Add(this.gcMultiRow1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ユーザーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.MultiRow.GcMultiRow gcMultiRow1;
        private SampleTemplate sampleTemplate1;
        private SampleDataSet sampleDataSet;
        private System.Windows.Forms.BindingSource ユーザーBindingSource;
        private SampleDataSetTableAdapters.ユーザーTableAdapter ユーザーTableAdapter;
        private SampleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

