﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;
using OpenAI_API.Embedding;

namespace Coven.Logic.DTO.AI
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
        public string characterSet { get; set; }
        public List<OpenAI_API.Embedding.Data> vector { get; set; }
    }
}
