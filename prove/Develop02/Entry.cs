using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}