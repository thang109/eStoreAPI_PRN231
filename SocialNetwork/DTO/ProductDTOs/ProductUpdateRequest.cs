﻿namespace SocialNetwork.DTO.ProductDTOs
{
    public class ProductUpdateRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }
    }
}
