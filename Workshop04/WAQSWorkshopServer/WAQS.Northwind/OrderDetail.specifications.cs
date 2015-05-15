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
    partial class OrderDetail
    {
        [DataContract(Namespace = "http://Northwind/Entities")]
        public partial class OrderDetailSpecifications
        {
            [DataMember]
            public double Amount
            {
                get;
                set;
            }

            [DataMember]
            public bool HasAmount
            {
                get;
                set;
            }

            [DataMember]
            public string ProductFullName
            {
                get;
                set;
            }

            [DataMember]
            public bool HasProductFullName
            {
                get;
                set;
            }
        }

        [DataMember]
        public OrderDetailSpecifications Specifications
        {
            get;
            set;
        }

        protected OrderDetailSpecifications GetSpecifications()
        {
            return Specifications ?? (Specifications = GetSpecificationsOrderDetail());
        }

        protected virtual OrderDetailSpecifications GetSpecificationsOrderDetail()
        {
            return new OrderDetailSpecifications();
        }

        [Specifications]
        public double Amount
        {
            get
            {
                return GetSpecifications().HasAmount ? GetSpecifications().Amount : GetAmount();
            }

            set
            {
                GetSpecifications().Amount = value;
                GetSpecifications().HasAmount = true;
            }
        }

        [Specifications]
        public string GetProductFullName()
        {
            if (this.Product == null)
                return default (string);
            return this.Product.GetFullName();
        }

        [Specifications]
        public double GetAmount()
        {
            return this.UnitPrice * this.Quantity * (1 - this.Discount);
        }

        [Specifications]
        public string ProductFullName
        {
            get
            {
                return GetSpecifications().HasProductFullName ? GetSpecifications().ProductFullName : GetProductFullName();
            }

            set
            {
                GetSpecifications().ProductFullName = value;
                GetSpecifications().HasProductFullName = true;
            }
        }
    }
}
            