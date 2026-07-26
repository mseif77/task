using System;
using System.Collections.Generic;
using System.Text;
using Task1.Data;
using Task1.Data.Modesl;

namespace Task1.Repos
{
       public class ItemRepo : ItemsRepo
    {
        private readonly AppDbContext _context;
        public ItemRepo(AppDbContext context)
        {
            _context = context;
        }
        public List<Items> GetAll()
        {
            var items = _context.Items.ToList();
            return items;
        }

        public Items GetById(int id)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == id);
            return item ?? new();
        }
    }
}
