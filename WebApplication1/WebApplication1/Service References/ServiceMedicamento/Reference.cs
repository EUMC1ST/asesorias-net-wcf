﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceMedicamento {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicamentoCLS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Clases")]
    [System.SerializableAttribute()]
    public partial class MedicamentoCLS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idMedicamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal precioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string concentracionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreFormaFarmaceuticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string presentacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
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
        public int idMedicamento {
            get {
                return this.idMedicamentoField;
            }
            set {
                if ((this.idMedicamentoField.Equals(value) != true)) {
                    this.idMedicamentoField = value;
                    this.RaisePropertyChanged("idMedicamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal precio {
            get {
                return this.precioField;
            }
            set {
                if ((this.precioField.Equals(value) != true)) {
                    this.precioField = value;
                    this.RaisePropertyChanged("precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string concentracion {
            get {
                return this.concentracionField;
            }
            set {
                if ((object.ReferenceEquals(this.concentracionField, value) != true)) {
                    this.concentracionField = value;
                    this.RaisePropertyChanged("concentracion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string nombreFormaFarmaceutica {
            get {
                return this.nombreFormaFarmaceuticaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreFormaFarmaceuticaField, value) != true)) {
                    this.nombreFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("nombreFormaFarmaceutica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string presentacion {
            get {
                return this.presentacionField;
            }
            set {
                if ((object.ReferenceEquals(this.presentacionField, value) != true)) {
                    this.presentacionField = value;
                    this.RaisePropertyChanged("presentacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FormaFarmaceuticaCLS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Clases")]
    [System.SerializableAttribute()]
    public partial class FormaFarmaceuticaCLS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idFormaFarmaceuticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreFormaFarmaceuticaField;
        
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
        public int idFormaFarmaceutica {
            get {
                return this.idFormaFarmaceuticaField;
            }
            set {
                if ((this.idFormaFarmaceuticaField.Equals(value) != true)) {
                    this.idFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("idFormaFarmaceutica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreFormaFarmaceutica {
            get {
                return this.nombreFormaFarmaceuticaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreFormaFarmaceuticaField, value) != true)) {
                    this.nombreFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("nombreFormaFarmaceutica");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMedicamento.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarMedicamentos", ReplyAction="http://tempuri.org/IService1/listarMedicamentosResponse")]
        WebApplication1.ServiceMedicamento.MedicamentoCLS[] listarMedicamentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarMedicamentos", ReplyAction="http://tempuri.org/IService1/listarMedicamentosResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceMedicamento.MedicamentoCLS[]> listarMedicamentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarFormaFarmaceutica", ReplyAction="http://tempuri.org/IService1/listarFormaFarmaceuticaResponse")]
        WebApplication1.ServiceMedicamento.FormaFarmaceuticaCLS[] listarFormaFarmaceutica();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarFormaFarmaceutica", ReplyAction="http://tempuri.org/IService1/listarFormaFarmaceuticaResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceMedicamento.FormaFarmaceuticaCLS[]> listarFormaFarmaceuticaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/recuperarMedicamento", ReplyAction="http://tempuri.org/IService1/recuperarMedicamentoResponse")]
        WebApplication1.ServiceMedicamento.MedicamentoCLS recuperarMedicamento(int idMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/recuperarMedicamento", ReplyAction="http://tempuri.org/IService1/recuperarMedicamentoResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceMedicamento.MedicamentoCLS> recuperarMedicamentoAsync(int idMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/agregarEditarMedicamento", ReplyAction="http://tempuri.org/IService1/agregarEditarMedicamentoResponse")]
        int agregarEditarMedicamento(WebApplication1.ServiceMedicamento.MedicamentoCLS inputMedicamentoCLS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/agregarEditarMedicamento", ReplyAction="http://tempuri.org/IService1/agregarEditarMedicamentoResponse")]
        System.Threading.Tasks.Task<int> agregarEditarMedicamentoAsync(WebApplication1.ServiceMedicamento.MedicamentoCLS inputMedicamentoCLS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/eliminarMedicamento", ReplyAction="http://tempuri.org/IService1/eliminarMedicamentoResponse")]
        int eliminarMedicamento(int idMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/eliminarMedicamento", ReplyAction="http://tempuri.org/IService1/eliminarMedicamentoResponse")]
        System.Threading.Tasks.Task<int> eliminarMedicamentoAsync(int idMedicamento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceMedicamento.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceMedicamento.IService1>, WebApplication1.ServiceMedicamento.IService1 {
        
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
        
        public WebApplication1.ServiceMedicamento.MedicamentoCLS[] listarMedicamentos() {
            return base.Channel.listarMedicamentos();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceMedicamento.MedicamentoCLS[]> listarMedicamentosAsync() {
            return base.Channel.listarMedicamentosAsync();
        }
        
        public WebApplication1.ServiceMedicamento.FormaFarmaceuticaCLS[] listarFormaFarmaceutica() {
            return base.Channel.listarFormaFarmaceutica();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceMedicamento.FormaFarmaceuticaCLS[]> listarFormaFarmaceuticaAsync() {
            return base.Channel.listarFormaFarmaceuticaAsync();
        }
        
        public WebApplication1.ServiceMedicamento.MedicamentoCLS recuperarMedicamento(int idMedicamento) {
            return base.Channel.recuperarMedicamento(idMedicamento);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceMedicamento.MedicamentoCLS> recuperarMedicamentoAsync(int idMedicamento) {
            return base.Channel.recuperarMedicamentoAsync(idMedicamento);
        }
        
        public int agregarEditarMedicamento(WebApplication1.ServiceMedicamento.MedicamentoCLS inputMedicamentoCLS) {
            return base.Channel.agregarEditarMedicamento(inputMedicamentoCLS);
        }
        
        public System.Threading.Tasks.Task<int> agregarEditarMedicamentoAsync(WebApplication1.ServiceMedicamento.MedicamentoCLS inputMedicamentoCLS) {
            return base.Channel.agregarEditarMedicamentoAsync(inputMedicamentoCLS);
        }
        
        public int eliminarMedicamento(int idMedicamento) {
            return base.Channel.eliminarMedicamento(idMedicamento);
        }
        
        public System.Threading.Tasks.Task<int> eliminarMedicamentoAsync(int idMedicamento) {
            return base.Channel.eliminarMedicamentoAsync(idMedicamento);
        }
    }
}