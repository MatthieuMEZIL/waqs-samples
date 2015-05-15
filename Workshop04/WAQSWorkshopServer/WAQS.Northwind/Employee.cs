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
    [KnownType(typeof(Employee))]
    [KnownType(typeof(Order))]
    public partial class Employee : IEntity
    {
        public Employee()
        {
            EntitiesInitializer.Initialize(this);
            EmployeeInitialize();
        }
        partial void EmployeeInitialize();
    
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
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value)
                    return;
    
                OnLastNameChanging(ref value);
                _lastName = value;
                OnLastNameChanged(value);
                OnPropertyChanged("LastName");
            }
        }
        private string _lastName;
        partial void OnLastNameChanging(ref string value);
        partial void OnLastNameChanged(string value);
        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                    return;
    
                OnFirstNameChanging(ref value);
                _firstName = value;
                OnFirstNameChanged(value);
                OnPropertyChanged("FirstName");
            }
        }
        private string _firstName;
        partial void OnFirstNameChanging(ref string value);
        partial void OnFirstNameChanged(string value);
        [DataMember]
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value)
                    return;
    
                OnTitleChanging(ref value);
                _title = value;
                OnTitleChanged(value);
                OnPropertyChanged("Title");
            }
        }
        private string _title;
        partial void OnTitleChanging(ref string value);
        partial void OnTitleChanged(string value);
        [DataMember]
        public string TitleOfCourtesy
        {
            get { return _titleOfCourtesy; }
            set
            {
                if (_titleOfCourtesy == value)
                    return;
    
                OnTitleOfCourtesyChanging(ref value);
                _titleOfCourtesy = value;
                OnTitleOfCourtesyChanged(value);
                OnPropertyChanged("TitleOfCourtesy");
            }
        }
        private string _titleOfCourtesy;
        partial void OnTitleOfCourtesyChanging(ref string value);
        partial void OnTitleOfCourtesyChanged(string value);
        [DataMember]
        public Nullable<System.DateTime> BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate == value)
                    return;
    
                OnBirthDateChanging(ref value);
                _birthDate = value;
                OnBirthDateChanged(value);
                OnPropertyChanged("BirthDate");
            }
        }
        private Nullable<System.DateTime> _birthDate;
        partial void OnBirthDateChanging(ref Nullable<System.DateTime> value);
        partial void OnBirthDateChanged(Nullable<System.DateTime> value);
        [DataMember]
        public Nullable<System.DateTime> HireDate
        {
            get { return _hireDate; }
            set
            {
                if (_hireDate == value)
                    return;
    
                OnHireDateChanging(ref value);
                _hireDate = value;
                OnHireDateChanged(value);
                OnPropertyChanged("HireDate");
            }
        }
        private Nullable<System.DateTime> _hireDate;
        partial void OnHireDateChanging(ref Nullable<System.DateTime> value);
        partial void OnHireDateChanged(Nullable<System.DateTime> value);
        [DataMember]
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address == value)
                    return;
    
                OnAddressChanging(ref value);
                _address = value;
                OnAddressChanged(value);
                OnPropertyChanged("Address");
            }
        }
        private string _address;
        partial void OnAddressChanging(ref string value);
        partial void OnAddressChanged(string value);
        [DataMember]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city == value)
                    return;
    
                OnCityChanging(ref value);
                _city = value;
                OnCityChanged(value);
                OnPropertyChanged("City");
            }
        }
        private string _city;
        partial void OnCityChanging(ref string value);
        partial void OnCityChanged(string value);
        [DataMember]
        public string Region
        {
            get { return _region; }
            set
            {
                if (_region == value)
                    return;
    
                OnRegionChanging(ref value);
                _region = value;
                OnRegionChanged(value);
                OnPropertyChanged("Region");
            }
        }
        private string _region;
        partial void OnRegionChanging(ref string value);
        partial void OnRegionChanged(string value);
        [DataMember]
        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (_postalCode == value)
                    return;
    
                OnPostalCodeChanging(ref value);
                _postalCode = value;
                OnPostalCodeChanged(value);
                OnPropertyChanged("PostalCode");
            }
        }
        private string _postalCode;
        partial void OnPostalCodeChanging(ref string value);
        partial void OnPostalCodeChanged(string value);
        [DataMember]
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country == value)
                    return;
    
                OnCountryChanging(ref value);
                _country = value;
                OnCountryChanged(value);
                OnPropertyChanged("Country");
            }
        }
        private string _country;
        partial void OnCountryChanging(ref string value);
        partial void OnCountryChanged(string value);
        [DataMember]
        public string HomePhone
        {
            get { return _homePhone; }
            set
            {
                if (_homePhone == value)
                    return;
    
                OnHomePhoneChanging(ref value);
                _homePhone = value;
                OnHomePhoneChanged(value);
                OnPropertyChanged("HomePhone");
            }
        }
        private string _homePhone;
        partial void OnHomePhoneChanging(ref string value);
        partial void OnHomePhoneChanged(string value);
        [DataMember]
        public string Extension
        {
            get { return _extension; }
            set
            {
                if (_extension == value)
                    return;
    
                OnExtensionChanging(ref value);
                _extension = value;
                OnExtensionChanged(value);
                OnPropertyChanged("Extension");
            }
        }
        private string _extension;
        partial void OnExtensionChanging(ref string value);
        partial void OnExtensionChanged(string value);
        [DataMember]
        public byte[] Photo
        {
            get { return _photo; }
            set
            {
                if (_photo == value)
                    return;
    
                OnPhotoChanging(ref value);
                _photo = value;
                OnPhotoChanged(value);
                OnPropertyChanged("Photo");
            }
        }
        private byte[] _photo;
        partial void OnPhotoChanging(ref byte[] value);
        partial void OnPhotoChanged(byte[] value);
        [DataMember]
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes == value)
                    return;
    
                OnNotesChanging(ref value);
                _notes = value;
                OnNotesChanged(value);
                OnPropertyChanged("Notes");
            }
        }
        private string _notes;
        partial void OnNotesChanging(ref string value);
        partial void OnNotesChanged(string value);
        [DataMember]
        public Nullable<int> ReportsTo
        {
            get { return _reportsTo; }
            set
            {
                if (_reportsTo == value)
                    return;
    
                OnReportsToChanging(ref value);
                if (!IsDeserializing)
                {
                    if (Employee1 != null && Employee1.Id != value)
                    {
                        Employee1 = null;
                    }
                }
                _reportsTo = value;
                OnReportsToChanged(value);
                OnPropertyChanged("ReportsTo");
            }
        }
        private Nullable<int> _reportsTo;
        partial void OnReportsToChanging(ref Nullable<int> value);
        partial void OnReportsToChanged(Nullable<int> value);
        [DataMember]
        public string PhotoPath
        {
            get { return _photoPath; }
            set
            {
                if (_photoPath == value)
                    return;
    
                OnPhotoPathChanging(ref value);
                _photoPath = value;
                OnPhotoPathChanged(value);
                OnPropertyChanged("PhotoPath");
            }
        }
        private string _photoPath;
        partial void OnPhotoPathChanging(ref string value);
        partial void OnPhotoPathChanged(string value);

    #endregion

    #region Navigation Properties
        [DataMember]
        public TrackableCollection<Employee> Employees1
        {
            get
            {
                if (_employees1 == null)
                {
                    _employees1 = new TrackableCollection<Employee>() { Owner = this, Name = "Employees1" };
                    _employees1.CollectionChanged += FixupEmployees1;
                }
                return _employees1;
            }
            set
            {
                if (ReferenceEquals(_employees1, value))
                    return;
    
                if (ChangeTracker.ChangeTrackingEnabled)
                    throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
    
                if (_employees1 != null)
                {
                    _employees1.CollectionChanged -= FixupEmployees1;
                }
                _employees1 = value;
                if (_employees1 != null)
                {
                    _employees1.Owner = this;
                    _employees1.Name = "Employees1";
                    _employees1.CollectionChanged += FixupEmployees1;
                }
                OnNavigationPropertyChanged("Employees1");
            }
        }
        private TrackableCollection<Employee> _employees1;
        [DataMember]
        public Employee Employee1
        {
            get { return _employee1; }
            set
            {
                if (ReferenceEquals(_employee1, value))
                    return;
    
                OnEmployee1Changing(ref value);
                var previousValue = _employee1;
                if (!(IsDeserializing || ChangeTracker.State == ObjectState.Added || ChangeTracker.ObjectsRemovedFromCollectionProperties.ContainsKey("Employee1")))
                    ChangeTracker.RecordRemovalFromCollectionProperties("Employee1", previousValue);
                _employee1 = value;
                FixupEmployee1(previousValue);
                OnEmployee1Changed(value);
                OnNavigationPropertyChanged("Employee1");
            }
        }
        partial void OnEmployee1Changing(ref Employee value);
        partial void OnEmployee1Changed(Employee value);
        private Employee _employee1;
        [DataMember]
        public TrackableCollection<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new TrackableCollection<Order>() { Owner = this, Name = "Orders" };
                    _orders.CollectionChanged += FixupOrders;
                }
                return _orders;
            }
            set
            {
                if (ReferenceEquals(_orders, value))
                    return;
    
                if (ChangeTracker.ChangeTrackingEnabled)
                    throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
    
                if (_orders != null)
                {
                    _orders.CollectionChanged -= FixupOrders;
                }
                _orders = value;
                if (_orders != null)
                {
                    _orders.Owner = this;
                    _orders.Name = "Orders";
                    _orders.CollectionChanged += FixupOrders;
                }
                OnNavigationPropertyChanged("Orders");
            }
        }
        private TrackableCollection<Order> _orders;

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
            Employees1.Clear();
            Employee1 = null;
            Orders.Clear();
        }

    #endregion

    #region Association Fixup
        private bool IsDeleting { get; set; }
        internal virtual void Detach()
        {
            ChangeTracker.State = ObjectState.Detached;
        }
    
        private void FixupEmployee1(Employee previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
                return;
    
            if (previousValue != null && previousValue.Employees1.Contains(this))
                previousValue.Employees1.Remove(this);
    
            if (Employee1 != null)
            {
                if (!Employee1.Employees1.Contains(this))
                    Employee1.Employees1.Add(this);
    
                ReportsTo = Employee1.Id;
            }
            else if (! (skipKeys || IsDeleting || previousValue.ChangeTracker.State == ObjectState.Detached))
            {
                ReportsTo = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Employee1")
                    && (ChangeTracker.OriginalValues["Employee1"] == Employee1))
                    ChangeTracker.OriginalValues.Remove("Employee1");
                else
                {
                    ChangeTracker.RecordOriginalValue("Employee1", previousValue);
                }
                if (Employee1 != null && !Employee1.ChangeTracker.ChangeTrackingEnabled)
                    Employee1.ChangeTracker.ChangeTrackingEnabled = true;
            }
        }
    
        private void FixupEmployees1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
                return;
    
            if (e.NewItems != null)
            {
                foreach (Employee item in e.NewItems)
                {
                    item.Employee1 = this;
                    if (ChangeTracker != null && ChangeTracker.ChangeTrackingEnabled && item.ChangeTracker != null && item.ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                            item.MarkAsAdded();
                        ChangeTracker.RecordAdditionToCollectionProperties("Employees1", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Employee item in e.OldItems)
                {
                    if (ReferenceEquals(item.Employee1, this))
                    {
                        item.Employee1 = null;
                    }
                    if (ChangeTracker != null && ChangeTracker.ChangeTrackingEnabled && item.ChangeTracker != null && item.ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Employees1", item);
                    }
                }
            }
        }
    
        private void FixupOrders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
                return;
    
            if (e.NewItems != null)
            {
                foreach (Order item in e.NewItems)
                {
                    item.Employee = this;
                    if (ChangeTracker != null && ChangeTracker.ChangeTrackingEnabled && item.ChangeTracker != null && item.ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                            item.MarkAsAdded();
                        ChangeTracker.RecordAdditionToCollectionProperties("Orders", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Order item in e.OldItems)
                {
                    if (ReferenceEquals(item.Employee, this))
                    {
                        item.Employee = null;
                    }
                    if (ChangeTracker != null && ChangeTracker.ChangeTrackingEnabled && item.ChangeTracker != null && item.ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Orders", item);
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
            Employees1.Clear();
            Employee1 = null;
            Orders.Clear();
        }
    }
}