//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

            using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using WAQS.Entities;
using WAQS.Service.Interfaces;
using WAQS.Specifications;

namespace WAQSWorkshopServer
{
    partial class Product
    {
        [DataContract(Namespace = "http://Northwind/Entities")]
        public partial class ProductSpecifications
        {
            [DataMember]
            public string FullName
            {
                get;
                set;
            }

            [DataMember]
            public bool HasFullName
            {
                get;
                set;
            }
        }

        [DataMember]
        public ProductSpecifications Specifications
        {
            get;
            set;
        }

        protected ProductSpecifications GetSpecifications()
        {
            return Specifications ?? (Specifications = GetSpecificationsProduct());
        }

        protected virtual ProductSpecifications GetSpecificationsProduct()
        {
            return new ProductSpecifications();
        }

        [Specifications]
        public string GetFullName()
        {
            if (this.Category == null)
                return default (string);
            return this.Name + " (" + this.Category.Name + ")";
        }

        [Specifications]
        public string FullName
        {
            get
            {
                return GetSpecifications().HasFullName ? GetSpecifications().FullName : GetFullName();
            }

            set
            {
                GetSpecifications().FullName = value;
                GetSpecifications().HasFullName = true;
            }
        }
    }
}
            