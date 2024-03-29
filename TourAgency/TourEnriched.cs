using TP_CP_5_Semester.Models;

namespace TP_CP_5_Semester;

public class TourEnriched: Tour
{
    public bool IsHot { get; set; }
    public int OriginalPrice { get; set; }
}