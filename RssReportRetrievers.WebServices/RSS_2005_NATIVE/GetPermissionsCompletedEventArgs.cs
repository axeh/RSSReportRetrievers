﻿
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetPermissionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class GetPermissionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetPermissionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public string[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string[]) this.results[0];
      }
    }
  }
}
