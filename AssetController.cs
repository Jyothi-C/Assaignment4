using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using AssetManagementSystem.Models;
using Microsoft.Extensions.Logging;
//Controller for the AssetManagement system
namespace AssetManagementSystem.Controllers
{
    //The class which is inherited from Controller class is a Controller
    public class AssetManagementController : Controller
    {
        //created an static object for Asset class
        static Asset asset = new Asset();
        //created a list to store asset information
        static List<Asset> assetList = new List<Asset>();

        //all the action results we will see in this post will also inherit from the ActionResult class.
        //it contains 3 assets for user choice
        public IActionResult Index()
        {
            return View();
        }
        //It contains all three assets operations
        public IActionResult ListMethodAsset()
        {
            //view returns the perticular All assets for user choice
            return View();
        }
        //displays user to enter the data of an asset
        public IActionResult Asset(Asset objmodel)
        {
            if (objmodel != null)
            {
                return View(objmodel);
            }
            else
            {
                return View();
            }
        }
        //AddAsset to add the asset information into lists
        public IActionResult AddAsset(Asset objmodel)
        {
            asset.Id = objmodel.Id;
            asset.Name = objmodel.Name;
            asset.Year = objmodel.Year;
            assetList.Add(asset);
            //it displays the list of added assets information
            return View(assetList);
        }
        //SearchAssets searches the Asset by id which is given by user
        public IActionResult SearchAsset(int id)
        {
            if (assetList.Exists(x => x.Id == id))
            {
                assetList.BinarySearch(asset);
            }
            //if the id exists it shows the asset information
            return View(assetList);
        }
        //It deletes the perticular asset data using id
        public IActionResult DeleteAsset(int id)
        {
            if (assetList.Exists(x => x.Id == id))
            {
                assetList.Remove(asset);
            }
            //After deleting it view the list
            return View(assetList);
        }
        // it updates the asset by the given new name into the available name
        public IActionResult UpdateAsset(string name, string newName)
        {
            {
                if (assetList.Exists(x => x.Name == name))
                {
                    newName = asset.Name;
                    //Asset newAssetName = asset.Where(x => x.Name == newName);
                   // return View(newAssetName);
                     return View(assetList);

                }
            }
            return View();
        }
    }
}
