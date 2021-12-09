using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.IGoodsService
{
     public interface IGoodService:ICrudAppService<GoodSDto.GoodsModelDto,Guid, PagedAndSortedResultRequestDto,CreateUpdateDto.CreateUpdateGoodsDto>
    {
    }
}
