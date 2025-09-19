class Placa
{
    public int _id;
    public string _numero = string.Empty;
    public int _veiculoId;
    public virtual Veiculo? _veiculo { get; set; }
    public int Id
    {
        get { return _id; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O ID deve ser um número positivo.", nameof(value));
            }
            _id = value;
        }
    }

    public string Numero
    {
        get { return _numero; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O número da placa não pode ser nulo.", nameof(value));
            }
            _numero = value;
        }
    }

    public int VeiculoId
    {
        get { return _veiculoId; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O ID deve ser um número positivo.", nameof(value));
            }
            _veiculoId = value;
        }
    }


    public void aplicarMulta(string descricaoMulta, decimal valor, int pontos)
    {
        Console.WriteLine("O Veículo de modelo: " + _veiculo!.Modelo + " placa: " + Numero + " recebeu uma multa: " + descricaoMulta);
        Console.WriteLine("Valor: " + valor);
        Console.WriteLine("Pontuação: " + pontos);
    }
}