using OrderAndDeliverySystem.Data.Repositories;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Services
{
    // This class is the mediator between the UI and the repository (accessing database), containing the business logic for authentication
    public class AuthService
    {
        private StaffRepository staffRepository;

        public AuthService()
        {
            staffRepository = new StaffRepository(); //Initalize staff repository so that the service can access the database
        }

        // Returns staff member if email and password match, null if not found
        public Staff Login(string email, string password)
        {
            // call staffRepository.GetStaff()
            Staff staff = staffRepository.GetStaff(email, password);
            if(staff == null)
            {
                return null;
            }
            return staff;
        }
    }
}