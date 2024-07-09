﻿// Decompiled with JetBrains decompiler
// Type: Selfcare.Infrastructure.Services.ICaseService
// Assembly: Selfcare.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BEE7BF7A-9671-49F8-897B-41B38BF30A3E
// Assembly location: C:\Users\vgunturu\Downloads\OneDrive_1_9-7-2024\Selfcare.Infrastructure.dll

using Selfcare.Infrastructure.BackOffice;
using Selfcare.Infrastructure.Entities.Case;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Selfcare.Infrastructure.Services
{
  public interface ICaseService
  {
    Task<BackOfficeApiResult<CreateCaseViewData>> CreateCaseAsync(CaseCreateData caseData);

    Task<BackOfficeApiResult<IEnumerable<CaseViewData>>> RetrieveCasesAsync(
      CasesRetrieveParameters retrieveParameters);
  }
}
