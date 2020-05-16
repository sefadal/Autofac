using Core.Entites;

namespace Entities.Dtos
{
    public class UserForRegisterDto:IDto
    {
        public class UserForLoginDto : IDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
