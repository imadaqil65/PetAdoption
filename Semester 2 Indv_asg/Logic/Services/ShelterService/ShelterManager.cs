using Domain.Shelters;

namespace Logic.Services.ShelterService
{
    public class ShelterManager
    {
        IShelterDB datasource;

        public ShelterManager(IShelterDB datasource)
        {
            this.datasource = datasource;
        }

        public void NewShelter(Shelter shelter)
        {
            datasource.CreateShelter(shelter);
        }

        public List<Shelter> GetShelters()
        {
            return datasource.ReadAllShelters();
        }

        public Shelter GetShelterByID(int id)
        {
            return datasource.GetShelterById(id);
        }

        public void UpdateShelter(Shelter shelter)
        {
            datasource.UpdateShelter(shelter);
        }

        public void DeleteShelter(Shelter shelter)
        {
            datasource.DeleteShelter(shelter);
        }

        public bool TextBoxValidation(string[] strings)
        {
            if (strings.Any(x => string.IsNullOrEmpty(x.ToString())))
            {
                return false;
            }
            return true;
        }
    }
}
