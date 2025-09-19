using System;

namespace ImplementandoAssociacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Testes Manuais Veículo - Rastreador / Placa ====");

            // Teste 1: Criar veículo com placa válida (1:1 obrigatório)
            var plate = new LicensePlate("ABC-1234");
            var vehicle = new Vehicle(plate);
            Console.WriteLine("Teste 1: Veículo criado com placa obrigatória -> OK");

            try
            {
                // Teste 2: Criar veículo sem placa -> deve falhar
                var invalidVehicle = new Vehicle(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Teste 2: Falha ao criar veículo sem placa -> {ex.Message}");
            }

            // Teste 3: Atribuir rastreador (0..1) pela primeira vez
            var tracker1 = new Tracker("Tracker-001");
            bool attached1 = vehicle.AttachTracker(tracker1);
            Console.WriteLine($"Teste 3: Atribuir rastreador 1 -> {attached1}");

            // Teste 4: Tentar atribuir um segundo rastreador
            var tracker2 = new Tracker("Tracker-002");
            bool attached2 = vehicle.AttachTracker(tracker2);
            Console.WriteLine($"Teste 4: Tentar atribuir rastreador 2 -> {attached2}");

            // Teste 5: Remover o rastreador
            vehicle.DetachTracker();
            Console.WriteLine($"Teste 5: Remover rastreador -> {(vehicle.Tracker == null ? "OK (sem rastreador)" : "Falhou")}");
        }
    }

    // ==== Classes de domínio ====

    public sealed class LicensePlate
    {
        public string Code { get; }
        public LicensePlate(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Placa obrigatória e não pode ser vazia");
            Code = code;
        }
    }

    public sealed class Tracker
    {
        public string Id { get; }
        public Tracker(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID do rastreador inválido");
            Id = id;
        }
    }

    public sealed class Vehicle
    {
        public LicensePlate Plate { get; }   // 1:1 obrigatório
        public Tracker? Tracker { get; private set; } // 0..1 opcional

        public Vehicle(LicensePlate plate)
        {
            Plate = plate ?? throw new ArgumentNullException(nameof(plate));
        }

        public bool AttachTracker(Tracker tracker)
        {
            if (tracker is null) return false;
            if (Tracker != null) return false;
            Tracker = tracker;
            return true;
        }

        public void DetachTracker() => Tracker = null;
    }
}
