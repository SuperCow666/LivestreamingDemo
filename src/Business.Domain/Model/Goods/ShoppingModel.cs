using System;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{
    //购物车
    /// <summary>
    /// 添加购物查用的
    /// </summary>
    public class ShoppingModel:BasicAggregateRoot<Guid>
    {
        public string GoodsName { get; set; }//商品名称
        public float GoodsPrice { get; set; }//商品价格
        public string GoodsImg { get; set; }//商品图片
        public string GoodsDetail { get; set; }//商品详情
        public int State { get; set; }//商品状态  
        public string Specificationid { get; set; } //商品规格

    }
}
