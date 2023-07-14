using ECommerce.API.Controllers;
using ECommerce.Core.DTOS;
using ECommerce.Core.Entities;
using ECommerce.Core.Interfaces.Services;
using ECommerce.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Test
{
    public class OfferItemControllerTest
    {

        private readonly OfferItemController _offerItemController;
        private readonly OfferItemServiceFake offerItemServiceFake;

        public OfferItemControllerTest()
        {
            offerItemServiceFake= new OfferItemServiceFake();
           _offerItemController = new OfferItemController(offerItemServiceFake);
        }

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void GetAllOffersItemsReturnOkResult()
        {

            //act
            var okResult =  _offerItemController.GetAllOffersItems();

            var  x = okResult.Result;
            Product product = new Product();
            // return StatusCode(result.StatusCode, okResult);

            // return Task<Product>;
            //Assert.True<OkResult>(okResult.Result);
            
        }
    }
}