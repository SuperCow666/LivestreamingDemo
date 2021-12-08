using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{
    //商品
    /// <summary>
    ///商品显示
    /// </summary>
   public  class GoodsModel : BasicAggregateRoot<Guid>
    {
        public string FileImg { get; set; } //图片
        public string GoodsName { get; set; }//商品名称
        public float GoodsPrice { get; set; }//商品价格
        public string GoodsImg { get; set; }//商品图片
        public string GoodsDetail { get; set; }//商品详情
        public int GoodsSum { get; set; }//商品库存
        public int State { get; set; }//商品状态  
        public string GoodsId { get; set; } //外键
        public string CategoryId { get; set; } //种类
        public string Specificationid { get; set; } //商品规格


    }
}
