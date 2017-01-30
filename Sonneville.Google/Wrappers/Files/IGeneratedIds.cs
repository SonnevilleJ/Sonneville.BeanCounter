using System.Collections.Generic;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IGeneratedIds
    {
        /// <summary>The IDs generated for the requesting user in the specified space.</summary>
        IList<string> Ids { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#generatedIds".</summary>
        string Kind { get; set; }

        /// <summary>The type of file that can be created with these IDs.</summary>
        string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        GeneratedIds Impl { get; }
    }

    public class GeneratedIdsWrapper : IGeneratedIds
    {
        public GeneratedIdsWrapper(GeneratedIds impl)
        {
            Impl = impl;
        }

        public GeneratedIds Impl { get; }

        public IList<string> Ids
        {
            get { return Impl.Ids; }
            set { Impl.Ids = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public string Space
        {
            get { return Impl.Space; }
            set { Impl.Space = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}