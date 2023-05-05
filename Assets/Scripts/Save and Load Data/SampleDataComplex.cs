[System.Serializable]
public class SampleDataComplex 
{
    public string name;
    public Address address;
    public Book[] books;
}

[System.Serializable]
public class Address
{
    public int unit;
    public string road;
    public string city;

    public string CurrentAddress()
    {
        string address = $"{unit}, {road}, {city}";
        return address;
    }
}

[System.Serializable]
public class Book
{
    public string name;
    public bool isDigital;
    public string author;

    public string CurrentBook()
    {
        string bookDetails = $"The book {name} is written by {author}";
        return bookDetails;
    }
}
