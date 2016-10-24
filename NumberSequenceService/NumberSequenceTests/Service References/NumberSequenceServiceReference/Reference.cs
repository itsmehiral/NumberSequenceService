﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumberSequenceTests.NumberSequenceServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NumberSequenceServiceReference.INumberSequence")]
    public interface INumberSequence {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetAllNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetAllNumbersResponse")]
        string GetAllNumbers(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetAllNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetAllNumbersResponse")]
        System.Threading.Tasks.Task<string> GetAllNumbersAsync(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetOddNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetOddNumbersResponse")]
        string GetOddNumbers(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetOddNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetOddNumbersResponse")]
        System.Threading.Tasks.Task<string> GetOddNumbersAsync(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetEvenNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetEvenNumbersResponse")]
        string GetEvenNumbers(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetEvenNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetEvenNumbersResponse")]
        System.Threading.Tasks.Task<string> GetEvenNumbersAsync(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetFormattedNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetFormattedNumbersResponse")]
        string GetFormattedNumbers(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetFormattedNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetFormattedNumbersResponse")]
        System.Threading.Tasks.Task<string> GetFormattedNumbersAsync(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetFibonacciNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetFibonacciNumbersResponse")]
        string GetFibonacciNumbers(long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberSequence/GetFibonacciNumbers", ReplyAction="http://tempuri.org/INumberSequence/GetFibonacciNumbersResponse")]
        System.Threading.Tasks.Task<string> GetFibonacciNumbersAsync(long number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INumberSequenceChannel : NumberSequenceTests.NumberSequenceServiceReference.INumberSequence, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NumberSequenceClient : System.ServiceModel.ClientBase<NumberSequenceTests.NumberSequenceServiceReference.INumberSequence>, NumberSequenceTests.NumberSequenceServiceReference.INumberSequence {
        
        public NumberSequenceClient() {
        }
        
        public NumberSequenceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NumberSequenceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberSequenceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberSequenceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAllNumbers(string input) {
            return base.Channel.GetAllNumbers(input);
        }
        
        public System.Threading.Tasks.Task<string> GetAllNumbersAsync(string input) {
            return base.Channel.GetAllNumbersAsync(input);
        }
        
        public string GetOddNumbers(long number) {
            return base.Channel.GetOddNumbers(number);
        }
        
        public System.Threading.Tasks.Task<string> GetOddNumbersAsync(long number) {
            return base.Channel.GetOddNumbersAsync(number);
        }
        
        public string GetEvenNumbers(long number) {
            return base.Channel.GetEvenNumbers(number);
        }
        
        public System.Threading.Tasks.Task<string> GetEvenNumbersAsync(long number) {
            return base.Channel.GetEvenNumbersAsync(number);
        }
        
        public string GetFormattedNumbers(long number) {
            return base.Channel.GetFormattedNumbers(number);
        }
        
        public System.Threading.Tasks.Task<string> GetFormattedNumbersAsync(long number) {
            return base.Channel.GetFormattedNumbersAsync(number);
        }
        
        public string GetFibonacciNumbers(long number) {
            return base.Channel.GetFibonacciNumbers(number);
        }
        
        public System.Threading.Tasks.Task<string> GetFibonacciNumbersAsync(long number) {
            return base.Channel.GetFibonacciNumbersAsync(number);
        }
    }
}
