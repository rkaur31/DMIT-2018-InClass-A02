using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Framework.DAL;
using eRestaurant.Framework.Entities;
using System.Data.Entity;
using System.ComponentModel;


namespace eRestaurant.Framework.BLL
{
    [DataObject]
    public class menuController
    {
      [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Item> ListMenuItems()
        {
          using (var Context = new RestaurantContext())
          {
              // Note: To use thr Lambda or Method style of Include(),
              //you need to have the following namespace reference:
              //use System.Data.Entity;
              //The .Include() method on the DbSet<T> class performs
              //"eager lading" of the data.
              return Context.Items.Include(it=> it.MenuCategory).ToList();
          }
        }
    } 
}
