string a = "a";
string b = "a";
string c = new string('a', 1);
object d = "a";
object e = c;

Console.WriteLine($"Is string A == B ? {a == b}");  // string.Equals()
Console.WriteLine($"Is string A == C ? {a == c}");  // string.Equals()
Console.WriteLine($"Is string A == D ? {a == d}");  // IL: ceq, same object (string literal)
Console.WriteLine($"Is string A == E ? {a == e}");  // IL: ceq, different object


