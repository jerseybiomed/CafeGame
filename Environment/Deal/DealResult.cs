namespace Cafe.Environment.Deal
{
    public class DealResult
    {
        public int ChangeRespect { get; }

        public DealResult(bool isEquals)
        {
            ChangeRespect = isEquals ? 3 : -10;
        }
    }
}
