﻿using Coven.Logic.DTO.WorldAnvil;

namespace Coven.Api.Services
{
    public interface IWorldAnvilService
    {
        Task<object> GetUser();
        Task<object> GetWorld(Guid worldId);
        Task<ArticleDTO> GetArticles(Guid worldId);
    }
}