using System;
using System.Linq;
using System.Collections.Generic;


string UpperCase(string str) => str.ToUpper();
string Capitalize(string str) => char.ToUpper(str[0]) + str.Substring(1).ToLower();
string CapitalizeAll(string str)
{
    List<string> result = new List<string>();
    
    var splitted = str.Split(" ");
    foreach (var item in splitted)
        result.Add(Capitalize(item));

    return result.Join(" ");
}

List<string> formataString(List<string> stringList, delegateFormat format)
{
    List<string> result = new List<string>();
    foreach (var item in stringList)
        result.Add(format(item));
    return result;
}

delegate string delegateFormat(string str);