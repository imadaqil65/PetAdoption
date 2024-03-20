using Domain.Adoption;
using Logic.Services.Adoption;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeAdoptionDB : IPendingAdoptionDB
    {
        public List<PendingAdoption> adoptions { get; }
        public FakeAdoptionDB()
        {
            adoptions = new List<PendingAdoption>();
        }

        public void ApproveAdoptionRequest(PendingAdoption pa)
        {
            var itemsToRemove = adoptions.Where(v => v.Animal_id == pa.Animal_id).ToList();

            foreach (var item in itemsToRemove)
            {
                adoptions.Remove(item);
            }
        }

        public void CreateAdoptionRequest(PendingAdoption pa)
        {
            adoptions.Add(pa);
        }

        public void DeleteAdoptionRequest(PendingAdoption pa)
        {
            adoptions.Remove(pa); ;
        }

        public PendingAdoption GetAdoptionRequestByID(int id)
        {
            foreach(var v in adoptions)
            {
                if (v.Adoption_id == id)
                {
                    return v;
                }
            }
            return null;
        }

        public List<PendingAdoption> ReadAllAdoptionRequest()
        {
            return adoptions;
        }

        public void UpdateAdoptionRequest(PendingAdoption pa)
        {
            throw new NotImplementedException();
        }
    }
}
