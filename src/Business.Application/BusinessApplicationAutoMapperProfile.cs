using AutoMapper;
using Business.Model.Goods;

namespace Business
{
    public class BusinessApplicationAutoMapperProfile : Profile
    {
        public BusinessApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<GoodsModel, GoodSDto.GoodsModelDto>();
            CreateMap<CreateUpdateDto.CreateUpdateGoodsDto, GoodsModel>();
        }
    }
}
