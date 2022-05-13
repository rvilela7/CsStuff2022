string myString = "Gato Sapato";

List<char> stringList = myString.ToCharArray().ToList();
    
var result = 
    from a in stringList
    from b in stringList
    where a != b
    && !Char.IsWhiteSpace(a) // better filter on string
    && !Char.IsWhiteSpace(b)
    select a.ToString() + b.ToString();

result.ToList().ForEach(m => Console.WriteLine(m));

