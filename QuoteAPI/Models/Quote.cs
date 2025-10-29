namespace QuoteAPI.Models;

public class Quote
{
    public int Id { get; set; }               // unique ID
    public string Text { get; set; } = "";    // quote text
    public string Author { get; set; } = "";  // who said it
}