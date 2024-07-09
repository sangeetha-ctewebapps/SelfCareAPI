﻿// Decompiled with JetBrains decompiler
// Type: Selfcare.Api.Mappings.MasterTableProfile
// Assembly: Selfcare.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 933171C7-4848-4BC5-8A5A-40A781554582
// Assembly location: C:\Users\vgunturu\Downloads\OneDrive_1_9-7-2024\Selfcare.Api.dll

using AutoMapper;
using Selfcare.Api.Models.MasterTable;
using Selfcare.Infrastructure.Entities.MasterTable;

#nullable disable
namespace Selfcare.Api.Mappings
{
  public class MasterTableProfile : Profile
  {
    public MasterTableProfile()
    {
      this.CreateMap<MasterTableViewData, MasterTableViewModel>();
      this.CreateMap<PlateTypeViewData, PlateTypeViewModel>();
      this.CreateMap<PlateViewData, PlateViewModel>();
    }
  }
}
