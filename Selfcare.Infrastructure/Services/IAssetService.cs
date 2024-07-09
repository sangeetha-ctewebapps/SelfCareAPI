﻿// Decompiled with JetBrains decompiler
// Type: Selfcare.Infrastructure.Services.IAssetService
// Assembly: Selfcare.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BEE7BF7A-9671-49F8-897B-41B38BF30A3E
// Assembly location: C:\Users\vgunturu\Downloads\OneDrive_1_9-7-2024\Selfcare.Infrastructure.dll

using Selfcare.Infrastructure.BackOffice;
using Selfcare.Infrastructure.Entities.Assets;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Selfcare.Infrastructure.Services
{
  public interface IAssetService
  {
    Task<BackOfficeApiResult<IEnumerable<AssetViewData>>> RetrieveAssetsAsync(
      AssetsRetrieveParameters retrieveParameters);

    Task<BackOfficeApiResult<AssetDetailsViewData>> RetrieveAssetDetailsAsync(int accountUnitId);

    Task<BackOfficeApiResult<IEnumerable<AssetDetailsViewData>>> RetrieveFilteredAssetsListAsync(
      AssetsFilterParameters retrieveParameters);
  }
}