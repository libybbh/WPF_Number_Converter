﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfNumberConverter_lab.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.Request[] RequestsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
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
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.Request[] Requests {
            get {
                return this.RequestsField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestsField, value) != true)) {
                    this.RequestsField = value;
                    this.RaisePropertyChanged("Requests");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://schemas.datacontract.org/2004/07/WcfNumberConverter_lab.Models")]
    [System.SerializableAttribute()]
    public partial class Request : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ArabNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RomanNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User UsersRequestsField;
        
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
        public int ArabNumber {
            get {
                return this.ArabNumberField;
            }
            set {
                if ((this.ArabNumberField.Equals(value) != true)) {
                    this.ArabNumberField = value;
                    this.RaisePropertyChanged("ArabNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
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
        public string RomanNumber {
            get {
                return this.RomanNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.RomanNumberField, value) != true)) {
                    this.RomanNumberField = value;
                    this.RaisePropertyChanged("RomanNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User UsersRequests {
            get {
                return this.UsersRequestsField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersRequestsField, value) != true)) {
                    this.UsersRequestsField = value;
                    this.RaisePropertyChanged("UsersRequests");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersRequests", ReplyAction="http://tempuri.org/IService1/GetUsersRequestsResponse")]
        KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.Request[] GetUsersRequests(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersRequests", ReplyAction="http://tempuri.org/IService1/GetUsersRequestsResponse")]
        System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.Request[]> GetUsersRequestsAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        void AddUser(KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfUserExists", ReplyAction="http://tempuri.org/IService1/checkIfUserExistsResponse")]
        KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User checkIfUserExists(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfUserExists", ReplyAction="http://tempuri.org/IService1/checkIfUserExistsResponse")]
        System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User> checkIfUserExistsAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfUserExistsBool", ReplyAction="http://tempuri.org/IService1/checkIfUserExistsBoolResponse")]
        bool checkIfUserExistsBool(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfUserExistsBool", ReplyAction="http://tempuri.org/IService1/checkIfUserExistsBoolResponse")]
        System.Threading.Tasks.Task<bool> checkIfUserExistsBoolAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfUserExistsByLogin", ReplyAction="http://tempuri.org/IService1/checkIfUserExistsByLoginResponse")]
        KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User checkIfUserExistsByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfUserExistsByLogin", ReplyAction="http://tempuri.org/IService1/checkIfUserExistsByLoginResponse")]
        System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User> checkIfUserExistsByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUserRequest", ReplyAction="http://tempuri.org/IService1/AddUserRequestResponse")]
        string AddUserRequest(string login, int ArabNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUserRequest", ReplyAction="http://tempuri.org/IService1/AddUserRequestResponse")]
        System.Threading.Tasks.Task<string> AddUserRequestAsync(string login, int ArabNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ArabicToRoman", ReplyAction="http://tempuri.org/IService1/ArabicToRomanResponse")]
        string ArabicToRoman(int arabic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ArabicToRoman", ReplyAction="http://tempuri.org/IService1/ArabicToRomanResponse")]
        System.Threading.Tasks.Task<string> ArabicToRomanAsync(int arabic);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.IService1>, KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.IService1 {
        
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
        
        public KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.Request[] GetUsersRequests(string login) {
            return base.Channel.GetUsersRequests(login);
        }
        
        public System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.Request[]> GetUsersRequestsAsync(string login) {
            return base.Channel.GetUsersRequestsAsync(login);
        }
        
        public void AddUser(KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User usr) {
            base.Channel.AddUser(usr);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User usr) {
            return base.Channel.AddUserAsync(usr);
        }
        
        public KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User checkIfUserExists(string login, string password) {
            return base.Channel.checkIfUserExists(login, password);
        }
        
        public System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User> checkIfUserExistsAsync(string login, string password) {
            return base.Channel.checkIfUserExistsAsync(login, password);
        }
        
        public bool checkIfUserExistsBool(string login, string password) {
            return base.Channel.checkIfUserExistsBool(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> checkIfUserExistsBoolAsync(string login, string password) {
            return base.Channel.checkIfUserExistsBoolAsync(login, password);
        }
        
        public KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User checkIfUserExistsByLogin(string login) {
            return base.Channel.checkIfUserExistsByLogin(login);
        }
        
        public System.Threading.Tasks.Task<KMA.ProgrammingInCSharp2019.Practice6.Serialization.ServiceReference1.User> checkIfUserExistsByLoginAsync(string login) {
            return base.Channel.checkIfUserExistsByLoginAsync(login);
        }
        
        public string AddUserRequest(string login, int ArabNumber) {
            return base.Channel.AddUserRequest(login, ArabNumber);
        }
        
        public System.Threading.Tasks.Task<string> AddUserRequestAsync(string login, int ArabNumber) {
            return base.Channel.AddUserRequestAsync(login, ArabNumber);
        }
        
        public string ArabicToRoman(int arabic) {
            return base.Channel.ArabicToRoman(arabic);
        }
        
        public System.Threading.Tasks.Task<string> ArabicToRomanAsync(int arabic) {
            return base.Channel.ArabicToRomanAsync(arabic);
        }
    }
}
