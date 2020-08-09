using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class RoleHandler
    {
        public static Role getById(int id) {
            return RoleRepository.searchRoleById(id);
        }
    }
}