using System;

public class SpaceAge
{
    double seconds;
    public SpaceAge(long seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return Math.Round((seconds / 31557600),2);
    }

    public double OnMercury()
    {
        throw new NotImplementedException("You need to implement this function.");
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