﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISS_Client.Soap_Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoapGame", Namespace="http://schemas.datacontract.org/2004/07/SOAP_WCF")]
    [System.SerializableAttribute()]
    public partial class SoapGame : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string appIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imgUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string releseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string reviewSummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string urlField;
        
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
        public string appID {
            get {
                return this.appIDField;
            }
            set {
                if ((object.ReferenceEquals(this.appIDField, value) != true)) {
                    this.appIDField = value;
                    this.RaisePropertyChanged("appID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imgUrl {
            get {
                return this.imgUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.imgUrlField, value) != true)) {
                    this.imgUrlField = value;
                    this.RaisePropertyChanged("imgUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string price {
            get {
                return this.priceField;
            }
            set {
                if ((object.ReferenceEquals(this.priceField, value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string releseDate {
            get {
                return this.releseDateField;
            }
            set {
                if ((object.ReferenceEquals(this.releseDateField, value) != true)) {
                    this.releseDateField = value;
                    this.RaisePropertyChanged("releseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string reviewSummary {
            get {
                return this.reviewSummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.reviewSummaryField, value) != true)) {
                    this.reviewSummaryField = value;
                    this.RaisePropertyChanged("reviewSummary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                if ((object.ReferenceEquals(this.urlField, value) != true)) {
                    this.urlField = value;
                    this.RaisePropertyChanged("url");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Soap_Service.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateXML", ReplyAction="http://tempuri.org/IService1/GenerateXMLResponse")]
        string GenerateXML();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateXML", ReplyAction="http://tempuri.org/IService1/GenerateXMLResponse")]
        System.Threading.Tasks.Task<string> GenerateXMLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDocument", ReplyAction="http://tempuri.org/IService1/GetDocumentResponse")]
        ISS_Client.Soap_Service.SoapGame[] GetDocument(string searchTerm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDocument", ReplyAction="http://tempuri.org/IService1/GetDocumentResponse")]
        System.Threading.Tasks.Task<ISS_Client.Soap_Service.SoapGame[]> GetDocumentAsync(string searchTerm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ISS_Client.Soap_Service.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ISS_Client.Soap_Service.IService1>, ISS_Client.Soap_Service.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GenerateXML() {
            return base.Channel.GenerateXML();
        }
        
        public System.Threading.Tasks.Task<string> GenerateXMLAsync() {
            return base.Channel.GenerateXMLAsync();
        }
        
        public ISS_Client.Soap_Service.SoapGame[] GetDocument(string searchTerm) {
            return base.Channel.GetDocument(searchTerm);
        }
        
        public System.Threading.Tasks.Task<ISS_Client.Soap_Service.SoapGame[]> GetDocumentAsync(string searchTerm) {
            return base.Channel.GetDocumentAsync(searchTerm);
        }
    }
}
