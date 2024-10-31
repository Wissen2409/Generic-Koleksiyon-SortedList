
// SortedList generic koleksiyonu, key value çifti alan bir koleksiyondur!!!

// sorted list koleksiyonu, key value değerine göre çalışır!!

// Girilen key değeri unique olmalıdır!!!

// SortedList koleksiyonu girilen değerleri key value çiftine göre artan bir şekilde sıralar!!!

// Sıralama case'ini oluşturup deneyiniz!!!

SortedList<int,string> list = new SortedList<int, string>();
list.Add(1,"zzz");
list.Add(2,"abc");


// ekrana yazdılım

foreach(KeyValuePair<int,string> item in list){

    Console.WriteLine("Key : {0}",item.Key);
    Console.WriteLine("Value : {0}",item.Value);
}

// Ödev : 
//Stack<>,Queue<>,HashSet<> koleksiyonlarını kendiniz deneyimleyiniz!!!

// HashSet koleksiyonu, verileri hashleyerek tutar!!! 
// HashSet koleksiyona girilen veriler benzzersiz olmalıdır!!!

