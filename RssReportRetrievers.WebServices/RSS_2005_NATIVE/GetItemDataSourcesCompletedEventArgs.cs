﻿
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetItemDataSourcesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class GetItemDataSourcesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetItemDataSourcesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSource[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSource[]) this.results[0];
      }
    }
  }
}
