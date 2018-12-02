﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChargeMate.SSDCARE {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SSDCARE.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectCarInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ChargeMate.SSDCARE.Cars[] SelectCarInfo(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectCarInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<ChargeMate.SSDCARE.Cars[]> SelectCarInfoAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindNearestCar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ChargeMate.SSDCARE.Cars[] FindNearestCar(int altitude, int latitude, decimal chargePercentage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindNearestCar", ReplyAction="*")]
        System.Threading.Tasks.Task<ChargeMate.SSDCARE.Cars[]> FindNearestCarAsync(int altitude, int latitude, decimal chargePercentage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCarInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateCarInfo(int ID, decimal latitude, decimal longitute, decimal latitudeTarget, decimal longituteTarget);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCarInfo", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateCarInfoAsync(int ID, decimal latitude, decimal longitute, decimal latitudeTarget, decimal longituteTarget);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetCarReserved", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SetCarReserved(int ID, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetCarReserved", ReplyAction="*")]
        System.Threading.Tasks.Task SetCarReservedAsync(int ID, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetCarPaired", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SetCarPaired(int ID, int IDTarget, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetCarPaired", ReplyAction="*")]
        System.Threading.Tasks.Task SetCarPairedAsync(int ID, int IDTarget, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getLocationCar1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getLocationCar1();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getLocationCar1", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getLocationCar1Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBatteryCharge", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getBatteryCharge();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBatteryCharge", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getBatteryChargeAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Cars : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string carNameField;
        
        private string carModelField;
        
        private string registerIdField;
        
        private string reputitionField;
        
        private System.Nullable<decimal> chargePercentField;
        
        private System.Nullable<decimal> latField;
        
        private System.Nullable<decimal> longField;
        
        private System.Nullable<decimal> targetLatField;
        
        private System.Nullable<decimal> targetLongField;
        
        private string isReservedField;
        
        private string isPairedField;
        
        private System.Nullable<int> pairedCarIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CarName {
            get {
                return this.carNameField;
            }
            set {
                this.carNameField = value;
                this.RaisePropertyChanged("CarName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CarModel {
            get {
                return this.carModelField;
            }
            set {
                this.carModelField = value;
                this.RaisePropertyChanged("CarModel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string RegisterId {
            get {
                return this.registerIdField;
            }
            set {
                this.registerIdField = value;
                this.RaisePropertyChanged("RegisterId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Reputition {
            get {
                return this.reputitionField;
            }
            set {
                this.reputitionField = value;
                this.RaisePropertyChanged("Reputition");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> ChargePercent {
            get {
                return this.chargePercentField;
            }
            set {
                this.chargePercentField = value;
                this.RaisePropertyChanged("ChargePercent");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<decimal> Lat {
            get {
                return this.latField;
            }
            set {
                this.latField = value;
                this.RaisePropertyChanged("Lat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<decimal> Long {
            get {
                return this.longField;
            }
            set {
                this.longField = value;
                this.RaisePropertyChanged("Long");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<decimal> TargetLat {
            get {
                return this.targetLatField;
            }
            set {
                this.targetLatField = value;
                this.RaisePropertyChanged("TargetLat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<decimal> TargetLong {
            get {
                return this.targetLongField;
            }
            set {
                this.targetLongField = value;
                this.RaisePropertyChanged("TargetLong");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string IsReserved {
            get {
                return this.isReservedField;
            }
            set {
                this.isReservedField = value;
                this.RaisePropertyChanged("IsReserved");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string IsPaired {
            get {
                return this.isPairedField;
            }
            set {
                this.isPairedField = value;
                this.RaisePropertyChanged("IsPaired");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> PairedCarId {
            get {
                return this.pairedCarIdField;
            }
            set {
                this.pairedCarIdField = value;
                this.RaisePropertyChanged("PairedCarId");
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
    public interface WebService1SoapChannel : ChargeMate.SSDCARE.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ChargeMate.SSDCARE.WebService1Soap>, ChargeMate.SSDCARE.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ChargeMate.SSDCARE.Cars[] SelectCarInfo(int ID) {
            return base.Channel.SelectCarInfo(ID);
        }
        
        public System.Threading.Tasks.Task<ChargeMate.SSDCARE.Cars[]> SelectCarInfoAsync(int ID) {
            return base.Channel.SelectCarInfoAsync(ID);
        }
        
        public ChargeMate.SSDCARE.Cars[] FindNearestCar(int altitude, int latitude, decimal chargePercentage) {
            return base.Channel.FindNearestCar(altitude, latitude, chargePercentage);
        }
        
        public System.Threading.Tasks.Task<ChargeMate.SSDCARE.Cars[]> FindNearestCarAsync(int altitude, int latitude, decimal chargePercentage) {
            return base.Channel.FindNearestCarAsync(altitude, latitude, chargePercentage);
        }
        
        public void UpdateCarInfo(int ID, decimal latitude, decimal longitute, decimal latitudeTarget, decimal longituteTarget) {
            base.Channel.UpdateCarInfo(ID, latitude, longitute, latitudeTarget, longituteTarget);
        }
        
        public System.Threading.Tasks.Task UpdateCarInfoAsync(int ID, decimal latitude, decimal longitute, decimal latitudeTarget, decimal longituteTarget) {
            return base.Channel.UpdateCarInfoAsync(ID, latitude, longitute, latitudeTarget, longituteTarget);
        }
        
        public void SetCarReserved(int ID, string status) {
            base.Channel.SetCarReserved(ID, status);
        }
        
        public System.Threading.Tasks.Task SetCarReservedAsync(int ID, string status) {
            return base.Channel.SetCarReservedAsync(ID, status);
        }
        
        public void SetCarPaired(int ID, int IDTarget, string status) {
            base.Channel.SetCarPaired(ID, IDTarget, status);
        }
        
        public System.Threading.Tasks.Task SetCarPairedAsync(int ID, int IDTarget, string status) {
            return base.Channel.SetCarPairedAsync(ID, IDTarget, status);
        }
        
        public string getLocationCar1() {
            return base.Channel.getLocationCar1();
        }
        
        public System.Threading.Tasks.Task<string> getLocationCar1Async() {
            return base.Channel.getLocationCar1Async();
        }
        
        public string getBatteryCharge() {
            return base.Channel.getBatteryCharge();
        }
        
        public System.Threading.Tasks.Task<string> getBatteryChargeAsync() {
            return base.Channel.getBatteryChargeAsync();
        }
    }
}