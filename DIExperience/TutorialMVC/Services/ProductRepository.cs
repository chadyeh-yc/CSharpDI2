﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVC.Services
{
    public interface IProductRepository
    {
        void Save();
    }
    public class ProductRepository : IProductRepository
    {
        public void Save()
        {
            Debug.WriteLine($"產品資訊已經更新");
        }
    }
}
