using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.Client.Application.Models;
using Uwc.Ics.Ws.Client.Application.Models.Dto;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IUserService
    {
        /// <summary>
        /// A service for managing user accounts.
        /// </summary>
        public interface IUserService
        {

            /// <summary>
            /// Query all users.
            /// </summary>
            /// <param name="name">The name to match, if not supplied all users are returned.</param>
            /// <returns></returns>
            Task<List<User>> GetAllUsers(string name = null);

            /// <summary>
            /// Query all users.
            /// </summary>
            /// <param name="skip">The number of users to skip.</param>
            /// <param name="top">The number of records to return.</param>
            /// <param name="name">The name to match, if not supplied all users are returned.</param>
            /// <returns></returns>
            Task<List<User>> GetAllUsers(int skip, int top, string name = null);

            /// <summary>
            /// Get a user by id.
            /// </summary>
            /// <param name="id">The user id.</param>
            /// <returns></returns>
            Task<User> GetUser(string id);

            /// <summary>
            /// A service create user account 
            /// </summary>
            Task<User> CreateUser(CreateUser request);

            /// <summary>
            /// A service editing user account 
            /// </summary>
            Task UpdateUser(UpdateUser request);

            /// <summary>
            /// A search directory users
            /// </summary>
          //  Task<List<ADUser>> SearchDirectoryUsers(string displayName);

            /// <summary>
            /// Delete a user from the application.
            /// </summary>
            /// <param name="id">The user id.</param>
            /// <returns></returns>
            Task DeleteUser(string id);
        }
    }
}
