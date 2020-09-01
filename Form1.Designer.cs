namespace pjsua2_csharp_video_demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInit = new System.Windows.Forms.Button();
            this.btnSelectCamra = new System.Windows.Forms.Button();
            this.comboxCamre = new System.Windows.Forms.ComboBox();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.sdlPreview = new SDLPreview();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(53, 74);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(113, 35);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnSelectCamra
            // 
            this.btnSelectCamra.Location = new System.Drawing.Point(53, 137);
            this.btnSelectCamra.Name = "btnSelectCamra";
            this.btnSelectCamra.Size = new System.Drawing.Size(113, 35);
            this.btnSelectCamra.TabIndex = 1;
            this.btnSelectCamra.Text = "获取摄像头";
            this.btnSelectCamra.UseVisualStyleBackColor = true;
            this.btnSelectCamra.Click += new System.EventHandler(this.btnSelectCamra_Click);
            // 
            // comboxCamre
            // 
            this.comboxCamre.DropDownHeight = 130;
            this.comboxCamre.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxCamre.FormattingEnabled = true;
            this.comboxCamre.IntegralHeight = false;
            this.comboxCamre.Location = new System.Drawing.Point(194, 142);
            this.comboxCamre.Name = "comboxCamre";
            this.comboxCamre.Size = new System.Drawing.Size(247, 29);
            this.comboxCamre.TabIndex = 2;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.Location = new System.Drawing.Point(53, 219);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(113, 35);
            this.btnStartCamera.TabIndex = 4;
            this.btnStartCamera.Text = "启动摄像头";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);

            this.sdlPreview.Location = new System.Drawing.Point(22, 12);
            this.sdlPreview.Name = "sdl";
            this.sdlPreview.Size = new System.Drawing.Size(766, 450);
            this.sdlPreview.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.comboxCamre);
            this.Controls.Add(this.btnSelectCamra);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.sdlPreview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSelectCamra;
        private System.Windows.Forms.ComboBox comboxCamre;
        private System.Windows.Forms.Button btnStartCamera;
        private SDLPreview sdlPreview;
    }
}

