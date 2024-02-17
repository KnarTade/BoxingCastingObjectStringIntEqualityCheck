
namespace BoxingCasting; 



public class GenericThing<T> where T : IComparable
{
    public T data = default(T);
    public string Process(T input)
    {
        if (data.CompareTo(input) == 0)
        {

            return "Data and input are the same";

        }

        else
        {
            return "Data and input are  NOT the same";

        }



    }






}
