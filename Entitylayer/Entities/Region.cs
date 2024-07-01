﻿using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Region
{
    public Guid? IdRegion { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public string? Keyword01 { get; set; }

    public string? Keyword02 { get; set; }

    public string? Keyword03 { get; set; }
}
