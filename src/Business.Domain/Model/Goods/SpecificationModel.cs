using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{
    /// <summary>
    /// 类别表  显示用的
    /// </summary>
    public class SpecificationModel : BasicAggregateRoot<Guid>
    {
        public string SpecificationName { get; set; } //规格值
    }
}
