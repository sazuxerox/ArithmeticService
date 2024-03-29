﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiOperationContractClient.ArithmeticService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ArithmeticService.IArithmeticService")]
    public interface IArithmeticService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Addition", ReplyAction="http://tempuri.org/IArithmeticService/AdditionResponse")]
        int Addition(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Addition", ReplyAction="http://tempuri.org/IArithmeticService/AdditionResponse")]
        System.Threading.Tasks.Task<int> AdditionAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Subtraction", ReplyAction="http://tempuri.org/IArithmeticService/SubtractionResponse")]
        int Subtraction(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Subtraction", ReplyAction="http://tempuri.org/IArithmeticService/SubtractionResponse")]
        System.Threading.Tasks.Task<int> SubtractionAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Multiplication", ReplyAction="http://tempuri.org/IArithmeticService/MultiplicationResponse")]
        int Multiplication(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Multiplication", ReplyAction="http://tempuri.org/IArithmeticService/MultiplicationResponse")]
        System.Threading.Tasks.Task<int> MultiplicationAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Division", ReplyAction="http://tempuri.org/IArithmeticService/DivisionResponse")]
        int Division(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Division", ReplyAction="http://tempuri.org/IArithmeticService/DivisionResponse")]
        System.Threading.Tasks.Task<int> DivisionAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IArithmeticServiceChannel : MultiOperationContractClient.ArithmeticService.IArithmeticService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ArithmeticServiceClient : System.ServiceModel.ClientBase<MultiOperationContractClient.ArithmeticService.IArithmeticService>, MultiOperationContractClient.ArithmeticService.IArithmeticService {
        
        public ArithmeticServiceClient() {
        }
        
        public ArithmeticServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ArithmeticServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArithmeticServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArithmeticServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Addition(int a, int b) {
            return base.Channel.Addition(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AdditionAsync(int a, int b) {
            return base.Channel.AdditionAsync(a, b);
        }
        
        public int Subtraction(int a, int b) {
            return base.Channel.Subtraction(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SubtractionAsync(int a, int b) {
            return base.Channel.SubtractionAsync(a, b);
        }
        
        public int Multiplication(int a, int b) {
            return base.Channel.Multiplication(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicationAsync(int a, int b) {
            return base.Channel.MultiplicationAsync(a, b);
        }
        
        public int Division(int a, int b) {
            return base.Channel.Division(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivisionAsync(int a, int b) {
            return base.Channel.DivisionAsync(a, b);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ArithmeticService.IModuloService")]
    public interface IModuloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModuloService/Modulo", ReplyAction="http://tempuri.org/IModuloService/ModuloResponse")]
        int Modulo(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModuloService/Modulo", ReplyAction="http://tempuri.org/IModuloService/ModuloResponse")]
        System.Threading.Tasks.Task<int> ModuloAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModuloServiceChannel : MultiOperationContractClient.ArithmeticService.IModuloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModuloServiceClient : System.ServiceModel.ClientBase<MultiOperationContractClient.ArithmeticService.IModuloService>, MultiOperationContractClient.ArithmeticService.IModuloService {
        
        public ModuloServiceClient() {
        }
        
        public ModuloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ModuloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModuloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModuloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Modulo(int a, int b) {
            return base.Channel.Modulo(a, b);
        }
        
        public System.Threading.Tasks.Task<int> ModuloAsync(int a, int b) {
            return base.Channel.ModuloAsync(a, b);
        }
    }
}
