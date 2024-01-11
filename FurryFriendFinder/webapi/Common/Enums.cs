namespace webapi.Common
{
    public class Enums
    {
        public enum UserRole
        {
            Administrator = 0,
            Adopter = 1,
            PetOwner = 2
        }

        public enum PetType
        {
            Other = 0,
            Dog = 1,
            Cat = 2,
            Bird = 3
        }

        public enum ApplicationStatus
        {
            Pending = 0,
            Approved = 1,
            Rejected = 2
        }
    }
}
