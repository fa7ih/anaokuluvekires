﻿using Microsoft.AspNetCore.Identity;

namespace AnaOkuluVeKres.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola Minimum {length} karakter olmalıdır",
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description ="Parola en az 1 büyük harf içermelidir",
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Parola en az 1 küçük harf içermelidir",
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Parolalar en az bir Alphanumeric karakter içermelidir.",
			};
		}

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DuplicateUserName",
                Description = "Bu Kullanıcı adı alınmış. Lütfen başka kullanıcı adı seçiniz.",
            };
        }
    }
}
