namespace SSELib.QnA
{
    public struct SimulationTypeBundle
    {
        public SimulationTypeBundle(string name, ISimulationType simulationType)
        {
            Name = name;
            SimulationType = simulationType;
        }

        public string Name { get; set; }

        public ISimulationType SimulationType { get; set; }
    }
}
