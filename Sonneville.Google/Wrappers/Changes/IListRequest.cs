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

        ChangesResource.ListRequest.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        ChangesResource.ListRequest Impl { get; }

        IChangeList Execute();

        Stream ExecuteAsStream();

        Task<IChangeList> ExecuteAsync();

        Task<IChangeList> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class ListRequestWrapper : IListRequest
    {
        public ListRequestWrapper(ChangesResource.ListRequest impl)
        {
            Impl = impl;
        }

        public ChangesResource.ListRequest Impl { get; }

        public string PageToken => Impl.PageToken;

        public bool? IncludeRemoved
        {
            get { return Impl.IncludeRemoved; }
            set { Impl.IncludeRemoved = value; }
        }

        public int? PageSize
        {
            get { return Impl.PageSize; }
            set { Impl.PageSize = value; }
        }

        public bool? RestrictToMyDrive
        {
            get { return Impl.RestrictToMyDrive; }
            set { Impl.RestrictToMyDrive = value; }
        }

        public string Spaces
        {
            get { return Impl.Spaces; }
            set { Impl.Spaces = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public ChangesResource.ListRequest.AltEnum? Alt
        {
            get { return Impl.Alt; }
            set { Impl.Alt = value; }
        }

        public string Fields
        {
            get { return Impl.Fields; }
            set { Impl.Fields = value; }
        }

        public string Key
        {
            get { return Impl.Key; }
            set { Impl.Key = value; }
        }

        public string OauthToken
        {
            get { return Impl.OauthToken; }
            set { Impl.OauthToken = value; }
        }

        public bool? PrettyPrint
        {
            get { return Impl.PrettyPrint; }
            set { Impl.PrettyPrint = value; }
        }

        public string QuotaUser
        {
            get { return Impl.QuotaUser; }
            set { Impl.QuotaUser = value; }
        }

        public string UserIp
        {
            get { return Impl.UserIp; }
            set { Impl.UserIp = value; }
        }

        public ETagAction ETagAction
        {
            get { return Impl.ETagAction; }
            set { Impl.ETagAction = value; }
        }

        public IDictionary<string, IParameter> RequestParameters => Impl.RequestParameters;

        public IClientService Service => Impl.Service;

        public IChangeList Execute()
        {
            return new ChangeListWrapper(Impl.Execute());
        }

        public Stream ExecuteAsStream()
        {
            return Impl.ExecuteAsStream();
        }

        public Task<IChangeList> ExecuteAsync()
        {
            return Task
                .Run(() => Impl.ExecuteAsync())
                .ContinueWith(task => new ChangeListWrapper(task.Result) as IChangeList);
        }

        public Task<IChangeList> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task
                .Run(() => Impl.ExecuteAsync(cancellationToken), cancellationToken)
                .ContinueWith(task => new ChangeListWrapper(task.Result) as IChangeList, cancellationToken);
        }

        public Task<Stream> ExecuteAsStreamAsync()
        {
            return Impl.ExecuteAsStreamAsync();
        }

        public Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken)
        {
            return Impl.ExecuteAsStreamAsync(cancellationToken);
        }

        public HttpRequestMessage CreateRequest(bool? overrideGZipEnabled)
        {
            return Impl.CreateRequest(overrideGZipEnabled);
        }
    }
}