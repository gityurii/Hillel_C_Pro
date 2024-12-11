namespace HW4;

public class City
{
    public int Residents { get; set; }

    public City(int residents)
    {
        Residents = residents;
    }

    public static City operator +(City city, int additionalResidents)
    {
        city.Residents += additionalResidents;
        return city;
    }

    public static bool operator ==(City city1, City city2)
    {
        if (city1 is null || city2 is null)
        {
            return false;
        }
        return city1.Residents == city2.Residents;
    }

    public static bool operator !=(City city1, City city2)
    {
        return !(city1 == city2);
    }

    public static bool operator <(City city1, City city2)
    {
        if (city1 is null || city2 is null)
        {
            throw new ArgumentNullException("Cities cannot be null");
        }
        return city1.Residents < city2.Residents;
    }

    public static bool operator >(City city1, City city2)
    {
        if (city1 is null || city2 is null)
        {
            throw new ArgumentNullException("Cities cannot be null");
        }
        return city1.Residents > city2.Residents;
    }

    public override bool Equals(object obj)
    {
        if (obj is City otherCity)
        {
            return Residents == otherCity.Residents;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Residents.GetHashCode();
    }
}