using System.Text.Json.Serialization;
using TarkovApp.Models.Enums;

namespace TarkovApp.Models;

public class Item
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("normalizedName")]
    public string? NormalizedName { get; set; }

    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("basePrice")]
    public int? BasePrice { get; set; }

    [JsonPropertyName("updated")]
    public string? Updated { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("iconLink")]
    public string? IconLink { get; set; }

    [JsonPropertyName("gridImageLink")]
    public string? GridImageLink { get; set; }

    [JsonPropertyName("baseImageLink")]
    public string? BaseImageLink { get; set; }

    [JsonPropertyName("inspectImageLink")]
    public string? InspectImageLink { get; set; }

    [JsonPropertyName("image512pxLink")]
    public string? Image512pxLink { get; set; }

    [JsonPropertyName("image8xLink")]
    public string? Image8xLink { get; set; }

    [JsonPropertyName("wikiLink")]
    public string? WikiLink { get; set; }

    [JsonPropertyName("types")]
    public List<ItemType>? Types { get; set; }

    [JsonPropertyName("avg24hPrice")]
    public int? Avg24hPrice { get; set; }

    //[JsonPropertyName("properties")]
    //public ItemProperties? Properties { get; set; }

    [JsonPropertyName("conflictingItems")]
    public List<Item>? ConflictingItems { get; set; }

    [JsonPropertyName("conflictingSlotIds")]
    public List<string>? ConflictingSlotIds { get; set; }

    [JsonPropertyName("accuracyModifier")]
    public float? AccuracyModifier { get; set; }

    [JsonPropertyName("recoilModifier")]
    public float? RecoilModifier { get; set; }

    [JsonPropertyName("ergonomicsModifier")]
    public float? ErgonomicsModifier { get; set; }

    [JsonPropertyName("hasGrid")]
    public bool? HasGrid { get; set; }

    [JsonPropertyName("blocksHeadphones")]
    public bool? BlocksHeadphones { get; set; }

    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonPropertyName("lastLowPrice")]
    public int? LastLowPrice { get; set; }

    [JsonPropertyName("changeLast48h")]
    public float? ChangeLast48h { get; set; }

    [JsonPropertyName("changeLast48hPercent")]
    public float? ChangeLast48hPercent { get; set; }

    [JsonPropertyName("low24hPrice")]
    public int? Low24hPrice { get; set; }

    [JsonPropertyName("high24hPrice")]
    public int? High24hPrice { get; set; }

    [JsonPropertyName("lastOfferCount")]
    public int? LastOfferCount { get; set; }

    //[JsonPropertyName("sellFor")]
    //public List<ItemPrice>? SellFor { get; set; }

    //[JsonPropertyName("buyFor")]
    //public List<ItemPrice>? BuyFor { get; set; }

    //[JsonPropertyName("containsItems")]
    //public List<ContainedItem>? ContainsItems { get; set; }

    //[JsonPropertyName("category")]
    //public ItemCategory? Category { get; set; }

    //[JsonPropertyName("categories")]
    //public List<ItemCategory>? Categories { get; set; }

    [JsonPropertyName("bsgCategoryId")]
    public string? BsgCategoryId { get; set; }

    //[JsonPropertyName("handbookCategories")]
    //public List<ItemCategory>? HandbookCategories { get; set; }

    [JsonPropertyName("weight")]
    public float? Weight { get; set; }

    [JsonPropertyName("velocity")]
    public float? Velocity { get; set; }

    [JsonPropertyName("loudness")]
    public int? Loudness { get; set; }

    [JsonPropertyName("usedInTasks")]
    public List<Task>? UsedInTasks { get; set; }

    [JsonPropertyName("receivedFromTasks")]
    public List<Task>? ReceivedFromTasks { get; set; }

    //[JsonPropertyName("bartersFor")]
    //public List<Barter>? BartersFor { get; set; }

    //[JsonPropertyName("bartersUsing")]
    //public List<Barter>? BartersUsing { get; set; }

    //[JsonPropertyName("craftsFor")]
    //public List<Craft>? CraftsFor { get; set; }

    //[JsonPropertyName("craftsUsing")]
    //public List<Craft>? CraftsUsing { get; set; }

    //[JsonPropertyName("historicalPrices")]
    //public List<HistoricalPricePoint>? HistoricalPrices { get; set; }

    public void DisplayBasicProperties()
    {
        Console.WriteLine($"Id: {Id},");
        Console.WriteLine($"Name: {Name},");
        Console.WriteLine($"Description: {Description}");
    }
}

public class ItemAttribute
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public class ItemCategory
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("normalizedName")]
    public string? NormalizedName { get; set; }

    [JsonPropertyName("parent")]
    public ItemCategory? Parent { get; set; }

    [JsonPropertyName("children")]
    public List<ItemCategory>? Children { get; set; }
}

public class ItemFilters
{
    [JsonPropertyName("allowedCategories")]
    public List<ItemCategory>? AllowedCategories { get; set; }

    [JsonPropertyName("allowedItems")]
    public List<Item>? AllowedItems { get; set; }

    [JsonPropertyName("excludedCategories")]
    public List<ItemCategory>? ExcludedCategories { get; set; }

    [JsonPropertyName("excludedItems")]
    public List<Item>? ExcludedItems { get; set; }
}

public class ItemPrice
{
    [JsonPropertyName("vendor")]
    public Vendor? Vendor { get; set; }

    [JsonPropertyName("price")]
    public int? Price { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("currencyItem")]
    public Item? Item { get; set; }

    [JsonPropertyName("priceRUB")]
    public int? PriceRub { get; set; }
}