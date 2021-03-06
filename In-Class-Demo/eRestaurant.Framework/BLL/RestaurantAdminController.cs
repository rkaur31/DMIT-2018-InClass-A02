﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Framework.DAL;
using eRestaurant.Framework.Entities;
using System.ComponentModel; // Needed for [DataObject] and related attribute classes

namespace eRestaurant.Framework.BLL
{       //Allosw our class to be "discorvered" by the ObjectDataSource controls in our website
        [DataObject]
        public class RestaurantAdminController
        {   //The ObjectDataSource control will od the background communication for CRUD
            #region
            //allows the ObjectDataSource to see the method as something we can select from
            [DataObjectMethod(DataObjectMethodType.Select, false)]
            public List<SpecialEvent> ListAllSpecialEvents()
            { 
                //This using statemnet ensures that our connection to the database is
                //properly "closed" once we are done "using" our DAL object
                //(context is our DAL object)
                using (RestaurantContext context = new RestaurantContext())
                {
                    return context.SpecialEvents.ToList();
                }
            }

            [DataObjectMethod(DataObjectMethodType.Update, false)]
            public void UpdateSpecialEvent(SpecialEvent item)
            {
                using (RestaurantContext context = new RestaurantContext())
                { 
                    // Dirst attach the item to the dbContext collection
                    var attached = context.SpecialEvents.Attach(item);
                    //Second, get the entry for the existing dara rahat should match for this specific special event
                    var existing = context.Entry<SpecialEvent>(attached);

                    //Third, mark that the object's values have changed
                    existing.State = System.Data.Entity.EntityState.Modified;

                    //Lastly, save the changes in the database
                    context.SaveChanges();
                }
            }
            [DataObjectMethod(DataObjectMethodType.Delete, false)]
            public void DeleteSpecialEvent(SpecialEvent item)
            {
                using (var context = new RestaurantContext())
                { 
                    //First, get a reference to the actual item in the Db
                    //Find() is a method to look up an item by it's primary key
                    var existing = context.SpecialEvents.Find(item.EventCode);

                    //Second, remove the item from the database context
                    context.SpecialEvents.Remove(existing);

                    //Lastly, save the change to the database
                    context.SaveChanges();
                }
            }

            [DataObjectMethod(DataObjectMethodType.Insert, false)]
            public void AddSpecialEvent(SpecialEvent item)
            {
                using (var context = new RestaurantContext())
                { 
                    // Add the item to the dBContext
                    var added = context.SpecialEvents.Add(item);
                    //p.s. = we aren't really going to do anything with the variable 'added'
                    //I just want you to be aware the the Add() method will return the newly
                    // added object.(This can be useful in other situations, which we will see later)

                    //Save the changes to the database
                    context.SaveChanges();
            #endregion
                }
            }
        }
    }

