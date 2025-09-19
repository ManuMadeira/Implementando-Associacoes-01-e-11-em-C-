using System.Numerics;

class Veiculo
{
    private int _id;
    private string _modelo = string.Empty;
    private BigInteger _quilometragem;
    public virtual Rastreador? Rastreador { get; set; }

    public Veiculo(int id, string modelo, BigInteger quilometragem)
    {
        Id = id;
        Modelo = modelo;
        Quilometragem = quilometragem;
    }

    public void alterarQuilometragem(BigInteger acressimo)
    {
        if (acressimo < 0)
        {
            throw new Exception("O acressimo não pode ser negativo");
        }

        Quilometragem = Quilometragem + acressimo;
    }

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

    public string Modelo
    {
        get { return _modelo; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O modelo não pode ser nulo.", nameof(value));
            }
            _modelo = value;
        }
    }

    public BigInteger Quilometragem
    {
        get { return _quilometragem; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("A quilometragem deve ser um número positivo.", nameof(value));
            }
        }
    }
}