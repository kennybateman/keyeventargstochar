private string ConvertKeyEventArgsToString(System.Windows.Forms.KeyEventArgs e)
{
    // handle letters
    if (!e.Modifiers.HasFlag(Keys.Shift) && e.KeyValue >= 65 && e.KeyValue <= 90)
        return e.KeyCode.ToString().ToLower();
    if (e.Modifiers.HasFlag(Keys.Shift) && e.KeyValue >= 65 && e.KeyValue <= 90)
        return e.KeyCode.ToString().ToUpper(); // should already be the default; but just in case

    // handle numbers
    if (!e.Modifiers.HasFlag(Keys.Shift) && e.KeyValue >= 48 && e.KeyValue <= 57)
        return e.KeyCode.ToString().Replace("D","");
    if (e.Modifiers.HasFlag(Keys.Shift) && e.KeyValue >= 48 && e.KeyValue <= 57)
    {
        switch (e.KeyValue)
        {
            case 48: return ")"; // 0
            case 49: return "!"; // 1
            case 50: return "@"; // 2
            case 51: return "#"; // 3
            case 52: return "$"; // 4
            case 53: return "%"; // 5
            case 54: return "^"; // 6
            case 55: return "&"; // 7
            case 56: return "*"; // 8
            case 57: return "("; // 9
        }
    }

    // handle special chars
    if (!e.Modifiers.HasFlag(Keys.Shift) && e.KeyValue >= 186 && e.KeyValue <= 226)
        return e.KeyCode.ToString();
    if (e.Modifiers.HasFlag(Keys.Shift) && e.KeyValue >= 186 && e.KeyValue <= 226)
    {
        switch (e.KeyValue)
        {
            case 186: return ":"; // ;
            case 187: return "+"; // = 
            case 188: return "<"; // ,
            case 189: return "_"; // -
            case 190: return ">"; // .
            case 191: return "?"; // /
            case 192: return "~"; // `
            case 219: return "{"; // [
            case 220: return "|"; // \
            case 221: return "}"; // ]
            case 222: return "\""; // '
        }
    }

    // return empty string if no condition met
    return "";
}
