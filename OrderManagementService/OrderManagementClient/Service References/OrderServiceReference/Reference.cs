﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagementClient.OrderServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceReference.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetCustomers", ReplyAction="http://tempuri.org/IOrderService/GetCustomersResponse")]
        OrderManagementModels.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetCustomers", ReplyAction="http://tempuri.org/IOrderService/GetCustomersResponse")]
        System.Threading.Tasks.Task<OrderManagementModels.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetProducts", ReplyAction="http://tempuri.org/IOrderService/GetProductsResponse")]
        OrderManagementModels.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetProducts", ReplyAction="http://tempuri.org/IOrderService/GetProductsResponse")]
        System.Threading.Tasks.Task<OrderManagementModels.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/PlaceOrder", ReplyAction="http://tempuri.org/IOrderService/PlaceOrderResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        string PlaceOrder(OrderManagementModels.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/PlaceOrder", ReplyAction="http://tempuri.org/IOrderService/PlaceOrderResponse")]
        System.Threading.Tasks.Task<string> PlaceOrderAsync(OrderManagementModels.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ManageInventory", ReplyAction="http://tempuri.org/IOrderService/ManageInventoryResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        string ManageInventory(int productId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ManageInventory", ReplyAction="http://tempuri.org/IOrderService/ManageInventoryResponse")]
        System.Threading.Tasks.Task<string> ManageInventoryAsync(int productId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ManageBalance", ReplyAction="http://tempuri.org/IOrderService/ManageBalanceResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        string ManageBalance(int customerId, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ManageBalance", ReplyAction="http://tempuri.org/IOrderService/ManageBalanceResponse")]
        System.Threading.Tasks.Task<string> ManageBalanceAsync(int customerId, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : OrderManagementClient.OrderServiceReference.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<OrderManagementClient.OrderServiceReference.IOrderService>, OrderManagementClient.OrderServiceReference.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OrderManagementModels.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<OrderManagementModels.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public OrderManagementModels.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<OrderManagementModels.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public string PlaceOrder(OrderManagementModels.Order order) {
            return base.Channel.PlaceOrder(order);
        }
        
        public System.Threading.Tasks.Task<string> PlaceOrderAsync(OrderManagementModels.Order order) {
            return base.Channel.PlaceOrderAsync(order);
        }
        
        public string ManageInventory(int productId, int quantity) {
            return base.Channel.ManageInventory(productId, quantity);
        }
        
        public System.Threading.Tasks.Task<string> ManageInventoryAsync(int productId, int quantity) {
            return base.Channel.ManageInventoryAsync(productId, quantity);
        }
        
        public string ManageBalance(int customerId, decimal amount) {
            return base.Channel.ManageBalance(customerId, amount);
        }
        
        public System.Threading.Tasks.Task<string> ManageBalanceAsync(int customerId, decimal amount) {
            return base.Channel.ManageBalanceAsync(customerId, amount);
        }
    }
}