namespace red-rattlesnake.Domain.Catalog;

public class Rating
{
    public int id {get; set;}
    public int Star {get; set; }
    public string UserName { get; set; }
    public int Review { get; set; }

}

public Rating(int stars, string userName, string review)
{
    if(stars < 1 || stars > 5)
    {
        throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5.")
    }

    if(string.isNullOrEmpty(userName))
    {
        throw new ArgumentException("UserName cannot be null.")
    }

    this.Stars = stars;
    this.userName = userName;
    this.Review = review;
}