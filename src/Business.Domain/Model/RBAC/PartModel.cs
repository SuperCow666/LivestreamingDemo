using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.RBAC
{
   public  class PartModel : BasicAggregateRoot<Guid>
    {
        public string RoleName { get; set; } //名称
        public string RoleDetail { get; set; }//详情
    }
}
