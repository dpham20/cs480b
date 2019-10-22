public class Quote
{
    public Quote(string id, string quote, string author)
    {
        this.id = id;
        this.quote = quote;
        this.author = author;
    }
    public string id { get; set; }
    public string quote { get; set; }
    public string author { get; set; }
}