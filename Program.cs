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

//sum
//average
//count
//minby, maxby, min, max
//any, all

//mennyi termék van raktáron?
var sumOfStockQTY = products.Sum(p => p.StockQTY);

//mennyi a termékek átlagára?
var avgPrice = products.Average(p => p.PriceHUF);

//hány terméke van a 'nova' gyártónak?
var coutOfNovaProd = products.Count(p => p.Manufacturer == "Nova");

//melyik a legrosszabb termék értékelés szerint?
var worstRatingProd = products.MinBy(p => p.Rating);

var highestPrice = products.Max(p => p.PriceHUF);

bool isAllProdCheap = products.All(p => p.PriceHUF < 20000);

bool isThereAnyMouse = products.Any(p => p.Model.Contains("Mouse"));

//  kiválasztás     linker

//  first           firstordefault
//  last            lastordefault
//  single          singleordefault

//first, last, single: HA NINCS a pred.-nek megfelelő elem, akkor:
//'Sequence contains no matching element' exceptiont dob!

//..orDefault-oknál HA NINCS találat obj. kollekcióknál az eredmény "null"

//sigle & singleordef >> HA TÖBB a pred.-nek megfelelő találat LENNE
//akkor 'Sequence contains more than one matching element'


