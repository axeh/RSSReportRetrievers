﻿
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ScheduleExpiration




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public class ScheduleExpiration : ExpirationDefinition
  {
    private ScheduleDefinitionOrReference itemField;

    [XmlElement("ScheduleReference", typeof (ScheduleReference))]
    [XmlElement("ScheduleDefinition", typeof (ScheduleDefinition))]
    public ScheduleDefinitionOrReference Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }
}
