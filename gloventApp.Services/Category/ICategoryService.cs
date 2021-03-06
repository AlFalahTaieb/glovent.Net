﻿using gloventApp.Data.Models;
using gloventApp.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gloventApp.Services.Category
{
    public interface ICategoryService :IService<category>
    {
        void AddCategory(category c);
        void DeleteCategory(category c);
        void EditCategory(category c);
        List<category> getAllCategories();



    }
}
