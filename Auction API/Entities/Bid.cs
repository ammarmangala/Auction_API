using Template_Web_API.Entities.Base;

namespace Auction_API.Entities;

public class Bid : BaseEntity
{
    public int Amount { get; set; }
    public DateTime BidDateTime { get; set; }
    public int BidderId { get; set; }
    public int AuctionItemId { get; set; }
}