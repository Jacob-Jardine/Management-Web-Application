﻿using Management_Web_Application.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_Web_Application.Services.ProductService
{
    public interface IProductService
    {
        public Task<IEnumerable<PostToProductServiceDomainModel>> GetProducts(string token);
        public Task<PostToProductServiceDomainModel> GetProductById(int ID, string token);
        public Task<bool> PostProduct(PostToProductServiceDomainModel postToProductServiceDomainModel, string token);
        public Task UpdateProductQty(UpdateProductQtyDomainModel updateProductQtyDomainModel,int id, string token);
    }
}
