﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </auto-generated>
//------------------------------------------------------------------------------

namespace wlg.WlgManagementService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.wlg.aac.com/", ConfigurationName="wlg.WlgManagementService.WlgManagement")]
    public interface WlgManagement
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<wlg.WlgManagementService.createSFCResponse1> createSFCAsync(wlg.WlgManagementService.createSFCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<wlg.WlgManagementService.appearanceCheckNCRecordResponse1> appearanceCheckNCRecordAsync(wlg.WlgManagementService.appearanceCheckNCRecordRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.wlg.aac.com/")]
    public partial class createSFC
    {
        
        private string siteField;
        
        private string snField;
        
        private string machineIdField;
        
        private string projectNameField;
        
        private string modelField;
        
        private string partNameField;
        
        private string cavityIdField;
        
        private string moldCountField;
        
        private string sfcClassField;
        
        private string sfcCountField;
        
        private string blxtNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string sn
        {
            get
            {
                return this.snField;
            }
            set
            {
                this.snField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string machineId
        {
            get
            {
                return this.machineIdField;
            }
            set
            {
                this.machineIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string projectName
        {
            get
            {
                return this.projectNameField;
            }
            set
            {
                this.projectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string partName
        {
            get
            {
                return this.partNameField;
            }
            set
            {
                this.partNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string cavityId
        {
            get
            {
                return this.cavityIdField;
            }
            set
            {
                this.cavityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string moldCount
        {
            get
            {
                return this.moldCountField;
            }
            set
            {
                this.moldCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string sfcClass
        {
            get
            {
                return this.sfcClassField;
            }
            set
            {
                this.sfcClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string sfcCount
        {
            get
            {
                return this.sfcCountField;
            }
            set
            {
                this.sfcCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string blxtName
        {
            get
            {
                return this.blxtNameField;
            }
            set
            {
                this.blxtNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.wlg.aac.com/")]
    public partial class appearanceCheckNCRecordResponse
    {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.wlg.aac.com/")]
    public partial class appearanceCheckNCRecord
    {
        
        private string siteField;
        
        private string snField;
        
        private string machineIdField;
        
        private int qtyOKField;
        
        private int qtyNGField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string sn
        {
            get
            {
                return this.snField;
            }
            set
            {
                this.snField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string machineId
        {
            get
            {
                return this.machineIdField;
            }
            set
            {
                this.machineIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int qtyOK
        {
            get
            {
                return this.qtyOKField;
            }
            set
            {
                this.qtyOKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int qtyNG
        {
            get
            {
                return this.qtyNGField;
            }
            set
            {
                this.qtyNGField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.wlg.aac.com/")]
    public partial class createSFCResponse
    {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createSFCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.wlg.aac.com/", Order=0)]
        public wlg.WlgManagementService.createSFC createSFC;
        
        public createSFCRequest()
        {
        }
        
        public createSFCRequest(wlg.WlgManagementService.createSFC createSFC)
        {
            this.createSFC = createSFC;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createSFCResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.wlg.aac.com/", Order=0)]
        public wlg.WlgManagementService.createSFCResponse createSFCResponse;
        
        public createSFCResponse1()
        {
        }
        
        public createSFCResponse1(wlg.WlgManagementService.createSFCResponse createSFCResponse)
        {
            this.createSFCResponse = createSFCResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class appearanceCheckNCRecordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.wlg.aac.com/", Order=0)]
        public wlg.WlgManagementService.appearanceCheckNCRecord appearanceCheckNCRecord;
        
        public appearanceCheckNCRecordRequest()
        {
        }
        
        public appearanceCheckNCRecordRequest(wlg.WlgManagementService.appearanceCheckNCRecord appearanceCheckNCRecord)
        {
            this.appearanceCheckNCRecord = appearanceCheckNCRecord;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class appearanceCheckNCRecordResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.wlg.aac.com/", Order=0)]
        public wlg.WlgManagementService.appearanceCheckNCRecordResponse appearanceCheckNCRecordResponse;
        
        public appearanceCheckNCRecordResponse1()
        {
        }
        
        public appearanceCheckNCRecordResponse1(wlg.WlgManagementService.appearanceCheckNCRecordResponse appearanceCheckNCRecordResponse)
        {
            this.appearanceCheckNCRecordResponse = appearanceCheckNCRecordResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface WlgManagementChannel : wlg.WlgManagementService.WlgManagement, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class WlgManagementClient : System.ServiceModel.ClientBase<wlg.WlgManagementService.WlgManagement>, wlg.WlgManagementService.WlgManagement
    {
        
        /// <summary>
        /// 实现此分部方法，配置服务终结点。
        /// </summary>
        /// <param name="serviceEndpoint">要配置的终结点</param>
        /// <param name="clientCredentials">客户端凭据</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WlgManagementClient() : 
                base(WlgManagementClient.GetDefaultBinding(), WlgManagementClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WlgManagementPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WlgManagementClient(EndpointConfiguration endpointConfiguration) : 
                base(WlgManagementClient.GetBindingForEndpoint(endpointConfiguration), WlgManagementClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WlgManagementClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WlgManagementClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WlgManagementClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WlgManagementClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WlgManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<wlg.WlgManagementService.createSFCResponse1> wlg.WlgManagementService.WlgManagement.createSFCAsync(wlg.WlgManagementService.createSFCRequest request)
        {
            return base.Channel.createSFCAsync(request);
        }
        
        public System.Threading.Tasks.Task<wlg.WlgManagementService.createSFCResponse1> createSFCAsync(wlg.WlgManagementService.createSFC createSFC)
        {
            wlg.WlgManagementService.createSFCRequest inValue = new wlg.WlgManagementService.createSFCRequest();
            inValue.createSFC = createSFC;
            return ((wlg.WlgManagementService.WlgManagement)(this)).createSFCAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<wlg.WlgManagementService.appearanceCheckNCRecordResponse1> wlg.WlgManagementService.WlgManagement.appearanceCheckNCRecordAsync(wlg.WlgManagementService.appearanceCheckNCRecordRequest request)
        {
            return base.Channel.appearanceCheckNCRecordAsync(request);
        }
        
        public System.Threading.Tasks.Task<wlg.WlgManagementService.appearanceCheckNCRecordResponse1> appearanceCheckNCRecordAsync(wlg.WlgManagementService.appearanceCheckNCRecord appearanceCheckNCRecord)
        {
            wlg.WlgManagementService.appearanceCheckNCRecordRequest inValue = new wlg.WlgManagementService.appearanceCheckNCRecordRequest();
            inValue.appearanceCheckNCRecord = appearanceCheckNCRecord;
            return ((wlg.WlgManagementService.WlgManagement)(this)).appearanceCheckNCRecordAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WlgManagementPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WlgManagementPort))
            {
                return new System.ServiceModel.EndpointAddress("http://10.69.76.82:50000/aac-webservice/WlgManagementService");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WlgManagementClient.GetBindingForEndpoint(EndpointConfiguration.WlgManagementPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WlgManagementClient.GetEndpointAddress(EndpointConfiguration.WlgManagementPort);
        }
        
        public enum EndpointConfiguration
        {
            
            WlgManagementPort,
        }
    }
}