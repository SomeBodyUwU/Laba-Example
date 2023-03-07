using System.Text.Json;
var dict = new Dictionary<int, int>
{
    [5] = 2,
    [2] = 3,
    [3] = 6
};
var sum = dict[5] + dict[2] + dict[3];
foreach (var key in dict)
{
    dict[key.Key] = sum;
}
Console.WriteLine(dict);
foreach (var keys in dict)
{
    Console.WriteLine(keys.Value);
}

var json = JsonSerializer.Serialize(dict);
Console.Write(json);
