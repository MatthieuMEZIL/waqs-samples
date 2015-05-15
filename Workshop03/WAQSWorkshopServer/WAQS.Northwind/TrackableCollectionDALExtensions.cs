//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using WAQS.Entities;

namespace WAQS.DAL.Interfaces
{
    public static class TrackableCollectionDALExtensions
    {
        public static void Attach<T>(this TrackableCollection<T> collection, T item, IDataContext context)
            where T : class, IEntity
        {
            collection.IsAttachingOrDetaching = true;
            bool changeTrackerEnabled; 
            if (item.ChangeTracker == null)
                changeTrackerEnabled = false;
            else
            {
                changeTrackerEnabled = item.ChangeTracker.ChangeTrackingEnabled;
                item.ChangeTracker.ChangeTrackingEnabled = false;
            }
            collection.Add(item);
            context.AttachRelationship(collection.Owner, item, collection.Name);
            if (item.ChangeTracker != null)
                item.ChangeTracker.ChangeTrackingEnabled = changeTrackerEnabled;
            collection.IsAttachingOrDetaching = false;
        }
    }
}
