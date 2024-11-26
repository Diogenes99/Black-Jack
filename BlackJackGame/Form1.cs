namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        private Baralho baralho;
        private List<Carta> cartasJogador;
        private List<Carta> cartasDealer;
        private int pontuacaoJogador;
        private int pontuacaoDealer;

        public Form1()
        {
            InitializeComponent();
            NovoJogo();
        }

        private void NovoJogo()
        {
            baralho = new Baralho();
            cartasJogador = new List<Carta>();
            cartasDealer = new List<Carta>();
            pontuacaoJogador = 0;
            pontuacaoDealer = 0;

            // Distribuir duas cartas para o jogador e o dealer
            cartasJogador.Add(baralho.ComprarCarta());
            cartasJogador.Add(baralho.ComprarCarta());
            cartasDealer.Add(baralho.ComprarCarta());
            cartasDealer.Add(baralho.ComprarCarta());

            AtualizarInterface();

            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }

        private void AtualizarInterface()
        {
            // Atualizar a interface com as cartas e a pontuação
            lblCartasJogador.Text = string.Join(", ", cartasJogador.Select(c => c.Valor + " de " + c.Naipe));
            lblCartasDealer.Text = string.Join(", ", cartasDealer.Select(c => c.Valor + " de " + c.Naipe));

            pontuacaoJogador = cartasJogador.Sum(c => c.Pontos);
            pontuacaoDealer = cartasDealer.Sum(c => c.Pontos);

            lblPontuacaoJogador.Text = $"Pontuação Jogador: {pontuacaoJogador}";
            lblPontuacaoDealer.Text = $"Pontuação Dealer: {pontuacaoDealer}";

            lblMensagem.Text = ""; // Limpar mensagem anterior
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            cartasJogador.Add(baralho.ComprarCarta());
            AtualizarInterface();

            if (pontuacaoJogador > 21)
            {
                FinalizarJogo("Você estourou! Dealer vence.");
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (pontuacaoDealer < 17)
            {
                cartasDealer.Add(baralho.ComprarCarta());
                AtualizarInterface();
            }

            if (pontuacaoDealer > 21 || pontuacaoJogador > pontuacaoDealer)
            {
                FinalizarJogo("Você venceu!");
            }
            else if (pontuacaoDealer > pontuacaoJogador)
            {
                FinalizarJogo("Dealer vence!");
            }
            else
            {
                FinalizarJogo("Empate!");
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void FinalizarJogo(string mensagem)
        {
            lblMensagem.Text = mensagem;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }
    }

    public class Carta
    {
        public string Naipe { get; set; }
        public string Valor { get; set; }
        public int Pontos { get; set; }

        public Carta(string naipe, string valor, int pontos)
        {
            Naipe = naipe;
            Valor = valor;
            Pontos = pontos;
        }
    }

    public class Baralho
    {
        private List<Carta> cartas;

        public Baralho()
        {
            cartas = new List<Carta>();
            string[] naipes = { "Copas", "Espadas", "Ouros", "Paus" };
            string[] valores = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] pontos = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            foreach (var naipe in naipes)
            {
                for (int i = 0; i < valores.Length; i++)
                {
                    cartas.Add(new Carta(naipe, valores[i], pontos[i]));
                }
            }
            Embaralhar();
        }

        public void Embaralhar()
        {
            Random rnd = new Random();
            cartas = cartas.OrderBy(c => rnd.Next()).ToList();
        }

        public Carta ComprarCarta()
        {
            Carta carta = cartas.First();
            cartas.RemoveAt(0);
            return carta;
        }
    }
}
