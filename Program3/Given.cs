
namespace Program3
{
    public class Given
    {
        public int FacesGiven = 0;
        public Given()
        {
            Random rand = new Random();
            FacesGiven = rand.Next(1, 7);
        }

    }
}
