using Domain.Adoption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Adoption
{
    public interface IPendingAdoptionDB
    {
        public void CreateAdoptionRequest(PendingAdoption pa);
        public void UpdateAdoptionRequest(PendingAdoption pa);
        public void DeleteAdoptionRequest(PendingAdoption pa);
        public void ApproveAdoptionRequest(PendingAdoption pa);
        public List<PendingAdoption> ReadAllAdoptionRequest();
        public PendingAdoption GetAdoptionRequestByID(int id);
    }
}
