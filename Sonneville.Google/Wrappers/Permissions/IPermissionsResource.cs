namespace Sonneville.Google.Wrappers.Permissions
{
    public interface IPermissionsResource
    {
        /// <summary>Creates a permission for a file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        ICreateRequest Create(IPermission body, string fileId);

        /// <summary>Deletes a permission.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="permissionId">The ID of the
        /// permission.</param>
        IDeleteRequest Delete(string fileId, string permissionId);

        /// <summary>Gets a permission by ID.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="permissionId">The ID of the
        /// permission.</param>
        IGetRequest Get(string fileId, string permissionId);

        /// <summary>Lists a file's permissions.</summary>
        /// <param name="fileId">The ID of the file.</param>
        IListRequest List(string fileId);

        /// <summary>Updates a permission with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="permissionId">The ID of the
        /// permission.</param>
        IUpdateRequest Update(IPermission body, string fileId, string permissionId);
    }
}