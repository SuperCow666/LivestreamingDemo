using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Model.Goods
{

    //订单信息
    /// <summary>
    /// 购买以后需要生成的订单  订单中需要用到物流信息
    /// </summary>
   public  class OrderForm : BasicAggregateRoot<Guid>
    {
        public string GoodsName { get; set; } //商品姓名
        public string CityProvince { get; set; } //省
        public string City { get; set; }  //市
        public string CityDistrict { get; set; }//区
        public string CityDetail { get; set; } //地址详情
        public string Consignee { get; set; }//收货人
        public string Phone { get; set; }//收货人联系电话
        public string GoodsDetail { get; set; }//商品详情
        public string GoodsImg { get; set; }//商品图片
    }
}
