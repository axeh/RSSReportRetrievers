﻿
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.GetPoliciesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class GetPoliciesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetPoliciesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Policy[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Policy[]) this.results[0];
      }
    }

    public bool InheritParent
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[1];
      }
    }
  }
}
