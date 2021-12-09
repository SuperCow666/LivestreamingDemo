using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{
    /// <summary>
    /// 联查
    /// </summary>
   public  class FileImg : BasicAggregateRoot<Guid>
    {
        public string ImgUrl { get; set; }  //图片路径
    }
}
