﻿using Domain;

namespace WebApiContracts.Mappers
{
    public static class UserCredentialsMapper
    {

        public static UserCredentials MapTestToDomain(this UserCredentialsContract credentials)
        {
            return new UserCredentials
            {
                Username = credentials.Username,
                Password = credentials.Password,
                Email = credentials.Email
            };
        } 

    }
}
