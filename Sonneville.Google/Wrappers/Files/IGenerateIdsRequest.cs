using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IGenerateIdsRequest
    {
        /// <summary>The number of IDs to return.</summary>
        /// 
        ///             [default: 10]
        ///             [minimum: 1]
        ///             [maximum: 1000]
        int? Count { get; set; }

        /// <summary>The space in which the IDs can be used to create new files. Supported values are 'drive' and
        /// 'appDataFolder'.</summary>
        /// 
        ///             [default: drive]
        string Space { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        DriveBaseServiceRequest<IGeneratedIds>.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        IGeneratedIds Execute();

        Stream ExecuteAsStream();

        Task<IGeneratedIds> ExecuteAsync();

        Task<IGeneratedIds> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }
}