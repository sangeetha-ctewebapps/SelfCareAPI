﻿// Decompiled with JetBrains decompiler
// Type: Selfcare.Api.Models.Accounts.AccountTopupViewModel
// Assembly: Selfcare.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 933171C7-4848-4BC5-8A5A-40A781554582
// Assembly location: C:\Users\vgunturu\Downloads\OneDrive_1_9-7-2024\Selfcare.Api.dll

using System;

#nullable disable
namespace Selfcare.Api.Models.Accounts
{
  public class AccountTopupViewModel
  {
    public int AccountId { get; set; }

    public Decimal AccountBalance { get; set; }

    public byte[] PaymentReceiptContent { get; set; }
  }
}