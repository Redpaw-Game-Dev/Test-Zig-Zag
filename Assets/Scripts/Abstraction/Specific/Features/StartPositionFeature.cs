namespace TestZigZag.Abstraction
{
    public class StartPositionFeature : Vector3Feature
    {
        public override string Name => "Start Position";
        
        public override bool Equals(object obj)
        {
            return obj is StartPositionFeature;
        }

        public override int GetHashCode()
        {
            return nameof(StartPositionFeature).GetHashCode();
        }
    }
}