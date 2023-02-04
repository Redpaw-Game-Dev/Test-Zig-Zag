namespace TestZigZag.Abstraction
{
    public struct GroundDetectorInfo : IInfo
    {
        public bool IsGrounded { get; }

        public GroundDetectorInfo(bool isGrounded)
        {
            IsGrounded = isGrounded;
        }
    }
}