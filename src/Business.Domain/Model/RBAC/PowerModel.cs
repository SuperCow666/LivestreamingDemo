using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.RBAC
{
    
  public   class PowerModel : BasicAggregateRoot<Guid>
    {
        public string PowerName { get; set; }  //名称
        public string PowerDetail { get; set; } //详情
    }
}
