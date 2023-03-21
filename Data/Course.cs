﻿using System;
using System.Collections.Generic;

namespace testproject.Data;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public int? Credits { get; set; }
}
