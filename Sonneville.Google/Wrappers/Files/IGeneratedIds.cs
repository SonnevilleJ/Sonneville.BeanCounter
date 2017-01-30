using System.Collections.Generic;

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
    }
}