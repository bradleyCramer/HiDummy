


namespace HiDummy.Models
{
    public class NearEarthObjectModel
    {
        public Links? links { get; set; }
        public string? id { get; set; }
        public string? neo_reference_id { get; set; }
        public string? name { get; set; }
        public string? nasa_jpl_url { get; set; }
        public double absolute_magnitude_h { get; set; }
        public EstimatedDiameter? estimated_diameter { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public required List<CloseApproachData> close_approach_data { get; set; }
        public bool is_sentry_object { get; set; }
    }

    public class Links
    {
        public string? self { get; set; }
    }

    public class EstimatedDiameter
    {
        public Diameter? kilometers { get; set; }
        public Diameter? meters { get; set; }
        public Diameter? miles { get; set; }
        public Diameter? feet { get; set; }
    }

    public class Diameter
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class CloseApproachData
    {
        public string? close_approach_date { get; set; }
        public string? close_approach_date_full { get; set; }
        public long? epoch_date_close_approach { get; set; }
        public RelativeVelocity? relative_velocity { get; set; }
        public MissDistance? miss_distance { get; set; }
        public string? orbiting_body { get; set; }
    }

    public class RelativeVelocity
    {
        public string? kilometers_per_second { get; set; }
        public string? kilometers_per_hour { get; set; }
        public string? miles_per_hour { get; set; }
    }

    public class MissDistance
    {
        public string? astronomical { get; set; }
        public string? lunar { get; set; }
        public string? kilometers { get; set; }
        public string? miles { get; set; }
    }
}
