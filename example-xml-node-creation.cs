public XmlElement AddNewBook(string genre, string ISBN, string misc, 
    string title, string price, XmlDocument doc)
{
    // Create a new book element.
    XmlElement bookElement = doc.CreateElement("book", "http://www.contoso.com/books");

    // Create attributes for book and append them to the book element.
    XmlAttribute attribute = doc.CreateAttribute("genre");
    attribute.Value = genre;
    bookElement.Attributes.Append(attribute);

    attribute = doc.CreateAttribute("ISBN");
    attribute.Value = ISBN;
    bookElement.Attributes.Append(attribute);

    attribute = doc.CreateAttribute("publicationdate");
    attribute.Value = misc;
    bookElement.Attributes.Append(attribute);

    // Create and append a child element for the title of the book.
    XmlElement titleElement = doc.CreateElement("title");
    titleElement.InnerText = title;
    bookElement.AppendChild(titleElement);

    // Introduce a newline character so that XML is nicely formatted.
    bookElement.InnerXml = 
        bookElement.InnerXml.Replace(titleElement.OuterXml, 
        "\n    " + titleElement.OuterXml + " \n    ");
    
    // Create and append a child element for the price of the book.
    XmlElement priceElement = doc.CreateElement("price");
    priceElement.InnerText= price;
    bookElement.AppendChild(priceElement);

    // Introduce a newline character so that XML is nicely formatted.
    bookElement.InnerXml =
        bookElement.InnerXml.Replace(priceElement.OuterXml, priceElement.OuterXml + "   \n  ");

    return bookElement;
     
}