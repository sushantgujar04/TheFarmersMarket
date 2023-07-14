using ECommerce.Core.DTOS;
using ECommerce.Core.Interfaces.Services;
using ECommerce.Core.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.API.Test
{
    internal class OfferItemServiceFake : IOfferItemService
    {
        public Task<BaseGenericResult<IReadOnlyList<OfferItemDto>>> GetAllOfferItemsAsync()
        {
            var list = new List<OfferItemDto> {

                 new OfferItemDto {
                    OfferId= 1,
                    ProductId= 1,
                    OfferPrice= 50
                  },
                  new OfferItemDto {
                    OfferId=2,
                    ProductId=2,
                    OfferPrice= 20
                  },
                  new OfferItemDto {
                    OfferId=3,
                    ProductId=1,
                    OfferPrice= 0
                  },
                  new OfferItemDto {
                    OfferId=3,
                    ProductId=4,
                    OfferPrice= 100
                  },
                  new OfferItemDto {
                    OfferId=4,
                    ProductId=5,
                    OfferPrice= 0
                  },
                  new OfferItemDto {
                    OfferId=4,
                    ProductId=2,
                    OfferPrice= 50
                  }

            };


            var result = new BaseGenericResult<IReadOnlyList<OfferItemDto>>(true, StatusCodes.Status200OK, "", list);
            return (Task<BaseGenericResult<IReadOnlyList<OfferItemDto>>>)result.Data;
            //(BaseGenericResult<IReadOnlyList<OfferItemDto>>)await Task.FromResult(list.AsEnumerable());
        }

        public Task<BaseGenericResult<IReadOnlyList<OfferItemDto>>> GetAllOffersItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
