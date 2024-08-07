/* parse the individual "Order IDs", and output the "OrderIDs" sorted 
and tagged as "Error" if they aren't exactly four characters in length.*/


/*Add code to output each "Order ID" in sorted order and tag orders 
that aren't exactly four characters in length as "- Error"*/



string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);


foreach(var orderID in orderIDs)
{
    if (orderID.Length ==  4)
        Console.WriteLine(orderID);
    else
        Console.WriteLine(orderID + "\t-Error");
}


