#nullable disable

#region dataset
const string FilePath = "..\\..\\..\\data\\arukeszlet.csv";

List<Product> products = [];

using StreamReader stream = new(FilePath);
_ = stream.ReadLine();
while (!stream.EndOfStream) products.Add(new(stream.ReadLine()));

//TEST #01
//products.ForEach(x => Console.WriteLine($"{x}\n--------------------------------"));
#endregion