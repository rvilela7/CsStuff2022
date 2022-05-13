string myString = "Gato Sapato";

List<char> stringList = myString.Replace(" ", "").ToCharArray().ToList();
    
var result = 
    from a in stringList
    from b in stringList
    where a != b
    select a.ToString() + b.ToString();

result.ToList().ForEach(m => Console.WriteLine(m));

