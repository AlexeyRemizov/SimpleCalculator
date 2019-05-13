namespace SimpleCalculator.SecondLab
{
    /// <summary>
    /// Easy calculator class.
    /// </summary>
    public class EasyCalculator
    {
        /// <summary>
        /// Add 2 nums.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(IAddMethod addMethod, int a, int b)
        {
            // We create a mock object for this IAddMethod interface, 
            // change behavior for Add method and dont for Additional method.
            addMethod.AdditionalMethod(); 
            return addMethod.Add(a,b);
        }
    }
}
