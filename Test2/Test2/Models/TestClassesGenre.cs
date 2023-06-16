using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Test2.Models;

public class TestClassesGenre
{
    public List<Class>? Classes { get; set; }
    public SelectList? Users { get; set; }
    public string? User { get; set; }
    public string? SearchString { get; set; }
}
