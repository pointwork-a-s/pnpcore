﻿using PnP.Core.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace PnP.Core.Model.SharePoint
{

    [SharePointType("SP.Feature", Target = typeof(Site), Uri = "_api/Site/Features/GetById(guid'{DefinitionId}')')", Get = "_api/Site/Features", LinqGet = "_api/Site/Features")]
    [SharePointType("SP.Feature", Target = typeof(Web), Uri = "_api/Web/Features/GetById(guid'{DefinitionId}')", Get = "_api/Web/Features", LinqGet = "_api/Web/Features")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2243:Attribute string literals should parse correctly", Justification = "<Pending>")]
    internal partial class Feature
    {

        public Feature()
        {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
            AddApiCallHandler = async (keyValuePairs) =>
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
            {
                var entity = EntityManager.GetClassInfo(GetType(), this);
                return new ApiCall($"{entity.SharePointGet}/add(guid'{DefinitionId}')", ApiType.SPORest, null);
            };
        }

        public async Task RemoveAsync()
        {
            var entity = EntityManager.GetClassInfo(GetType(), this);
            var apiCall = new ApiCall($"{entity.SharePointGet}/remove(guid'{DefinitionId}')", ApiType.SPORest);

            await RawRequestAsync(apiCall, HttpMethod.Post).ConfigureAwait(false);
        }

        public async Task RemoveBatchAsync()
        {
            await RemoveBatchAsync(PnPContext.CurrentBatch).ConfigureAwait(false);
        }

        public async Task RemoveBatchAsync(Batch batch)
        {
            var entity = EntityManager.GetClassInfo(GetType(), this);
            var apiCall = new ApiCall($"{entity.SharePointGet}/remove(guid'{DefinitionId}')", ApiType.SPORest);

            await RawRequestBatchAsync(batch, apiCall, HttpMethod.Post).ConfigureAwait(false);
        }
    }
}
