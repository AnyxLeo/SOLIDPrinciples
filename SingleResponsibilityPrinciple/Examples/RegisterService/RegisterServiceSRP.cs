using System;

/// <summary>
/// Several classes are here only for demonstration purposes.
/// It is a best practice that each class has its own file.
/// </summary>
namespace SingleResponsibilityPrinciple.Examples.RegisterService
{
    public class RegisterService
    {
		private UserRepository _userRepository;
		private EmailService _emailService;
		public RegisterService(UserRepository userRepository, EmailService emailService)
        {
			_userRepository = userRepository;
			_emailService = emailService;

        }
		public void RegisterUser(string username)
		{
			if (username == "admin")
				throw new InvalidOperationException();

			_userRepository.Insert(new User { UserName = username});

			_emailService.Send(new Email());
		}
	}

	public class UserRepository
    {
		public int Insert(User user)
        {
			return default;
        }
    }

	public class EmailService
    {
		public bool Send(Email email)
        {
			return default;
        }
    }
}
