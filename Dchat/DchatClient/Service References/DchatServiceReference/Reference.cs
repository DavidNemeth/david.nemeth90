﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DchatClient.DchatServiceReference {
    using System.Runtime.Serialization;
    using System;
    using DchatServices.Services;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DmUser", Namespace="http://schemas.datacontract.org/2004/07/DchatServices.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DchatClient.DchatServiceReference.DmUser[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DchatClient.DchatServiceReference.DmChatRoom[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DchatClient.DchatServiceReference.DmChatRoom))]
    public partial class DmUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ConnectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DchatClient.DchatServiceReference.DmUser[] FriendListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DchatClient.DchatServiceReference.DmUser[] IgnoreListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LoggedInField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DchatClient.DchatServiceReference.DmChatRoom[] RoomsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public object Connection {
            get {
                return this.ConnectionField;
            }
            set {
                if ((object.ReferenceEquals(this.ConnectionField, value) != true)) {
                    this.ConnectionField = value;
                    this.RaisePropertyChanged("Connection");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DchatClient.DchatServiceReference.DmUser[] FriendList {
            get {
                return this.FriendListField;
            }
            set {
                if ((object.ReferenceEquals(this.FriendListField, value) != true)) {
                    this.FriendListField = value;
                    this.RaisePropertyChanged("FriendList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DchatClient.DchatServiceReference.DmUser[] IgnoreList {
            get {
                return this.IgnoreListField;
            }
            set {
                if ((object.ReferenceEquals(this.IgnoreListField, value) != true)) {
                    this.IgnoreListField = value;
                    this.RaisePropertyChanged("IgnoreList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LoggedIn {
            get {
                return this.LoggedInField;
            }
            set {
                if ((this.LoggedInField.Equals(value) != true)) {
                    this.LoggedInField = value;
                    this.RaisePropertyChanged("LoggedIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
        public DchatClient.DchatServiceReference.DmChatRoom[] Rooms {
            get {
                return this.RoomsField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomsField, value) != true)) {
                    this.RoomsField = value;
                    this.RaisePropertyChanged("Rooms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DmChatRoom", Namespace="http://schemas.datacontract.org/2004/07/DchatServices.Model")]
    [System.SerializableAttribute()]
    public partial class DmChatRoom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ChatRoomIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DchatClient.DchatServiceReference.DmUser[] UsersField;
        
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
        public System.Guid ChatRoomId {
            get {
                return this.ChatRoomIdField;
            }
            set {
                if ((this.ChatRoomIdField.Equals(value) != true)) {
                    this.ChatRoomIdField = value;
                    this.RaisePropertyChanged("ChatRoomId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomName {
            get {
                return this.RoomNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomNameField, value) != true)) {
                    this.RoomNameField = value;
                    this.RaisePropertyChanged("RoomName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DchatClient.DchatServiceReference.DmUser[] Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "DchatServiceReference.IChatService", CallbackContract = typeof(IClientService))]
    public interface IChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/StartUp", ReplyAction="http://tempuri.org/IChatService/StartUpResponse")]
        void StartUp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/StartUp", ReplyAction="http://tempuri.org/IChatService/StartUpResponse")]
        System.Threading.Tasks.Task StartUpAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetMyClient", ReplyAction="http://tempuri.org/IChatService/GetMyClientResponse")]
        DchatClient.DchatServiceReference.DmUser GetMyClient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetMyClient", ReplyAction="http://tempuri.org/IChatService/GetMyClientResponse")]
        System.Threading.Tasks.Task<DchatClient.DchatServiceReference.DmUser> GetMyClientAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetConnectedUsers", ReplyAction="http://tempuri.org/IChatService/GetConnectedUsersResponse")]
        DchatClient.DchatServiceReference.DmUser[] GetConnectedUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetConnectedUsers", ReplyAction="http://tempuri.org/IChatService/GetConnectedUsersResponse")]
        System.Threading.Tasks.Task<DchatClient.DchatServiceReference.DmUser[]> GetConnectedUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetUserByName", ReplyAction="http://tempuri.org/IChatService/GetUserByNameResponse")]
        DchatClient.DchatServiceReference.DmUser GetUserByName(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetUserByName", ReplyAction="http://tempuri.org/IChatService/GetUserByNameResponse")]
        System.Threading.Tasks.Task<DchatClient.DchatServiceReference.DmUser> GetUserByNameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Login", ReplyAction="http://tempuri.org/IChatService/LoginResponse")]
        string Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Login", ReplyAction="http://tempuri.org/IChatService/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Logout", ReplyAction="http://tempuri.org/IChatService/LogoutResponse")]
        void Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Logout", ReplyAction="http://tempuri.org/IChatService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Register", ReplyAction="http://tempuri.org/IChatService/RegisterResponse")]
        string Register(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Register", ReplyAction="http://tempuri.org/IChatService/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/SendMessageToAll", ReplyAction="http://tempuri.org/IChatService/SendMessageToAllResponse")]
        void SendMessageToAll(string message, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/SendMessageToAll", ReplyAction="http://tempuri.org/IChatService/SendMessageToAllResponse")]
        System.Threading.Tasks.Task SendMessageToAllAsync(string message, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/UpdateUser", ReplyAction="http://tempuri.org/IChatService/UpdateUserResponse")]
        bool UpdateUser(string NewUsername, string OldUsername, byte[] image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/UpdateUser", ReplyAction="http://tempuri.org/IChatService/UpdateUserResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserAsync(string NewUsername, string OldUsername, byte[] image);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetMessage", ReplyAction="http://tempuri.org/IChatService/GetMessageResponse")]
        void GetMessage(string message, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Update", ReplyAction="http://tempuri.org/IChatService/UpdateResponse")]
        void Update(bool value, string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceChannel : DchatClient.DchatServiceReference.IChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatServiceClient : System.ServiceModel.DuplexClientBase<DchatClient.DchatServiceReference.IChatService>, DchatClient.DchatServiceReference.IChatService {
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartUp() {
            base.Channel.StartUp();
        }
        
        public System.Threading.Tasks.Task StartUpAsync() {
            return base.Channel.StartUpAsync();
        }
        
        public DchatClient.DchatServiceReference.DmUser GetMyClient() {
            return base.Channel.GetMyClient();
        }
        
        public System.Threading.Tasks.Task<DchatClient.DchatServiceReference.DmUser> GetMyClientAsync() {
            return base.Channel.GetMyClientAsync();
        }
        
        public DchatClient.DchatServiceReference.DmUser[] GetConnectedUsers() {
            return base.Channel.GetConnectedUsers();
        }
        
        public System.Threading.Tasks.Task<DchatClient.DchatServiceReference.DmUser[]> GetConnectedUsersAsync() {
            return base.Channel.GetConnectedUsersAsync();
        }
        
        public DchatClient.DchatServiceReference.DmUser GetUserByName(string username) {
            return base.Channel.GetUserByName(username);
        }
        
        public System.Threading.Tasks.Task<DchatClient.DchatServiceReference.DmUser> GetUserByNameAsync(string username) {
            return base.Channel.GetUserByNameAsync(username);
        }
        
        public string Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public void Logout() {
            base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public string Register(string username, string password) {
            return base.Channel.Register(username, password);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username, string password) {
            return base.Channel.RegisterAsync(username, password);
        }
        
        public void SendMessageToAll(string message, string userName) {
            base.Channel.SendMessageToAll(message, userName);
        }
        
        public System.Threading.Tasks.Task SendMessageToAllAsync(string message, string userName) {
            return base.Channel.SendMessageToAllAsync(message, userName);
        }
        
        public bool UpdateUser(string NewUsername, string OldUsername, byte[] image) {
            return base.Channel.UpdateUser(NewUsername, OldUsername, image);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserAsync(string NewUsername, string OldUsername, byte[] image) {
            return base.Channel.UpdateUserAsync(NewUsername, OldUsername, image);
        }
    }
}
