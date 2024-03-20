using Domain.Animals;
using Logic.Services.Animals.BirdService;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeBirdDB : IBirdDB
    {
        public List<Bird> birds { get; }

        public FakeBirdDB()
        {
            birds = new List<Bird>();
        }
        public void CreateBird(Bird b)
        {
            birds.Add(b);
        }

        public void DeleteBird(Bird b)
        {
            birds.Remove(b);
        }

        public Bird GetBirdByID(int id)
        {
            foreach (var v in birds)
                if (v.id == id)
                {
                    return v;
                }
            return null;
        }

        public List<Bird> ReadAllBirds()
        {
            return birds;
        }

        public void UpdateBird(Bird b)
        {
            birds[b.id - 1]=b;
        }
    }
}
