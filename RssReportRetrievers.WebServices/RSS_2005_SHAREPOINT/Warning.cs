﻿
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.Warning




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class Warning
  {
    private string codeField;
    private string severityField;
    private string objectNameField;
    private string objectTypeField;
    private string messageField;

    public string Code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    public string Severity
    {
      get
      {
        return this.severityField;
      }
      set
      {
        this.severityField = value;
      }
    }

    public string ObjectName
    {
      get
      {
        return this.objectNameField;
      }
      set
      {
        this.objectNameField = value;
      }
    }

    public string ObjectType
    {
      get
      {
        return this.objectTypeField;
      }
      set
      {
        this.objectTypeField = value;
      }
    }

    public string Message
    {
      get
      {
        return this.messageField;
      }
      set
      {
        this.messageField = value;
      }
    }
  }
}
