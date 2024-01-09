using Template_Web_API.Entities.Base;

namespace Auction_API.Entities;

public class Favorite: BaseEntity
{
    public int AuctionItemId { get; set; }
    public int UserId { get; set; }
    
    public AuctionItem AuctionItem { get; set; }
    public ICollection<AuctionItem> AuctionItems { get; }
}