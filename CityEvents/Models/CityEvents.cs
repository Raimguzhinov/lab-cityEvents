using DynamicData.Binding;

namespace CityEvents.Models;

public class CityEvent : AbstractNotifyPropertyChanged
{
    private string _header = "";
    private string _description = "";
    private string _image = "";
    private string _date = "";
    private string _category = "";
    private decimal _price;

    private static string CheckStringLenght(string? str)
    {
        if (str != "")
        {
            if (str!.Length > 135)
            {
                int len = str.Length - 133;
                str = str[..^len];
                str += "...";
            }
        }
        return str;
    }
    public string Header
    {
        get => _header;
        set => SetAndRaise(ref _header, value);
    }

    public string Description
    {
        get => _description;
        set {
            SetAndRaise(ref _description, CheckStringLenght(value));
        }
    }

    public string Image
    {
        get => _image;
        set => SetAndRaise(ref _image, value);
    }

    public string Date
    {
        get => _date;
        set => SetAndRaise(ref _date, value);
    }

    public string Category
    {
        get => _category;
        set => SetAndRaise(ref _category, value);
    }

    public decimal Price
    {
        get => _price;
        set => SetAndRaise(ref _price, value);
    }
}
