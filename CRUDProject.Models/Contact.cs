using System;
using System.Collections.Generic;

namespace CRUDProject.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    public string ContactPassword { get; set; } = null!;
}
