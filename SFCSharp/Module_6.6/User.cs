using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6._6
{
	class User
	{
		private int age;
		private string login;
		private string email;

		public string Login
        {
            get { return login; }
			set { 
					if (login.Length > 3)
					{
						login = value;
					}
				}
        }

		public string Email
        {
			get { return email; }
			set
            {
				if (email.Contains("@"))
                {
					email = value;
                }
            }
        }

		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}
	}
}
