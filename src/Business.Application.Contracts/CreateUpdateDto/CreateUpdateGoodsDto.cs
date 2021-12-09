using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.CreateUpdateDto
{
    public  class CreateUpdateGoodsDto
    {
        [Required]
        [StringLength(128)]
        public string FileImg { get; set; } //图片

        [Required]
        public string GoodsName { get; set; }//商品名称

        [Required]
        public float GoodsPrice { get; set; }//商品价格

        [Required]
        public string GoodsImg { get; set; }//商品图片
        [Required]
        public string GoodsDetail { get; set; }//商品详情
        [Required]
        public int GoodsSum { get; set; }//商品库存
        [Required]
        public int State { get; set; }//商品状态  
        [Required]
        public string GoodsId { get; set; } //外键
        [Required]
        public string CategoryId { get; set; } //种类
        [Required]
        public string Specificationid { get; set; } //商品规格
    }
}
