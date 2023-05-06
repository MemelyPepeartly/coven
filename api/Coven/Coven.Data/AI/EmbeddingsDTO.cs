﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coven.Data.Pinecone;
using OpenAI_API;
using OpenAI_API.Embedding;

namespace Coven.Data.DTO.AI
{
    public class EmbeddingsDTO
    {
        public EmbeddingsDTO() { 
            queryEmbeddings = new List<Embedding>();
            worldEmbeddings = new List<Embedding>();
        }

        public List<Embedding> queryEmbeddings { get; set; }
        public List<Embedding> worldEmbeddings { get; set; }
    }

    public class Embedding
    {
        public string identifier { get; set; }
        public float[] vectors { get; set; }
        public PineconeMetadata metadata { get; set; }
    }
}
