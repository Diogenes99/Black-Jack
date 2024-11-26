namespace BlackJackGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCartasJogador = new Label();
            lblCartasDealer = new Label();
            lblPontuacaoJogador = new Label();
            lblPontuacaoDealer = new Label();
            lblMensagem = new Label();
            btnHit = new Button();
            btnStand = new Button();
            btnNovoJogo = new Button();
            SuspendLayout();
            // 
            // lblCartasJogador
            // 
            lblCartasJogador.AutoSize = true;
            lblCartasJogador.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCartasJogador.ForeColor = Color.Red;
            lblCartasJogador.Location = new Point(348, 342);
            lblCartasJogador.Name = "lblCartasJogador";
            lblCartasJogador.Size = new Size(60, 25);
            lblCartasJogador.TabIndex = 0;
            lblCartasJogador.Text = "label1";
            // 
            // lblCartasDealer
            // 
            lblCartasDealer.AutoSize = true;
            lblCartasDealer.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCartasDealer.ForeColor = Color.Red;
            lblCartasDealer.Location = new Point(348, 107);
            lblCartasDealer.Name = "lblCartasDealer";
            lblCartasDealer.Size = new Size(60, 25);
            lblCartasDealer.TabIndex = 1;
            lblCartasDealer.Text = "label1";
            // 
            // lblPontuacaoJogador
            // 
            lblPontuacaoJogador.AutoSize = true;
            lblPontuacaoJogador.BackColor = Color.Transparent;
            lblPontuacaoJogador.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPontuacaoJogador.ForeColor = Color.Transparent;
            lblPontuacaoJogador.Location = new Point(138, 288);
            lblPontuacaoJogador.Name = "lblPontuacaoJogador";
            lblPontuacaoJogador.Size = new Size(52, 23);
            lblPontuacaoJogador.TabIndex = 2;
            lblPontuacaoJogador.Text = "label1";
            // 
            // lblPontuacaoDealer
            // 
            lblPontuacaoDealer.AutoSize = true;
            lblPontuacaoDealer.BackColor = Color.Transparent;
            lblPontuacaoDealer.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPontuacaoDealer.ForeColor = Color.Transparent;
            lblPontuacaoDealer.Location = new Point(138, 156);
            lblPontuacaoDealer.Name = "lblPontuacaoDealer";
            lblPontuacaoDealer.Size = new Size(52, 23);
            lblPontuacaoDealer.TabIndex = 3;
            lblPontuacaoDealer.Text = "label1";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Transparent;
            lblMensagem.Location = new Point(348, 228);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(68, 29);
            lblMensagem.TabIndex = 4;
            lblMensagem.Text = "label1";
            // 
            // btnHit
            // 
            btnHit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHit.Location = new Point(664, 163);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(90, 37);
            btnHit.TabIndex = 5;
            btnHit.Text = "HIT";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStand.Location = new Point(664, 206);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(90, 37);
            btnStand.TabIndex = 6;
            btnStand.Text = "STAND";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovoJogo.Location = new Point(664, 249);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(90, 37);
            btnNovoJogo.TabIndex = 7;
            btnNovoJogo.Text = "NOVO JOGO";
            btnNovoJogo.UseVisualStyleBackColor = true;
            btnNovoJogo.Click += btnNovoJogo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovoJogo);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(lblMensagem);
            Controls.Add(lblPontuacaoDealer);
            Controls.Add(lblPontuacaoJogador);
            Controls.Add(lblCartasDealer);
            Controls.Add(lblCartasJogador);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCartasJogador;
        private Label lblCartasDealer;
        private Label lblPontuacaoJogador;
        private Label lblPontuacaoDealer;
        private Label lblMensagem;
        private Button btnHit;
        private Button btnStand;
        private Button btnNovoJogo;
    }
}
