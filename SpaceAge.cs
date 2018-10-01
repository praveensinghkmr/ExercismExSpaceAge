using System;
using System.Collections.Generic;

public class SpaceAge
{
    double seconds;
    const long earthYear = 31557600;
    static Dictionary<string, double> earthYearFactor = new Dictionary<string, double>
    {
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726 },
        {"Mars", 1.8808158 },
        {"Jupiter", 11.862615 },
        {"Saturn", 29.447498 },
        {"Uranus", 84.016846 },
        {"Neptune", 164.79132 }
    };

    public SpaceAge(long seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return Math.Round((seconds / earthYear),2);
    }

    public double OnMercury()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Mercury"]), 2); 
    }

    public double OnVenus()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Venus"]), 2);
    }

    public double OnMars()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Mars"]), 2);
    }        
    public double OnJupiter()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Jupiter"]), 2);
    }
    public double OnSaturn()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Saturn"]), 2);
    }

    public double OnUranus()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Uranus"]), 2);
    }

    public double OnNeptune()
    {
        return Math.Round(seconds / (earthYear * earthYearFactor["Neptune"]), 2);
    }
}