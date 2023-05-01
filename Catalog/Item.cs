using System;

namespace Jet.Piranha.Domain.Catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Prie { get; set; }
        public List<Rating> Ratings {get; set;} = new List<Rating>();

    }
}

public Item(string name, string description, string brand, decimal price )
{
    if (string.isNullOrEmpty(name))
    {
        throw new ArgumentNullException(name);
    }
    if (string.isNullOrEmpty(description))
    {
        throw new ArgumentNullException(description);
    }
    if (string.isNullOrEmpty(brand))
    {
        throw new ArgumentNullException(brand);
    }
    if(price < 0.00m)
    {
        if (string.isNullOrEmpty(name))
    {
        throw new ArgumentException("Price must be greater than zero.");
    }
    
    Name = name;
    Description = description;
    Brand = brand;
    Price = price;
    }

    public voic AddRating(Rating rating)
    {
        this.Ratings.Add(rating);
    }
}