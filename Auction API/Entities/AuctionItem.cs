using Template_Web_API.Entities.Base;

namespace Auction_API.Entities;

public class AuctionItem : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int StartingPrice { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public bool status { get; set; }
    public int CategoryId { get; set; }
    public int SellerId { get; set; }
    
    // reference
    
}