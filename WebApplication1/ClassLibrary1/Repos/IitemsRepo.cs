using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using Task1.Data;
using Task1.Data.Modesl;
namespace Task1.Repos
{
   public interface ItemsRepo
    {
        public List<Items> GetAll();
        public Items GetById(int id);
    }
}
