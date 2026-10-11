using System;
using System.Collections.Generic;

namespace pdfcreaterofdiffrentuser.Models;

public partial class Pdfaddress
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Role { get; set; }

    public string? PdfAdress { get; set; }

    public DateTime CreatedAt { get; set; }
}
