using System.Text.RegularExpressions;

string a = "0-9";
bool murad()
{
    Regex regex = new Regex(a);

    return regex.IsMatch(a);
}

