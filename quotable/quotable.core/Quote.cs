public class Quote
{
    //This is a model class to represent Quote obejcts.

    /// <summary>
    /// Creates a Quote object setting parameters: id, string, and author.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="quote"></param>
    /// <param name="author"></param>
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