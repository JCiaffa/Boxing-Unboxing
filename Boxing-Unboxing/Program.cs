List<object> list = new List<object>();
        list.Add(7);
        list.Add(28);
        list.Add(-1);
        list.Add(true);
        list.Add("chair");

int sum = 0;

foreach(var i in list){
    Console.WriteLine(i);
}

foreach(var i in list){
    if(i is int){
        sum += (int)i;
    }
}

Console.WriteLine($"The sum of the integers in the list is: {sum}");