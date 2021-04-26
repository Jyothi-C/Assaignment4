using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AssetManagementSystem.Models;
//This is the model for the AssetManagement system
namespace AssetManagementSystem.Models
{
    //properties of three assets
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}