﻿
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ItemNamespaceHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [Serializable]
  public class ItemNamespaceHeader : SoapHeader
  {
    private ItemNamespaceEnum itemNamespaceField;
    private XmlAttribute[] anyAttrField;

    public ItemNamespaceEnum ItemNamespace
    {
      get
      {
        return this.itemNamespaceField;
      }
      set
      {
        this.itemNamespaceField = value;
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
