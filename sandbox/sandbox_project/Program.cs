using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
public class FeatureCollection
{
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
public class Program
{

    /// <summary>
    /// This function will read JSON (Javascript Object Notation) data from the 
    /// United States Geological Service (USGS) consisting of earthquake data.
    /// The data will include all earthquakes in the current day.
    /// 
    /// JSON data is organized into a dictionary. After reading the data using
    /// the built-in HTTP client library, this function will return a list of all
    /// earthquake locations ('place' attribute) and magnitudes ('mag' attribute).
    /// Additional information about the format of the JSON data can be found 
    /// at this website:  
    /// 
    /// https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson.php
    /// 
    /// </summary>
    public static string[] EarthquakeDailySummary()
    {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using var client = new HttpClient();
        using var getRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        using var jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using var reader = new StreamReader(jsonStream);
        var json = reader.ReadToEnd();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        // TODO Problem 5:
        // 1. Add code in FeatureCollection.cs to describe the JSON using classes and properties 
        // on those classes so that the call to Deserialize above works properly.
        // 2. Add code below to create a string out each place a earthquake has happened today and its magitude.
        // 3. Return an array of these string descriptions.
        List<string> TodayEarthquake = new List<string>();
        foreach(var detail in featureCollection.Features)
        {
            TodayEarthquake.Add($"Place: {detail.Properties.Place}, Mag: {detail.Properties.Mag}");
        }
        return TodayEarthquake.ToArray();
    }
    public static void Main(string[] args)
    {
        string[] myArr = EarthquakeDailySummary();
        foreach(string detail in myArr)
        {
            Console.WriteLine(detail);
        }
    }
}