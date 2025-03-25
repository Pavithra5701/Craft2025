using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

public class AdminController : Controller
{
    // Dummy Data
    public static List<CraftDetail> craftData = new List<CraftDetail>
    {
        new CraftDetail { Name = "John", MobileNum = "1234567890", Address = "City A", PayMode = "Online", CraftType = "Paper Craft" },
        new CraftDetail { Name = "Doe", MobileNum = "9876543210", Address = "City B", PayMode = "COD", CraftType = "Bottle Craft" },
        new CraftDetail { Name = "Anna", MobileNum = "4561237890", Address = "City C", PayMode = "Online", CraftType = "Teddy Bear Making" }
    };

    // GET

    public IActionResult AdminDashboard()
    {
        ViewBag.CraftList = new List<SelectListItem>
        {
            new SelectListItem { Text = "Paper Craft", Value = "Paper Craft" },
            new SelectListItem { Text = "Bottle Craft", Value = "Bottle Craft" },
            new SelectListItem { Text = "Teddy Bear Making", Value = "Teddy Bear Making" }
        };
        return View();
    }

    [HttpPost]
    public IActionResult AdminDashboard(string selectedCraft)
    {
        ViewBag.CraftList = new List<SelectListItem>
        {
            new SelectListItem { Text = "Paper Craft", Value = "Paper Craft" },
            new SelectListItem { Text = "Bottle Craft", Value = "Bottle Craft" },
            new SelectListItem { Text = "Teddy Bear Making", Value = "Teddy Bear Making" }
        };

        // Dummy data - Replace with DB fetch based on selectedCraft
        var data = new List<CraftDetail>
        {
            new CraftDetail { Name = "John", MobileNum = "1234567890", Address = "Address 1", PayMode = "Cash" },
            new CraftDetail { Name = "Jane", MobileNum = "9876543210", Address = "Address 2", PayMode = "Online" }
        };

        ViewBag.SelectedCraft = selectedCraft;
        ViewBag.Stock = 50;
        ViewBag.Data = data; // Assign your list here
        return View();
    }
    // Populate Craft Dropdown List
    private List<SelectListItem> GetCraftList()
    {
        return new List<SelectListItem>
        {
            new SelectListItem { Text = "Paper Craft", Value = "Paper Craft" },
            new SelectListItem { Text = "Bottle Craft", Value = "Bottle Craft" },
            new SelectListItem { Text = "Teddy Bear Making", Value = "Teddy Bear Making" }
        };


    }

    public class CraftDetail
    {
        public string Name { get; set; }
        public string MobileNum { get; set; }
        public string Address { get; set; }
        public string PayMode { get; set; }
        public string CraftType { get; set; }
    }
}
