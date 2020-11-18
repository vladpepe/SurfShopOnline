﻿using OnlineShoppingStore.DAL;
using OnlineShoppingStore.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineShoppingStore.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        
        public IEnumerable<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel()
        {
             
            return new HomeIndexViewModel
            {
                ListOfProducts = _unitOfWork.GetRepositoryInstance<Tbl_Product>().GetAllRecords()
            };
        }
    }
}