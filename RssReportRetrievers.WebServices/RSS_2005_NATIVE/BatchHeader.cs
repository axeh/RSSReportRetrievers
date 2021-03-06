﻿
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.BatchHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [Serializable]
  public class BatchHeader : SoapHeader
  {
    private string batchIDField;
    private XmlAttribute[] anyAttrField;

    public string BatchID
    {
      get
      {
        return this.batchIDField;
      }
      set
      {
        this.batchIDField = value;
      }
    }

    [XmlAnyAttribute]
    public XmlAttribute[] AnyAttr
    {
      get
      {
        return this.anyAttrField;
      }
      set
      {
        this.anyAttrField = value;
      }
    }
  }
}
