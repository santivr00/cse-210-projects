using System;

public class Entry
{
    public string _date;
    public string _location;
    public string _prompt;
    public string _response;

    public Entry(string date, string location, string prompt, string response)
    {
        _date = date;
        _location = location;
        _prompt = prompt;
        _response = response;
    }
}