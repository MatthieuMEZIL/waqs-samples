//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;
using WAQS.Entities;

namespace WAQSWorkshopServer
{
    [DataContract(IsReference = true, Namespace = "http://Northwind/Entities")]
    [KnownType(typeof(Customer))]
    [KnownType(typeof(Employee))]
    [KnownType(typeof(Invoice))]
    [KnownType(typeof(OrderDetail))]
    public partial class Order : IEntity
    {
        public Order()
        {
            EntitiesInitializer.Initialize(this);
            OrderInitialize();
        }
        partial void OrderInitialize();
    
    #region Simple Properties
        [DataMember]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;
    
                OnIdChanging(ref value);
                if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    throw new InvalidOperationException("The property 'Id' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                _id = value;
                OnIdChanged(value);
                OnPropertyChanged("Id");
            }
        }
        private int _id;
        partial void OnIdChanging(ref int value);
        partial void OnIdChanged(int value);
        [DataMember]
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId == value)
                    return;
    
                OnCustomerIdChanging(ref value);
                if (!IsDeserializing)
                {
                    if (Customer != null && Customer.Id != value)
                    {
                        Customer = null;
                    }
                }
                if (value != null)
                    value = value.PadRight(5);
                _customerId = value;
                OnCustomerIdChanged(value);
                OnPropertyChanged("CustomerId");
            }
        }
        private string _customerId;
        partial void OnCustomerIdChanging(ref string value);
        partial void OnCustomerIdChanged(string value);
        [DataMember]
        public Nullable<int> EmployeeId
        {
            get { return _employeeId; }
            set
            {
                if (_employeeId == value)
                    return;
    
                OnEmployeeIdChanging(ref value);
                if (!IsDeserializing)
                {
                    if (Employee != null && Employee.Id != value)
                    {
                        Employee = null;
                    }
                }
                _employeeId = value;
                OnEmployeeIdChanged(value);
                OnPropertyChanged("EmployeeId");
            }
        }
        private Nullable<int> _employeeId;
        partial void OnEmployeeIdChanging(ref Nullable<int> value);
        partial void OnEmployeeIdChanged(Nullable<int> value);
        [DataMember]
        public System.DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                if (_orderDate == value)
                    return;
    
                OnOrderDateChanging(ref value);
                _orderDate = value;
                OnOrderDateChanged(value);
                OnPropertyChanged("OrderDate");
            }
        }
        private System.DateTime _orderDate;
        partial void OnOrderDateChanging(ref System.DateTime value);
        partial void OnOrderDateChanged(System.DateTime value);
        [DataMember]
        public Nullable<System.DateTime> RequiredDate
        {
            get { return _requiredDate; }
            set
            {
                if (_requiredDate == value)
                    return;
    
                OnRequiredDateChanging(ref value);
                _requiredDate = value;
                OnRequiredDateChanged(value);
                OnPropertyChanged("RequiredDate");
            }
        }
        private Nullable<System.DateTime> _requiredDate;
        partial void OnRequiredDateChanging(ref Nullable<System.DateTime> value);
        partial void OnRequiredDateChanged(Nullable<System.DateTime> value);
        [DataMember]
        public Nullable<System.DateTime> ShippedDate
        {
            get { return _shippedDate; }
            set
            {
                if (_shippedDate == value)
                    return;
    
                OnShippedDateChanging(ref value);
                _shippedDate = value;
                OnShippedDateChanged(value);
                OnPropertyChanged("ShippedDate");
            }
        }
        private Nullable<System.DateTime> _shippedDate;
        partial void OnShippedDateChanging(ref Nullable<System.DateTime> value);
        partial void OnShippedDateChanged(Nullable<System.DateTime> value);
        [DataMember]
        public Nullable<int> ShipVia
        {
            get { return _shipVia; }
            set
            {
                if (_shipVia == value)
                    return;
    
                OnShipViaChanging(ref value);
                _shipVia = value;
                OnShipViaChanged(value);
                OnPropertyChanged("ShipVia");
            }
        }
        private Nullable<int> _shipVia;
        partial void OnShipViaChanging(ref Nullable<int> value);
        partial void OnShipViaChanged(Nullable<int> value);
        [DataMember]
        public Nullable<decimal> Freight
        {
            get { return _freight; }
            set
            {
                if (_freight == value)
                    return;
    
                OnFreightChanging(ref value);
                _freight = value;
                OnFreightChanged(value);
                OnPropertyChanged("Freight");
            }
        }
        private Nullable<decimal> _freight;
        partial void OnFreightChanging(ref Nullable<decimal> value);
        partial void OnFreightChanged(Nullable<decimal> value);
        [DataMember]
        public string ShipName
        {
            get { return _shipName; }
            set
            {
                if (_shipName == value)
                    return;
    
                OnShipNameChanging(ref value);
                _shipName = value;
                OnShipNameChanged(value);
                OnPropertyChanged("ShipName");
            }
        }
        private string _shipName;
        partial void OnShipNameChanging(ref string value);
        partial void OnShipNameChanged(string value);
        [DataMember]
        public string ShipAddress
        {
            get { return _shipAddress; }
            set
            {
                if (_shipAddress == value)
                    return;
    
                OnShipAddressChanging(ref value);
                _shipAddress = value;
                OnShipAddressChanged(value);
                OnPropertyChanged("ShipAddress");
            }
        }
        private string _shipAddress;
        partial void OnShipAddressChanging(ref string value);
        partial void OnShipAddressChanged(string value);
        [DataMember]
        public string ShipCity
        {
            get { return _shipCity; }
            set
            {
                if (_shipCity == value)
                    return;
    
                OnShipCityChanging(ref value);
                _shipCity = value;
                OnShipCityChanged(value);
                OnPropertyChanged("ShipCity");
            }
        }
        private string _shipCity;
        partial void OnShipCityChanging(ref string value);
        partial void OnShipCityChanged(string value);
        [DataMember]
        public string ShipRegion
        {
            get { return _shipRegion; }
            set
            {
                if (_shipRegion == value)
                    return;
    
                OnShipRegionChanging(ref value);
                _shipRegion = value;
                OnShipRegionChanged(value);
                OnPropertyChanged("ShipRegion");
            }
        }
        private string _shipRegion;
        partial void OnShipRegionChanging(ref string value);
        partial void OnShipRegionChanged(string value);
        [DataMember]
        public string ShipPostalCode
        {
            get { return _shipPostalCode; }
            set
            {
                if (_shipPostalCode == value)
                    return;
    
                OnShipPostalCodeChanging(ref value);
                _shipPostalCode = value;
                OnShipPostalCodeChanged(value);
                OnPropertyChanged("ShipPostalCode");
            }
        }
        private string _shipPostalCode;
        partial void OnShipPostalCodeChanging(ref string value);
        partial void OnShipPostalCodeChanged(string value);
        [DataMember]
        public string ShipCountry
        {
            get { return _shipCountry; }
            set
            {
                if (_shipCountry == value)
                    return;
    
                OnShipCountryChanging(ref value);
                _shipCountry = value;
                OnShipCountryChanged(value);
                OnPropertyChanged("ShipCountry");
            }
        }
        private string _shipCountry;
        partial void OnShipCountryChanging(ref string value);
        partial void OnShipCountryChanged(string value);

    #endregion

    #region Navigation Properties
        [DataMember]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (ReferenceEquals(_customer, value))
                    return;
    
                OnCustomerChanging(ref value);
                var previousValue = _customer;
                if (!(IsDeserializing || ChangeTracker.State == ObjectState.Added || ChangeTracker.ObjectsRemovedFromCollectionProperties.ContainsKey("Customer")))
                    ChangeTracker.RecordRemovalFromCollectionProperties("Customer", previousValue);
                _customer = value;
                FixupCustomer(previousValue);
                OnCustomerChanged(value);
                OnNavigationPropertyChanged("Customer");
            }
        }
        partial void OnCustomerChanging(ref Customer value);
        partial void OnCustomerChanged(Customer value);
        private Customer _customer;
        [DataMember]
        public Employee Employee
        {
            get { return _employee; }
            set
            {
                if (ReferenceEquals(_employee, value))
                    return;
    
                OnEmployeeChanging(ref value);
                var previousValue = _employee;
                if (!(IsDeserializing || ChangeTracker.State == ObjectState.Added || ChangeTracker.ObjectsRemovedFromCollectionProperties.ContainsKey("Employee")))
                    ChangeTracker.RecordRemovalFromCollectionProperties("Employee", previousValue);
                _employee = value;
                FixupEmployee(previousValue);
                OnEmployeeChanged(value);
                OnNavigationPropertyChanged("Employee");
            }
        }
        partial void OnEmployeeChanging(ref Employee value);
        partial void OnEmployeeChanged(Employee value);
        private Employee _employee;
        [DataMember]
        public Invoice Invoice
        {
            get { return _invoice; }
            set
            {
                if (ReferenceEquals(_invoice, value))
                    return;
    
                OnInvoiceChanging(ref value);
                var previousValue = _invoice;
                if (!(IsDeserializing || ChangeTracker.State == ObjectState.Added || ChangeTracker.ObjectsRemovedFromCollectionProperties.ContainsKey("Invoice")))
                    ChangeTracker.RecordRemovalFromCollectionProperties("Invoice", previousValue);
                _invoice = value;
                FixupInvoice(previousValue);
                OnInvoiceChanged(value);
                OnNavigationPropertyChanged("Invoice");
            }
        }
        partial void OnInvoiceChanging(ref Invoice value);
        partial void OnInvoiceChanged(Invoice value);
        private Invoice _invoice;
        [DataMember]
        public TrackableCollection<OrderDetail> OrderDetails
        {
            get
            {
                if (_orderDetails == null)
                {
                    _orderDetails = new TrackableCollection<OrderDetail>() { Owner = this, Name = "OrderDetails" };
                    _orderDetails.CollectionChanged += FixupOrderDetails;
                }
                return _orderDetails;
            }
            set
            {
                if (ReferenceEquals(_orderDetails, value))
                    return;
    
                if (ChangeTracker.ChangeTrackingEnabled)
                    throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
    
                if (_orderDetails != null)
                {
                    _orderDetails.CollectionChanged -= FixupOrderDetails;
                }
                _orderDetails = value;
                if (_orderDetails != null)
                {
                    _orderDetails.Owner = this;
                    _orderDetails.Name = "OrderDetails";
                    _orderDetails.CollectionChanged += FixupOrderDetails;
                }
                OnNavigationPropertyChanged("OrderDetails");
            }
        }
        private TrackableCollection<OrderDetail> _orderDetails;

    #endregion

    #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
                if (! (IsDeserializing || ChangeTracker.ModifiedProperties.Contains(propertyName)))
                    ChangeTracker.ModifiedProperties.Add(propertyName);
            }
            OnCustomPropertyChanged(propertyName);
        }
        partial void OnCustomPropertyChanged(string propertyName);
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            OnCustomNavigationPropertyChanged(propertyName);
        }
        partial void OnCustomNavigationPropertyChanged(string propertyName);
    
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                _changeTracker = value;
                if(_changeTracker != null)
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            switch (e.NewState)
            {
                case ObjectState.Deleted:
                    IsDeleting = true;
                    ClearNavigationProperties();
                    IsDeleting = false;
                    break;
                case ObjectState.Detached:
                    ClearNavigationProperties();
                    break;
            }
        }
        
        private bool _isDeserializing;
        public bool IsDeserializing 
        { 
            get { return _isDeserializing; } 
            set 
            { 
                if (_isDeserializing == value)
                    return;
                _isDeserializing = value; 
            }
        }
        public bool IsInitializingRelationships { get; set; }
    
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Customer = null;
            Employee = null;
            Invoice = null;
            OrderDetails.Clear();
        }

    #endregion

    #region Association Fixup
        private bool IsDeleting { get; set; }
        internal virtual void Detach()
        {
            ChangeTracker.State = ObjectState.Detached;
        }
    
        private void FixupCustomer(Customer previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
                return;
    
            if (previousValue != null && previousValue.Orders.Contains(this))
                previousValue.Orders.Remove(this);
    
            if (Customer != null)
            {
                if (!Customer.Orders.Contains(this))
                    Customer.Orders.Add(this);
    
                CustomerId = Customer.Id;
            }
            else if (! (skipKeys || IsDeleting || previousValue.ChangeTracker.State == ObjectState.Detached))
            {
                CustomerId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Customer")
                    && (ChangeTracker.OriginalValues["Customer"] == Customer))
                    ChangeTracker.OriginalValues.Remove("Customer");
                else
                {
                    ChangeTracker.RecordOriginalValue("Customer", previousValue);
                }
                if (Customer != null && !Customer.ChangeTracker.ChangeTrackingEnabled)
                    Customer.ChangeTracker.ChangeTrackingEnabled = true;
            }
        }
    
        private void FixupEmployee(Employee previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
                return;
    
            if (previousValue != null && previousValue.Orders.Contains(this))
                previousValue.Orders.Remove(this);
    
            if (Employee != null)
            {
                if (!Employee.Orders.Contains(this))
                    Employee.Orders.Add(this);
    
                EmployeeId = Employee.Id;
            }
            else if (! (skipKeys || IsDeleting || previousValue.ChangeTracker.State == ObjectState.Detached))
            {
                EmployeeId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Employee")
                    && (ChangeTracker.OriginalValues["Employee"] == Employee))
                    ChangeTracker.OriginalValues.Remove("Employee");
                else
                {
                    ChangeTracker.RecordOriginalValue("Employee", previousValue);
                }
                if (Employee != null && !Employee.ChangeTracker.ChangeTrackingEnabled)
                    Employee.ChangeTracker.ChangeTrackingEnabled = true;
            }
        }
    
        private void FixupInvoice(Invoice previousValue)
        {
            // This is the principal end in an association that performs cascade deletes.
            // Update the event listener to refer to the new dependent.
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (Invoice != null)
            {
                ChangeTracker.ObjectStateChanging += Invoice.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
                return;
    
            if (previousValue != null && ReferenceEquals(previousValue.Order, this))
                previousValue.Order = null;
    
            if (Invoice != null)
            {
                Invoice.Order = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Invoice")
                    && (ChangeTracker.OriginalValues["Invoice"] == Invoice))
                    ChangeTracker.OriginalValues.Remove("Invoice");
                else
                {
                    ChangeTracker.RecordOriginalValue("Invoice", previousValue);
                    // This is the principal end of an identifying association, so the dependent must be deleted when the relationship is removed.
                    // If the current state of the dependent is Added, the relationship can be changed without causing the dependent to be deleted.
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                        previousValue.MarkAsDeleted();
                }
                if (Invoice != null && !Invoice.ChangeTracker.ChangeTrackingEnabled)
                    Invoice.ChangeTracker.ChangeTrackingEnabled = true;
            }
        }
    
        private void FixupOrderDetails(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
                return;
    
            if (e.NewItems != null)
            {
                foreach (OrderDetail item in e.NewItems)
                {
                    item.Order = this;
                    if (ChangeTracker != null && ChangeTracker.ChangeTrackingEnabled && item.ChangeTracker != null && item.ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                            item.MarkAsAdded();
                        ChangeTracker.RecordAdditionToCollectionProperties("OrderDetails", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (OrderDetail item in e.OldItems)
                {
                    if (ReferenceEquals(item.Order, this))
                    {
                        item.Order = null;
                    }
                    if (ChangeTracker != null && ChangeTracker.ChangeTrackingEnabled && item.ChangeTracker != null && item.ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("OrderDetails", item);
                    }
                }
            }
        }

    #endregion

     
    #region EntityKey
        private Guid? _dataTransferEntityKey;
        [DataMember]
        public virtual Guid DataTransferEntityKey 
        { 
            get { return _dataTransferEntityKey ?? (_dataTransferEntityKey = Guid.NewGuid()).Value; }
            set { _dataTransferEntityKey = value; } 
        }

    #endregion

    
        void IEntity.RemoveNavigationProperties()
        {
            Customer = null;
            Employee = null;
            Invoice = null;
            OrderDetails.Clear();
        }
    }
}
