﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcf_assignment1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/primeNo", ReplyAction="http://tempuri.org/IService1/primeNoResponse")]
        string primeNo(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/primeNo", ReplyAction="http://tempuri.org/IService1/primeNoResponse")]
        System.Threading.Tasks.Task<string> primeNoAsync(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sumOfDigit", ReplyAction="http://tempuri.org/IService1/sumOfDigitResponse")]
        string sumOfDigit(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sumOfDigit", ReplyAction="http://tempuri.org/IService1/sumOfDigitResponse")]
        System.Threading.Tasks.Task<string> sumOfDigitAsync(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverseString", ReplyAction="http://tempuri.org/IService1/reverseStringResponse")]
        string reverseString(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverseString", ReplyAction="http://tempuri.org/IService1/reverseStringResponse")]
        System.Threading.Tasks.Task<string> reverseStringAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/htmlTags", ReplyAction="http://tempuri.org/IService1/htmlTagsResponse")]
        string htmlTags(string valueTag, string htmlData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/htmlTags", ReplyAction="http://tempuri.org/IService1/htmlTagsResponse")]
        System.Threading.Tasks.Task<string> htmlTagsAsync(string valueTag, string htmlData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortFiveNumbers", ReplyAction="http://tempuri.org/IService1/sortFiveNumbersResponse")]
        string sortFiveNumbers(int[] num, string sortingNumbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortFiveNumbers", ReplyAction="http://tempuri.org/IService1/sortFiveNumbersResponse")]
        System.Threading.Tasks.Task<string> sortFiveNumbersAsync(int[] num, string sortingNumbers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : wcf_assignment1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<wcf_assignment1.ServiceReference1.IService1>, wcf_assignment1.ServiceReference1.IService1 {
        
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
        
        public string primeNo(int num) {
            return base.Channel.primeNo(num);
        }
        
        public System.Threading.Tasks.Task<string> primeNoAsync(int num) {
            return base.Channel.primeNoAsync(num);
        }
        
        public string sumOfDigit(int num) {
            return base.Channel.sumOfDigit(num);
        }
        
        public System.Threading.Tasks.Task<string> sumOfDigitAsync(int num) {
            return base.Channel.sumOfDigitAsync(num);
        }
        
        public string reverseString(string value) {
            return base.Channel.reverseString(value);
        }
        
        public System.Threading.Tasks.Task<string> reverseStringAsync(string value) {
            return base.Channel.reverseStringAsync(value);
        }
        
        public string htmlTags(string valueTag, string htmlData) {
            return base.Channel.htmlTags(valueTag, htmlData);
        }
        
        public System.Threading.Tasks.Task<string> htmlTagsAsync(string valueTag, string htmlData) {
            return base.Channel.htmlTagsAsync(valueTag, htmlData);
        }
        
        public string sortFiveNumbers(int[] num, string sortingNumbers) {
            return base.Channel.sortFiveNumbers(num, sortingNumbers);
        }
        
        public System.Threading.Tasks.Task<string> sortFiveNumbersAsync(int[] num, string sortingNumbers) {
            return base.Channel.sortFiveNumbersAsync(num, sortingNumbers);
        }
    }
}