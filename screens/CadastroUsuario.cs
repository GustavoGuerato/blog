public partial class Form1 : Form
{
    private TextBox txtNome;
    private TextBox txtEmail;
    private TextBox txtSenha;
    private Button btnCadastrar;

    public Form1()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.txtNome = new TextBox();
        this.txtEmail = new TextBox();
        this.txtSenha = new TextBox();
        this.btnCadastrar = new Button();

        // Configuração dos componentes
        this.txtNome.Location = new System.Drawing.Point(50, 50);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(200, 20);

        this.txtEmail.Location = new System.Drawing.Point(50, 80);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(200, 20);

        this.txtSenha.Location = new System.Drawing.Point(50, 110);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.Size = new System.Drawing.Size(200, 20);

        this.btnCadastrar.Location = new System.Drawing.Point(50, 140);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(200, 30);
        this.btnCadastrar.Text = "Cadastrar";
        this.btnCadastrar.Click += new EventHandler(this.btnCadastrar_Click);

        // Adiciona os controles ao formulário
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.btnCadastrar);

        this.Text = "Cadastro de Usuário";
        this.Size = new System.Drawing.Size(300, 250);
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        MessageBox.Show("Usuário cadastrado com sucesso!");
    }
}
