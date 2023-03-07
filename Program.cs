using System.Text.Json;

var Numbers = new List<int>{1, -1, 4, 20, 3, -9, 5, -8};
var sortedNumbers = Numbers.Where(n => n < 0).Concat(Numbers.Where(n => n >= 0));
var json = JsonSerializer.Serialize(sortedNumbers);
Console.WriteLine(json);
