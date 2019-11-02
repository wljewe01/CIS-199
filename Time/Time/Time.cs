// Time class declaration with one constructor that uses defaults.  
using System;

public class Time
{
    private int _hour;   // 0 - 23
    private int _minute; // 0 - 59
    private int _second; // 0 - 59

    // Precondition:  0 <= h < 24
    //                0 <= m < 60
    //                0 <= s < 60
    // Postcondition: The Time object has been initialized with the specified
    //                hour, minute, and second
    public Time(int h = 0, int m = 0, int s = 0)
    {
        Hour = h; // set the Hour property
        Minute = m; // set the Minute property
        Second = s; // set the Second property
    }

    // Precondition:  0 <= h < 24
    //                0 <= m < 60
    //                0 <= s < 60
    // Postcondition: The time is changed to the specified hour,
    //                minute, and second
    public void SetTime(int h, int m, int s)
    {
        Hour = h; // set using the Hour property
        Minute = m; // set using the Minute property
        Second = s; // set using the Second property
    }

    public int Hour
    {
        // Precondition:  None
        // Postcondition: The hour has been returned
        get
        {
            return _hour;
        }

        // Precondition:  0 <= value < 24
        // Postcondition: The hour has been set to the specified value
        set
        {
            if (value >= 0 && value < 24)
                _hour = value;
            else // When invalid, set to 0 instead
                _hour = 0;
        } 
    }

    public int Minute
    {
        // Precondition:  None
        // Postcondition: The minute has been returned
        get
        {
            return _minute;
        }

        // Precondition:  0 <= value < 60
        // Postcondition: The minute has been set to the specified value
        set
        {
            if (value >= 0 && value < 60)
                _minute = value;
            else // When invalid, set to 0 instead
                _minute = 0;
        } 
    }

    public int Second
    {
        // Precondition:  None
        // Postcondition: The second has been returned
        get
        {
            return _second;
        }

        // Precondition:  0 <= value < 60
        // Postcondition: The second has been set to the specified value
        set
        {
            if (value >= 0 && value < 60)
                _second = value;
            else // When invalid, set to 0 instead
                _second = 0;
        }
    } 

    // Precondition:  None
    // Postcondition: A string is returned presenting the time in US format
    public override string ToString() // override is required!
    {
        string result; // Builds result in steps

        if (Hour == 0 || Hour == 12)
            result = "12";
        else
            result = $"{Hour % 12}";

        result += $":{Minute:D2}:{Second:D2} ";

        if (Hour < 12)
            result += "AM";
        else
            result += "PM";

        return result;
    }
}