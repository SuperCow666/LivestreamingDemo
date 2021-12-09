using Business.Model.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.GoodService
{
   public   class GoodsService:CrudAppService<GoodsModel,GoodSDto.GoodsModelDto,Guid, PagedAndSortedResultRequestDto,CreateUpdateDto.CreateUpdateGoodsDto>,IGoodsService.IGoodService
    {
        public GoodsService(IRepository<GoodsModel, Guid> repository) : base(repository)
        {

        }
    }
}
