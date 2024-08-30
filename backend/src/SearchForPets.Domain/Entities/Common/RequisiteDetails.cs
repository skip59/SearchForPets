namespace SearchForPets.Domain.Entities.Common
{
    public record RequisiteDetails
    {
        private RequisiteDetails()
        {
        }

        public RequisiteDetails(List<Requisite> requisites)
        {
            Requisites = requisites;
        }
        public IReadOnlyList<Requisite> Requisites { get; }
    }
}
