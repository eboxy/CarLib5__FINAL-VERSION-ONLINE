﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarClient.CarServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/Car.Entities")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarServiceReference.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetCars", ReplyAction="http://tempuri.org/ICarService/GetCarsResponse")]
        CarClient.CarServiceReference.Car[] GetCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetCars", ReplyAction="http://tempuri.org/ICarService/GetCarsResponse")]
        System.Threading.Tasks.Task<CarClient.CarServiceReference.Car[]> GetCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Add", ReplyAction="http://tempuri.org/ICarService/AddResponse")]
        void Add(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Add", ReplyAction="http://tempuri.org/ICarService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Delete", ReplyAction="http://tempuri.org/ICarService/DeleteResponse")]
        void Delete(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Delete", ReplyAction="http://tempuri.org/ICarService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Update", ReplyAction="http://tempuri.org/ICarService/UpdateResponse")]
        void Update(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Update", ReplyAction="http://tempuri.org/ICarService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Save", ReplyAction="http://tempuri.org/ICarService/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Save", ReplyAction="http://tempuri.org/ICarService/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : CarClient.CarServiceReference.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<CarClient.CarServiceReference.ICarService>, CarClient.CarServiceReference.ICarService {
        
        public CarServiceClient() {
        }
        
        public CarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CarClient.CarServiceReference.Car[] GetCars() {
            return base.Channel.GetCars();
        }
        
        public System.Threading.Tasks.Task<CarClient.CarServiceReference.Car[]> GetCarsAsync() {
            return base.Channel.GetCarsAsync();
        }
        
        public void Add(CarClient.CarServiceReference.Car car) {
            base.Channel.Add(car);
        }
        
        public System.Threading.Tasks.Task AddAsync(CarClient.CarServiceReference.Car car) {
            return base.Channel.AddAsync(car);
        }
        
        public void Delete(CarClient.CarServiceReference.Car car) {
            base.Channel.Delete(car);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(CarClient.CarServiceReference.Car car) {
            return base.Channel.DeleteAsync(car);
        }
        
        public void Update(CarClient.CarServiceReference.Car car) {
            base.Channel.Update(car);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(CarClient.CarServiceReference.Car car) {
            return base.Channel.UpdateAsync(car);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
    }
}
