﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Airelax.Application.WishLists;
using Airelax.Application.WishLists.Dtos.Request;
using Airelax.Application.WishLists.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace Airelax.Controllers
{
    [Route("api/[controller]")]
    public class WishListsController : Controller
    {
        private readonly IWishListService _wishListService;

        public WishListsController(IWishListService wishListService)
        {
            _wishListService = wishListService;
        }

        [HttpPost]
        public bool Create([FromBody] CreateWishListInput input)
        {
            _wishListService.CreateWishList(input);
            return true;
        }

        [HttpPut]
        public bool Update([FromBody] UpdateWishListInput input)
        {
            _wishListService.UpdateWishName(input);
            return true;
        }

        [HttpPut]
        [Route("Houses")]
        public bool ReviseHouses([FromBody] UpdateWishListInput input)
        {
            _wishListService.ReviseHouse(input);
            return true;
        }

        [HttpDelete]
        public bool Delete([FromBody] DeleteWishListInput input)
        {
            _wishListService.DeleteWishList(input.WishId);
            return true;
        }

        [HttpGet]
        public IEnumerable<WishListViewModel> GetWishLists()
        {
            return _wishListService.GetWishLists();
        }

        [HttpGet]
        [Route("{wishId}")]
        public async Task<IEnumerable<WishListHousesViewModel>> GetHousesByWishList(int wishId)
        {
            return await _wishListService.GetHousesByWishList(wishId);
        }
    }
}