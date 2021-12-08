using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{
    //物流信息  单独的
    /// <summary>
    /// 单独显示物流信息的  不需要联查
    /// </summary>
    public class LogisticsModel : BasicAggregateRoot<Guid>
    {
        public string LogisticsName { get; set; } //地址
        public DateTime CreateTime { get; set; } //时间
        public string Detail { get; set; }  //详情

    }
}
