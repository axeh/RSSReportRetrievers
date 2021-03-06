﻿
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ParameterFieldReference




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
  public class ParameterFieldReference : ParameterValueOrFieldReference
  {
    private string parameterNameField;
    private string fieldAliasField;

    public string ParameterName
    {
      get
      {
        return this.parameterNameField;
      }
      set
      {
        this.parameterNameField = value;
      }
    }

    public string FieldAlias
    {
      get
      {
        return this.fieldAliasField;
      }
      set
      {
        this.fieldAliasField = value;
      }
    }
  }
}
