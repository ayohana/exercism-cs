using System;

public class SpaceAge
{
    public double AgeInSeconds { get; set; }
    public const double  EarthYearInSeconds = 31557600d;
    public const double MercuryYearInSeconds = (double) 0.2408467d * EarthYearInSeconds;
    public const double VenusYearInSeconds = (double) 0.61519726d * EarthYearInSeconds;
    public const double MarsYearInSeconds = (double) 1.8808158d * EarthYearInSeconds;
    public const double JupiterYearInSeconds = (double) 11.862615d * EarthYearInSeconds;
    public const double SaturnYearInSeconds = (double)  29.447498d * EarthYearInSeconds;
    public const double UranusYearInSeconds = (double) 84.016846d * EarthYearInSeconds;
    public const double NeptuneYearInSeconds = (double) 164.79132d * EarthYearInSeconds;

    public SpaceAge(int seconds)
    {
        this.AgeInSeconds = (double) seconds;
    }

    public double OnEarth()
    {
        return this.AgeInSeconds / EarthYearInSeconds;
    }

    public double OnMercury()
    {
        return this.AgeInSeconds / MercuryYearInSeconds;
    }

    public double OnVenus()
    {
        return this.AgeInSeconds / VenusYearInSeconds;
    }

    public double OnMars()
    {
        return this.AgeInSeconds / MarsYearInSeconds;
    }

    public double OnJupiter()
    {
        return this.AgeInSeconds / JupiterYearInSeconds;
    }

    public double OnSaturn()
    {
        return this.AgeInSeconds / SaturnYearInSeconds;
    }

    public double OnUranus()
    {
        return this.AgeInSeconds / UranusYearInSeconds;
    }

    public double OnNeptune()
    {
        return this.AgeInSeconds / NeptuneYearInSeconds;
    }
}