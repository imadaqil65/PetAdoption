using Domain.Adoption;
using Domain.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Adoption
{
    public class PendingAdoptionManager
    {
        IPendingAdoptionDB datasource;

        public PendingAdoptionManager(IPendingAdoptionDB datasource)
        {
            this.datasource = datasource;
        }

        public void NewAdoptionRequest(PendingAdoption pa)
        {
            datasource.CreateAdoptionRequest(pa);
        }

        public List<PendingAdoption> GetAdoptionRequests()
        {
            List<PendingAdoption> requests = new List<PendingAdoption>();
            foreach (PendingAdoption pa in datasource.ReadAllAdoptionRequest())
            {
                requests.Add(pa);
            }
            return requests;
        }

        public PendingAdoption GetAdoptionRequestsByID(int id)
        {
            return datasource.GetAdoptionRequestByID(id);
        }

        public void ApproveRequest(PendingAdoption pa)
        {
            datasource.ApproveAdoptionRequest(pa);
        }

        public void UpdateAdoptionRequest(PendingAdoption pa)
        {
            datasource.UpdateAdoptionRequest(pa);
        }

        public void DeleteAdoptionRequest(PendingAdoption pa)
        {
            datasource.DeleteAdoptionRequest(pa);
        }
    }
}
