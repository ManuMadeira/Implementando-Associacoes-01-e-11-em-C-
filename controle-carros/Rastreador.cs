class Rastreador
{
    public int _id;
    public string _numeroSerie = string.Empty;
    public int _veiculoId;
    
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

    public string NumeroSerie
    {
        get { return _numeroSerie; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O número da placa não pode ser nulo.", nameof(value));
            }
            _numeroSerie = value;
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

    void alterarQuilometragem()
    {
        Console.WriteLine("Digite a quilometragem a ser acrescentada: ");
        int acrescimo = int.Parse(Console.ReadLine()!);

        Veiculo!.alterarQuilometragem(acrescimo);
    }
    public virtual Veiculo? Veiculo { get; set; }
}