﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginUI.GameService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerCredentials", Namespace="http://schemas.datacontract.org/2004/07/GameService")]
    [System.SerializableAttribute()]
    public partial class PlayerCredentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlayerNicknameField;
        
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
        public byte[] Password {
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
        public string PlayerNickname {
            get {
                return this.PlayerNicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerNicknameField, value) != true)) {
                    this.PlayerNicknameField = value;
                    this.RaisePropertyChanged("PlayerNickname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterPlayerResponse", Namespace="http://schemas.datacontract.org/2004/07/GameService")]
    [System.SerializableAttribute()]
    public partial class RegisterPlayerResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> PlayerIDField;
        
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
        public System.Nullable<System.Guid> PlayerID {
            get {
                return this.PlayerIDField;
            }
            set {
                if ((this.PlayerIDField.Equals(value) != true)) {
                    this.PlayerIDField = value;
                    this.RaisePropertyChanged("PlayerID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginResult", Namespace="http://schemas.datacontract.org/2004/07/GameService")]
    [System.SerializableAttribute()]
    public partial class LoginResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoginUI.GameService.FailureReason FailureReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> UserIDField;
        
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
        public LoginUI.GameService.FailureReason FailureReason {
            get {
                return this.FailureReasonField;
            }
            set {
                if ((this.FailureReasonField.Equals(value) != true)) {
                    this.FailureReasonField = value;
                    this.RaisePropertyChanged("FailureReason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FailureReason", Namespace="http://schemas.datacontract.org/2004/07/GameService")]
    public enum FailureReason : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidCredentials = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AlreadyLoggedIn = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameService.ILoginService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/InitiateSession", ReplyAction="http://tempuri.org/ILoginService/InitiateSessionResponse")]
        string InitiateSession();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/InitiateSession", ReplyAction="http://tempuri.org/ILoginService/InitiateSessionResponse")]
        System.Threading.Tasks.Task<string> InitiateSessionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/RegisterPlayer", ReplyAction="http://tempuri.org/ILoginService/RegisterPlayerResponse")]
        LoginUI.GameService.RegisterPlayerResponse RegisterPlayer(LoginUI.GameService.PlayerCredentials request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/RegisterPlayer", ReplyAction="http://tempuri.org/ILoginService/RegisterPlayerResponse")]
        System.Threading.Tasks.Task<LoginUI.GameService.RegisterPlayerResponse> RegisterPlayerAsync(LoginUI.GameService.PlayerCredentials request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/AuthenticateUser", ReplyAction="http://tempuri.org/ILoginService/AuthenticateUserResponse")]
        LoginUI.GameService.LoginResult AuthenticateUser(LoginUI.GameService.PlayerCredentials request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/AuthenticateUser", ReplyAction="http://tempuri.org/ILoginService/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<LoginUI.GameService.LoginResult> AuthenticateUserAsync(LoginUI.GameService.PlayerCredentials request);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILoginService/LogOff", ReplyAction="http://tempuri.org/ILoginService/LogOffResponse")]
        void LogOff();
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILoginService/LogOff", ReplyAction="http://tempuri.org/ILoginService/LogOffResponse")]
        System.Threading.Tasks.Task LogOffAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : LoginUI.GameService.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<LoginUI.GameService.ILoginService>, LoginUI.GameService.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InitiateSession() {
            return base.Channel.InitiateSession();
        }
        
        public System.Threading.Tasks.Task<string> InitiateSessionAsync() {
            return base.Channel.InitiateSessionAsync();
        }
        
        public LoginUI.GameService.RegisterPlayerResponse RegisterPlayer(LoginUI.GameService.PlayerCredentials request) {
            return base.Channel.RegisterPlayer(request);
        }
        
        public System.Threading.Tasks.Task<LoginUI.GameService.RegisterPlayerResponse> RegisterPlayerAsync(LoginUI.GameService.PlayerCredentials request) {
            return base.Channel.RegisterPlayerAsync(request);
        }
        
        public LoginUI.GameService.LoginResult AuthenticateUser(LoginUI.GameService.PlayerCredentials request) {
            return base.Channel.AuthenticateUser(request);
        }
        
        public System.Threading.Tasks.Task<LoginUI.GameService.LoginResult> AuthenticateUserAsync(LoginUI.GameService.PlayerCredentials request) {
            return base.Channel.AuthenticateUserAsync(request);
        }
        
        public void LogOff() {
            base.Channel.LogOff();
        }
        
        public System.Threading.Tasks.Task LogOffAsync() {
            return base.Channel.LogOffAsync();
        }
    }
}
