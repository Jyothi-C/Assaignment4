using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AssetManagementSystem.Models;

namespace AssetManagementSystem.Controllers
{
    public class AssetManagementController : Controller
    {
        static List<AssetModel> assetList = new List<AssetModel>();
        //I have used formmethod.post in searchAssset view to send and save data
        public ActionResult SearchAsset(string search)
        {
            return View(assetList.Where(b => b.Name.Equals(search) || b.Year.Equals(search) || Convert.ToString(b.Id).Equals(search) || search == null));
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var asset = assetList.FirstOrDefault(b => b.Id == id);
            return View(asset);
        }
        [HttpGet]
        public ActionResult AddAsset()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAsset(AssetModel assetCreate)
        {
            assetCreate.Id = assetList.Count + 1;
            assetList.Add(assetCreate);
            return View(assetCreate);
        }
        [HttpGet]
        public ActionResult UpdateAsset(int id)
        {
            var asset = assetList.FirstOrDefault(b => b.Id == id);
            return View(asset);
        }
        [HttpPost]
        public ActionResult UpdateAsset(AssetModel assetEdit)
        {
            var asset = assetList.FirstOrDefault(b => b.Id == assetEdit.Id);
            assetList.Remove(asset);
            assetList.Add(assetEdit);
            return View(assetEdit);
        }
        [HttpGet]
        public ActionResult DeleteAsset(int id)
        {
            var asset = assetList.FirstOrDefault(b => b.Id == id);
            return View(asset);
        }
        [HttpPost]
        public ActionResult DeleteAsset(AssetModel assetDelete)
        {
            var asset = assetList.FirstOrDefault(b => b.Id == assetDelete.Id);
            assetList.Remove(asset);
            return View(assetDelete);
        }
    }
}