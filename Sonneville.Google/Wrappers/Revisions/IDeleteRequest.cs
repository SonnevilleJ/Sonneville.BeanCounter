using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Sonneville.Google.Wrappers.Revisions
{
    public interface IDeleteRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the revision.</summary>
        string RevisionId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        DriveBaseServiceRequest<string>.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        RevisionsResource.DeleteRequest Impl { get; }

        string Execute();

        Stream ExecuteAsStream();

        Task<string> ExecuteAsync();

        Task<string> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class DeleteRequestWrapper : IDeleteRequest
    {
        public DeleteRequestWrapper(RevisionsResource.DeleteRequest impl)
        {
            Impl = impl;
        }

        public RevisionsResource.DeleteRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string RevisionId => Impl.RevisionId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public DriveBaseServiceRequest<string>.AltEnum? Alt
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

        public string Execute()
        {
            return Impl.Execute();
        }

        public Stream ExecuteAsStream()
        {
            return Impl.ExecuteAsStream();
        }

        public Task<string> ExecuteAsync()
        {
            return Impl.ExecuteAsync();
        }

        public Task<string> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Impl.ExecuteAsync(cancellationToken);
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