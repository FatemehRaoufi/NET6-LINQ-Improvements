
namespace NET6LINQImprovements.Models
{
    public class TitleComparer : IComparer<string>
    {
        public int Compare(string titleA, string titleB)
        {
            var titleAIsFancy = titleA.Equals("sir", StringComparison.InvariantCultureIgnoreCase);
            var titleBIsFancy = titleB.Equals("sir", StringComparison.InvariantCultureIgnoreCase);


            if (titleAIsFancy == titleBIsFancy) //If both are fancy (Or both are not fancy, return 0 as they are equal)
            {
                return 0;
            }
            else if (titleAIsFancy) //Otherwise if A is fancy (And therefore B is not), then return -1
            {
                return -1;
            }
            else //Otherwise it must be that B is fancy (And A is not), so return 1
            {
                return 1;
            }
        }
    }
}