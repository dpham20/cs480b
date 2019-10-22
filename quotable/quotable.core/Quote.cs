/// <summary>
/// Model object for a Quote object.
/// </summary>
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
    /// <summary>
    /// id represents a string id of a Quote object.
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// quote holds the string quote of an author for the Quote object.
    /// </summary>
    public string quote { get; set; }
    /// <summary>
    /// String representing the author of a quote. 
    /// </summary>
    public string author { get; set; }
}