using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Sonneville.Google.Wrappers.About
{
    public interface IGetRequest
    {
        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        DriveBaseServiceRequest<IAbout>.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        AboutResource.GetRequest Impl { get; }

        IAbout Execute();

        Stream ExecuteAsStream();

        Task<IAbout> ExecuteAsync();

        Task<IAbout> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class GetRequestWrapper : IGetRequest
    {
        public GetRequestWrapper(AboutResource.GetRequest impl)
        {
            Impl = impl;
        }

        public AboutResource.GetRequest Impl { get; }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public DriveBaseServiceRequest<IAbout>.AltEnum? Alt
        {
            get { return Enum.Parse(typeof(DriveBaseServiceRequest<global::Google.Apis.Drive.v3.Data.About>.AltEnum), Impl.Alt.ToString()) as DriveBaseServiceRequest<IAbout>.AltEnum?; }
            set { Impl.Alt = Enum.Parse(typeof(DriveBaseServiceRequest<IAbout>.AltEnum), value.ToString()) as DriveBaseServiceRequest<global::Google.Apis.Drive.v3.Data.About>.AltEnum?; }
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

        public IAbout Execute()
        {
            return new AboutWrapper(Impl.Execute());
        }

        public Stream ExecuteAsStream()
        {
            return Impl.ExecuteAsStream();
        }

        public Task<IAbout> ExecuteAsync()
        {
            return Task
                .Run(() => Impl.ExecuteAsync())
                .ContinueWith(task => new AboutWrapper(task.Result) as IAbout);
        }

        public Task<IAbout> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task
                .Run(() => Impl.ExecuteAsync(cancellationToken), cancellationToken)
                .ContinueWith(task => new AboutWrapper(task.Result) as IAbout, cancellationToken);
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