using System;

public interface ILibraryDetails
{
    int GetBookFund();
    int GetReadingRoomSeats();
    int GetFoundedYear();
    string GetPhoneNumber();
    bool GetHasDigitalLibrary();
    string GetField(string fieldName, string libraryName);
    string GetHexBookFund();
}


public class LibraryDetails : ILibraryDetails
{
    public string Name { get; set; }
    public int BookFund { get; set; }
    public int ReadingRoomSeats { get; set; }
    public int FoundedYear { get; set; }
    public string PhoneNumber { get; set; }
    public bool HasDigitalLibrary { get; set; }

    public LibraryDetails(string _name,int bookFund, int readingRoomSeats, int foundedYear, string phoneNumber, bool hasDigitalLibrary)
    {
        Name = _name;
        BookFund = bookFund;
        ReadingRoomSeats = readingRoomSeats;
        FoundedYear = foundedYear;
        PhoneNumber = phoneNumber;
        HasDigitalLibrary = hasDigitalLibrary;
    }

    public int GetBookFund() => BookFund;
    public int GetReadingRoomSeats() => ReadingRoomSeats;
    public int GetFoundedYear() => FoundedYear;
    public string GetPhoneNumber() => PhoneNumber;
    public bool GetHasDigitalLibrary() => HasDigitalLibrary;

    public string GetField(string fieldName, string libraryName)
    {
        return fieldName switch
        {
            "Название" => $"Название: {libraryName}",
            "Фонд книг" => $"Фонд книг: {BookFund}",
            "Места" => $"Мест в зале: {ReadingRoomSeats}",
            "Год основания" => $"Год основания: {FoundedYear}",
            "Номер телефона" => $"Номер телефона: {PhoneNumber}",
            "Электронная библиотека" => $"Электронная библиотека: {HasDigitalLibrary}",
            _ => "Некорректное поле"
        };
    }

    public string GetHexBookFund()
    {
        return $"Фонд в 16-ричном формате: {BookFund:X}";
    }
}


public abstract class Library
{
    protected ILibraryDetails _libraryDetails;

    public string Name { get; set; }

    public Library(ILibraryDetails libraryDetails)
    {
        _libraryDetails = libraryDetails;
    }

    public abstract override string ToString();

    public abstract string GetField(string fieldName);

    public abstract string GetHexBookFund();
}


public class SchoolLibrary : Library
{
    public SchoolLibrary(ILibraryDetails libraryDetails) : base(libraryDetails)
    {
    }

    public override string ToString()
    {
        return $"{Name},Школьная, {_libraryDetails.GetReadingRoomSeats()}, {_libraryDetails.GetFoundedYear()}, " +
               $"{_libraryDetails.GetBookFund()}, Has Digital Library: {_libraryDetails.GetHasDigitalLibrary()}";
    }

    public override string GetField(string fieldName)
    {
        return _libraryDetails.GetField(fieldName, Name);  
    }

    public override string GetHexBookFund()
    {
        return _libraryDetails.GetHexBookFund();
    }
}


public class UniversityLibrary : Library
{
    public UniversityLibrary(ILibraryDetails libraryDetails) : base(libraryDetails)
    {
    }

    public override string ToString()
    {
        return $"{Name},Университетская, {_libraryDetails.GetReadingRoomSeats()}, {_libraryDetails.GetFoundedYear()}, " +
               $"{_libraryDetails.GetBookFund()}, Has Digital Library: {_libraryDetails.GetHasDigitalLibrary()}";
    }

    public override string GetField(string fieldName)
    {
        return _libraryDetails.GetField(fieldName, Name); 
    }

    public override string GetHexBookFund()
    {
        return _libraryDetails.GetHexBookFund();
    }
}

public class LibraryBuilder
{
    private string _name;
    private int _bookFund;
    private int _readingRoomSeats;
    private int _foundedYear;
    private string _phoneNumber;
    private bool _hasDigitalLibrary;
    private LibraryType _libraryType;

    public enum LibraryType { School, University }

    public LibraryBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public LibraryBuilder SetBookFund(int bookFund)
    {
        _bookFund = bookFund;
        return this;
    }

    public LibraryBuilder SetReadingRoomSeats(int seats)
    {
        _readingRoomSeats = seats;
        return this;
    }

    public LibraryBuilder SetFoundedYear(int year)
    {
        _foundedYear = year;
        return this;
    }

    public LibraryBuilder SetPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
        return this;
    }

    public LibraryBuilder SetHasDigitalLibrary(bool hasDigital)
    {
        _hasDigitalLibrary = hasDigital;
        return this;
    }

    public LibraryBuilder SetLibraryType(LibraryType libraryType)
    {
        _libraryType = libraryType;
        return this;
    }

    public Library Build()
    {
        ILibraryDetails libraryDetails = new LibraryDetails(_name, _bookFund, _readingRoomSeats, _foundedYear, _phoneNumber, _hasDigitalLibrary);
        Library library;

        switch (_libraryType)
        {
            case LibraryType.School:
                library = new SchoolLibrary(libraryDetails);
                break;
            case LibraryType.University:
                library = new UniversityLibrary(libraryDetails);
                break;
            default:
                throw new ArgumentException("Invalid library type");
        }

        library.Name = _name;
        return library;
    }
}