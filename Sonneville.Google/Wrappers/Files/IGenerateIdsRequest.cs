using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
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

        DriveBaseServiceRequest<GeneratedIds>.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        FilesResource.GenerateIdsRequest Impl { get; }

        IGeneratedIds Execute();

        Stream ExecuteAsStream();

        Task<IGeneratedIds> ExecuteAsync();

        Task<IGeneratedIds> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class GenerateIdsRequestWrapper : IGenerateIdsRequest
    {
        public GenerateIdsRequestWrapper(FilesResource.GenerateIdsRequest impl)
        {
            Impl = impl;
        }

        public FilesResource.GenerateIdsRequest Impl { get; }

        public int? Count
        {
            get { return Impl.Count; }
            set { Impl.Count = value; }
        }

        public string Space
        {
            get { return Impl.Space; }
            set { Impl.Space = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public FilesResource.GenerateIdsRequest.AltEnum? Alt
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

        public IGeneratedIds Execute()
        {
            return new GeneratedIdsWrapper(Impl.Execute());
        }

        public Stream ExecuteAsStream()
        {
            return Impl.ExecuteAsStream();
        }

        public Task<IGeneratedIds> ExecuteAsync()
        {
            return Task
                .Run(() => Impl.ExecuteAsync())
                .ContinueWith(task => new GeneratedIdsWrapper(task.Result) as IGeneratedIds);
        }

        public Task<IGeneratedIds> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task
                .Run(() => Impl.ExecuteAsync(cancellationToken), cancellationToken)
                .ContinueWith(task => new GeneratedIdsWrapper(task.Result) as IGeneratedIds, cancellationToken);
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