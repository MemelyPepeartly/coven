﻿using Coven.Data.DTO.AI;
using Coven.Data.Entities;
using Coven.Data.Pinecone;
using OpenAI_API.Embedding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coven.Data.Repository
{
    public interface IRepository
    {
        #region Create
        Task<User> CreateUser(string username, string worldAnvilUsername, string email);
        Task<bool> CreatePineconeMetadataEntry(Guid userId, Guid pineconeIdentifier, ArticleMetadata metadata);
        #endregion

        #region Read
        Task<User> GetUser(Guid userId);
        Task<List<User>> GetUsers();
        Task<List<UserDTO>> GetDTOUsers();
        Task<List<PineconeVectorMetadatum>> GetWorldPineconeMetadatum(Guid worldId);
        #endregion

        #region Update
        #endregion

        #region Delete
        #endregion

        Task<bool> SaveAsync();
    }
}
