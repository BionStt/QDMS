﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QDMSServer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string ibClientHost {
            get {
                return ((string)(this["ibClientHost"]));
            }
            set {
                this["ibClientHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7496")]
        public int ibClientPort {
            get {
                return ((int)(this["ibClientPort"]));
            }
            set {
                this["ibClientPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ibClientRequestCounter {
            get {
                return ((int)(this["ibClientRequestCounter"]));
            }
            set {
                this["ibClientRequestCounter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string mySqlHost {
            get {
                return ((string)(this["mySqlHost"]));
            }
            set {
                this["mySqlHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string instrumentsGridLayout {
            get {
                return ((string)(this["instrumentsGridLayout"]));
            }
            set {
                this["instrumentsGridLayout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5557")]
        public int rtDBPubPort {
            get {
                return ((int)(this["rtDBPubPort"]));
            }
            set {
                this["rtDBPubPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5556")]
        public int rtDBReqPort {
            get {
                return ((int)(this["rtDBReqPort"]));
            }
            set {
                this["rtDBReqPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5558")]
        public int instrumentServerPort {
            get {
                return ((int)(this["instrumentServerPort"]));
            }
            set {
                this["instrumentServerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5555")]
        public int hDBPort {
            get {
                return ((int)(this["hDBPort"]));
            }
            set {
                this["hDBPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\QDMSLog\\")]
        public string logDirectory {
            get {
                return ((string)(this["logDirectory"]));
            }
            set {
                this["logDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string mySqlUsername {
            get {
                return ((string)(this["mySqlUsername"]));
            }
            set {
                this["mySqlUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string mySqlPassword {
            get {
                return ((string)(this["mySqlPassword"]));
            }
            set {
                this["mySqlPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string quandlAuthCode {
            get {
                return ((string)(this["quandlAuthCode"]));
            }
            set {
                this["quandlAuthCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string databaseType {
            get {
                return ((string)(this["databaseType"]));
            }
            set {
                this["databaseType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string sqlServerHost {
            get {
                return ((string)(this["sqlServerHost"]));
            }
            set {
                this["sqlServerHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool sqlServerUseWindowsAuthentication {
            get {
                return ((bool)(this["sqlServerUseWindowsAuthentication"]));
            }
            set {
                this["sqlServerUseWindowsAuthentication"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string sqlServerUsername {
            get {
                return ((string)(this["sqlServerUsername"]));
            }
            set {
                this["sqlServerUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string sqlServerPassword {
            get {
                return ((string)(this["sqlServerPassword"]));
            }
            set {
                this["sqlServerPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int histClientIBID {
            get {
                return ((int)(this["histClientIBID"]));
            }
            set {
                this["histClientIBID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int rtdClientIBID {
            get {
                return ((int)(this["rtdClientIBID"]));
            }
            set {
                this["rtdClientIBID"] = value;
            }
        }
    }
}
