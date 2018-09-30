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
        return Math.Round(seconds / (earthYear * 0.2408467), 2); ;
    }

    public double OnVenus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}