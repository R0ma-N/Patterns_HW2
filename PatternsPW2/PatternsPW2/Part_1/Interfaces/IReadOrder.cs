
namespace PatternsPW2.Part_1
{
    interface IReadOrder
    {
        public Order Load(int OrderId) 
        {
            return new Order();
        }
    }
}
