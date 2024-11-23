public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Features> Features {get; set;}
}
public class Features
{
    public Properties Properties {get; set;}
}
public class Properties
{
    public string Place {get; set;}
    public float? Mag {get; set;}
}