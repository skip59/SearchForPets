namespace SearchForPets.Domain.Entities.Common
{
    public class RequisiteDetails
    {

        private readonly List<Requisite> _requisites = [];

        public IReadOnlyList<Requisite> Requisites => _requisites.AsReadOnly();

        public void AddRequisite(Requisite requisites) => _requisites.Add(requisites);
    }
}
