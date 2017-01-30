using System.Collections.Generic;
using System.Linq;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Changes
{
    public interface IChangeList
    {
        /// <summary>The page of changes.</summary>
        IList<IChange> Changes { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#changeList".</summary>
        string Kind { get; set; }

        /// <summary>The starting page token for future changes. This will be present only if the end of the current
        /// changes list has been reached.</summary>
        string NewStartPageToken { get; set; }

        /// <summary>The page token for the next page of changes. This will be absent if the end of the current changes
        /// list has been reached.</summary>
        string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        ChangeList Impl { get; }
    }

    public class ChangeListWrapper : IChangeList
    {
        public ChangeListWrapper(ChangeList impl)
        {
            Impl = impl;
        }

        public ChangeList Impl { get; }

        public IList<IChange> Changes
        {
            get { return Impl.Changes.Select(change => new ChangeWrapper(change)).Cast<IChange>().ToList(); }
            set { Impl.Changes = value.Select(change => change.Impl).ToList(); }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public string NewStartPageToken
        {
            get { return Impl.NewStartPageToken; }
            set { Impl.NewStartPageToken = value; }
        }

        public string NextPageToken
        {
            get { return Impl.NextPageToken; }
            set { Impl.NextPageToken = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}