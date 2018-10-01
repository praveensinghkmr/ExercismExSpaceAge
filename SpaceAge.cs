using System;

public class SpaceAge
{
    double seconds;
    long earthYear;
    public SpaceAge(long seconds)
    {
        this.seconds = seconds;
        earthYear = 31557600;
    }

    public double OnEarth()
    {
        return Math.Round((seconds / earthYear),2);
    }

    public double OnMercury()
    {
        return Math.Round(seconds / (earthYear * 0.2408467), 2); 
    }

    public double OnVenus()
    {
        return Math.Round(seconds / (earthYear * 0.61519726), 2);
    }

    public double OnMars()
    {
        return Math.Round(seconds / (earthYear * 1.8808158), 2);
    }        
    public double OnJupiter()
    {
        return Math.Round(seconds / (earthYear * 11.862615), 2);
    }
    public double OnSaturn()
    {
        return Math.Round(seconds / (earthYear * 29.447498), 2);
    }

    public double OnUranus()
    {
        return Math.Round(seconds / (earthYear * 84.016846), 2);
    }

    public double OnNeptune()
    {
        return Math.Round(seconds / (earthYear * 164.79132), 2);
    }
}