﻿// Decompiled with JetBrains decompiler
// Type: Selfcare.Api.Models.Accounts.AccountPageTransactionsRetrieveModel
// Assembly: Selfcare.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 933171C7-4848-4BC5-8A5A-40A781554582
// Assembly location: C:\Users\vgunturu\Downloads\OneDrive_1_9-7-2024\Selfcare.Api.dll

#nullable disable
namespace Selfcare.Api.Models.Accounts
{
  public class AccountPageTransactionsRetrieveModel : AccountTransactionsRetrieveModel
  {
    public int PageNumber { get; set; }

    public int PageSize { get; set; }
  }
}
