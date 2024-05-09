using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.Client.Application.Models;

namespace Uwc.Ics.Ws.Client.Application.Abstractions
{
    public interface IRoleService
    {
        /// <summary>
        /// Get a roles b.
        /// </summary>
        /// <returns></returns>
        Task<List<Role>> GetRoles();

        /// <summary>
        /// Get a roles by Id.
        /// </summary>
        /// <returns></returns>
        Task<Role> GetRolebyId(Guid id);
    }
}
