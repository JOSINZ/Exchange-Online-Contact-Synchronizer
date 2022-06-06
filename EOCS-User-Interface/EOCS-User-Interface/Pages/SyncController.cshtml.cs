using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using EOCS_User_Interface.Controller;

namespace EOCS_User_Interface.Pages
{
    public class AssignedSyncSource
    {
        public SyncSource SyncSource { get; set; }
        public bool Assigned { get; set; } = false;

        public AssignedSyncSource(SyncSource syncSource, bool assigned)
        {
            SyncSource = syncSource;
            Assigned = assigned;
        }

        public AssignedSyncSource(SyncSource syncSource)
        {
            SyncSource = syncSource;
        }
    }

    public class SyncControllerModel : PageModel
    {
        [DisplayName("Synchronization sources")]
        public List<AssignedSyncSource> SyncSource { get; set; } = new List<AssignedSyncSource>()
        {
            new AssignedSyncSource( new SyncSource("TestSource1", "1", new Uri("https://domain1.de")) ),
            new AssignedSyncSource( new SyncSource("TestSource2", "2", new Uri("https://domain2.de")) ),
            new AssignedSyncSource( new SyncSource("TestSource3", "3", new Uri("https://domain3.de")) )
        };

        public void OnGet()
        {
        }
    }
}
