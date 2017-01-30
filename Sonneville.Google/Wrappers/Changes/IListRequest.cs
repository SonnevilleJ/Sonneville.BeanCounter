using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Sonneville.Google.Wrappers.Changes
{
    public interface IListRequest
    {
        /// <summary>The token for continuing a previous list request on the next page. This should be set to the
        /// value of 'nextPageToken' from the previous response or to the response from the getStartPageToken
        /// method.</summary>
        string PageToken { get; }

        /// <summary>Whether to include changes indicating that items have left the view of the changes list, for
        /// example by deletion or lost access.</summary>
        /// 
        ///             [default: true]
        bool? IncludeRemoved { get; set; }

        /// <summary>The maximum number of changes to return per page.</summary>
        /// 
        ///             [default: 100]
        ///             [minimum: 1]
        ///             [maximum: 1000]
        int? PageSize { get; set; }

        /// <summary>Whether to restrict the results to changes inside the My Drive hierarchy. This omits changes to
        /// files such as those in the Application Data folder or shared files which have not been added to My
        /// Drive.</summary>
        /// 
        ///             [default: false]
        bool? RestrictToMyDrive { get; set; }

        /// <summary>A comma-separated list of spaces to query within the user corpus. Supported values are 'drive',
        /// 'appDataFolder' and 'photos'.</summary>
        /// 
        ///             [default: drive]
        string Spaces { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        DriveBaseServiceRequest<IChangeList>.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        IChangeList Execute();

        Stream ExecuteAsStream();

        Task<IChangeList> ExecuteAsync();

        Task<IChangeList> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }
}