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
    partial class Customer
    {
        [DataContract(Namespace = "http://Northwind/Entities")]
        public partial class CustomerSpecifications
        {
            [DataMember]
            public double TotalSpent
            {
                get;
                set;
            }

            [DataMember]
            public bool HasTotalSpent
            {
                get;
                set;
            }

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
        public CustomerSpecifications Specifications
        {
            get;
            set;
        }

        protected CustomerSpecifications GetSpecifications()
        {
            return Specifications ?? (Specifications = GetSpecificationsCustomer());
        }

        protected virtual CustomerSpecifications GetSpecificationsCustomer()
        {
            return new CustomerSpecifications();
        }

        [Specifications]
        public string GetFullName()
        {
            return this.CompanyName + " " + this.ContactName;
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

        [Specifications]
        public double TotalSpent
        {
            get
            {
                return GetSpecifications().HasTotalSpent ? GetSpecifications().TotalSpent : GetTotalSpent();
            }

            set
            {
                GetSpecifications().TotalSpent = value;
                GetSpecifications().HasTotalSpent = true;
            }
        }

        [Specifications]
        public double GetTotalSpent()
        {
            if (this.Orders == null)
                return default (double);
            return this.Orders.Sum(o =>
            {
                if (o == null)
                    return default (double);
                return o.GetTotal();
            }

            );
        }
    }
}
            