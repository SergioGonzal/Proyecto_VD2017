﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WarlockSoft.WS_CrearProyecto {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CrearProyectoPortBinding", Namespace="http://WarlockSoft/")]
    public partial class CrearProyecto : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ObtenerProyectosOperationCompleted;
        
        private System.Threading.SendOrPostCallback GuardarProyectoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerIDProyectoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CrearProyecto() {
            this.Url = global::WarlockSoft.Properties.Settings.Default.WarlockSoft_WS_CrearProyecto_CrearProyecto;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ObtenerProyectosCompletedEventHandler ObtenerProyectosCompleted;
        
        /// <remarks/>
        public event GuardarProyectoCompletedEventHandler GuardarProyectoCompleted;
        
        /// <remarks/>
        public event ObtenerIDProyectoCompletedEventHandler ObtenerIDProyectoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://WarlockSoft/", ResponseNamespace="http://WarlockSoft/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] ObtenerProyectos([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IDUsuario) {
            object[] results = this.Invoke("ObtenerProyectos", new object[] {
                        IDUsuario});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerProyectosAsync(string IDUsuario) {
            this.ObtenerProyectosAsync(IDUsuario, null);
        }
        
        /// <remarks/>
        public void ObtenerProyectosAsync(string IDUsuario, object userState) {
            if ((this.ObtenerProyectosOperationCompleted == null)) {
                this.ObtenerProyectosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerProyectosOperationCompleted);
            }
            this.InvokeAsync("ObtenerProyectos", new object[] {
                        IDUsuario}, this.ObtenerProyectosOperationCompleted, userState);
        }
        
        private void OnObtenerProyectosOperationCompleted(object arg) {
            if ((this.ObtenerProyectosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerProyectosCompleted(this, new ObtenerProyectosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://WarlockSoft/", ResponseNamespace="http://WarlockSoft/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool GuardarProyecto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string FechaInicio, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string FechaFin, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IDUsuario) {
            object[] results = this.Invoke("GuardarProyecto", new object[] {
                        Nombre,
                        FechaInicio,
                        FechaFin,
                        IDUsuario});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarProyectoAsync(string Nombre, string FechaInicio, string FechaFin, string IDUsuario) {
            this.GuardarProyectoAsync(Nombre, FechaInicio, FechaFin, IDUsuario, null);
        }
        
        /// <remarks/>
        public void GuardarProyectoAsync(string Nombre, string FechaInicio, string FechaFin, string IDUsuario, object userState) {
            if ((this.GuardarProyectoOperationCompleted == null)) {
                this.GuardarProyectoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarProyectoOperationCompleted);
            }
            this.InvokeAsync("GuardarProyecto", new object[] {
                        Nombre,
                        FechaInicio,
                        FechaFin,
                        IDUsuario}, this.GuardarProyectoOperationCompleted, userState);
        }
        
        private void OnGuardarProyectoOperationCompleted(object arg) {
            if ((this.GuardarProyectoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarProyectoCompleted(this, new GuardarProyectoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://WarlockSoft/", ResponseNamespace="http://WarlockSoft/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ObtenerIDProyecto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NombreProyecto) {
            object[] results = this.Invoke("ObtenerIDProyecto", new object[] {
                        NombreProyecto});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerIDProyectoAsync(string NombreProyecto) {
            this.ObtenerIDProyectoAsync(NombreProyecto, null);
        }
        
        /// <remarks/>
        public void ObtenerIDProyectoAsync(string NombreProyecto, object userState) {
            if ((this.ObtenerIDProyectoOperationCompleted == null)) {
                this.ObtenerIDProyectoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerIDProyectoOperationCompleted);
            }
            this.InvokeAsync("ObtenerIDProyecto", new object[] {
                        NombreProyecto}, this.ObtenerIDProyectoOperationCompleted, userState);
        }
        
        private void OnObtenerIDProyectoOperationCompleted(object arg) {
            if ((this.ObtenerIDProyectoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerIDProyectoCompleted(this, new ObtenerIDProyectoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ObtenerProyectosCompletedEventHandler(object sender, ObtenerProyectosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerProyectosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerProyectosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GuardarProyectoCompletedEventHandler(object sender, GuardarProyectoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarProyectoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarProyectoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ObtenerIDProyectoCompletedEventHandler(object sender, ObtenerIDProyectoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerIDProyectoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerIDProyectoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591