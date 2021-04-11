﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebTest.ServiceReference2 {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VolumesWeights", Namespace="http://tempuri.org/")]
    public enum VolumesWeights : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cubicmeter = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cubicdecimeter = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cubiccentimeter = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cubicmillimeter = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        hectoliter = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        decaliter = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        liter = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        deciliter = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        centiliter = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        milliliter = 9,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.LiterSoap")]
    public interface LiterSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем ChangeVolumeWeightResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeVolumeWeight", ReplyAction="*")]
        WebTest.ServiceReference2.ChangeVolumeWeightResponse ChangeVolumeWeight(WebTest.ServiceReference2.ChangeVolumeWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeVolumeWeight", ReplyAction="*")]
        System.Threading.Tasks.Task<WebTest.ServiceReference2.ChangeVolumeWeightResponse> ChangeVolumeWeightAsync(WebTest.ServiceReference2.ChangeVolumeWeightRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeVolumeWeightRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeVolumeWeight", Namespace="http://tempuri.org/", Order=0)]
        public WebTest.ServiceReference2.ChangeVolumeWeightRequestBody Body;
        
        public ChangeVolumeWeightRequest() {
        }
        
        public ChangeVolumeWeightRequest(WebTest.ServiceReference2.ChangeVolumeWeightRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeVolumeWeightRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double value;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public WebTest.ServiceReference2.VolumesWeights From;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public WebTest.ServiceReference2.VolumesWeights To;
        
        public ChangeVolumeWeightRequestBody() {
        }
        
        public ChangeVolumeWeightRequestBody(double value, WebTest.ServiceReference2.VolumesWeights From, WebTest.ServiceReference2.VolumesWeights To) {
            this.value = value;
            this.From = From;
            this.To = To;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeVolumeWeightResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeVolumeWeightResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebTest.ServiceReference2.ChangeVolumeWeightResponseBody Body;
        
        public ChangeVolumeWeightResponse() {
        }
        
        public ChangeVolumeWeightResponse(WebTest.ServiceReference2.ChangeVolumeWeightResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeVolumeWeightResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ChangeVolumeWeightResult;
        
        public ChangeVolumeWeightResponseBody() {
        }
        
        public ChangeVolumeWeightResponseBody(string ChangeVolumeWeightResult) {
            this.ChangeVolumeWeightResult = ChangeVolumeWeightResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LiterSoapChannel : WebTest.ServiceReference2.LiterSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LiterSoapClient : System.ServiceModel.ClientBase<WebTest.ServiceReference2.LiterSoap>, WebTest.ServiceReference2.LiterSoap {
        
        public LiterSoapClient() {
        }
        
        public LiterSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LiterSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LiterSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LiterSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTest.ServiceReference2.ChangeVolumeWeightResponse WebTest.ServiceReference2.LiterSoap.ChangeVolumeWeight(WebTest.ServiceReference2.ChangeVolumeWeightRequest request) {
            return base.Channel.ChangeVolumeWeight(request);
        }
        
        public string ChangeVolumeWeight(double value, WebTest.ServiceReference2.VolumesWeights From, WebTest.ServiceReference2.VolumesWeights To) {
            WebTest.ServiceReference2.ChangeVolumeWeightRequest inValue = new WebTest.ServiceReference2.ChangeVolumeWeightRequest();
            inValue.Body = new WebTest.ServiceReference2.ChangeVolumeWeightRequestBody();
            inValue.Body.value = value;
            inValue.Body.From = From;
            inValue.Body.To = To;
            WebTest.ServiceReference2.ChangeVolumeWeightResponse retVal = ((WebTest.ServiceReference2.LiterSoap)(this)).ChangeVolumeWeight(inValue);
            return retVal.Body.ChangeVolumeWeightResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebTest.ServiceReference2.ChangeVolumeWeightResponse> WebTest.ServiceReference2.LiterSoap.ChangeVolumeWeightAsync(WebTest.ServiceReference2.ChangeVolumeWeightRequest request) {
            return base.Channel.ChangeVolumeWeightAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebTest.ServiceReference2.ChangeVolumeWeightResponse> ChangeVolumeWeightAsync(double value, WebTest.ServiceReference2.VolumesWeights From, WebTest.ServiceReference2.VolumesWeights To) {
            WebTest.ServiceReference2.ChangeVolumeWeightRequest inValue = new WebTest.ServiceReference2.ChangeVolumeWeightRequest();
            inValue.Body = new WebTest.ServiceReference2.ChangeVolumeWeightRequestBody();
            inValue.Body.value = value;
            inValue.Body.From = From;
            inValue.Body.To = To;
            return ((WebTest.ServiceReference2.LiterSoap)(this)).ChangeVolumeWeightAsync(inValue);
        }
    }
}