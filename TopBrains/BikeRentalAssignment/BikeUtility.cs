using System.Collections.Generic;

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        int key = Program.bikeDetails.Count + 1;

        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes =
            new SortedDictionary<string, List<Bike>>();

        foreach (KeyValuePair<int, Bike> item in Program.bikeDetails)
        {
            Bike bike = item.Value;

            if (!groupedBikes.ContainsKey(bike.Brand))
            {
                groupedBikes[bike.Brand] = new List<Bike>();
            }

            groupedBikes[bike.Brand].Add(bike);
        }

        return groupedBikes;
    }
}