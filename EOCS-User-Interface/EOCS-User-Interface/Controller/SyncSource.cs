
namespace EOCS_User_Interface.Controller
{
    public class SyncSource
    {
        public string? DisplayName { get; set; }
        public string Id { get; }
        public Uri Uri { get; }

        public SyncSource(string? displayName, string id, Uri uri)
        {
            DisplayName = displayName;
            Id = id;
            Uri = uri;
        }
    }
}
