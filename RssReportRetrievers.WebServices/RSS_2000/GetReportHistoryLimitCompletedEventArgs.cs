﻿
// Type: RSS_Report_Retrievers.RSS_2000.GetReportHistoryLimitCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class GetReportHistoryLimitCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetReportHistoryLimitCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public int Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (int) this.results[0];
      }
    }

    public bool IsSystem
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[1];
      }
    }

    public int SystemLimit
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (int) this.results[2];
      }
    }
  }
}
