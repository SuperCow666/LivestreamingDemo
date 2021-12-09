using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{
    /// <summary>
    ///需要连查
    /// </summary>
   public  class CategoryModel : BasicAggregateRoot<Guid>
    {
        public string CategoryName { get; set; } //种类
    }
}
