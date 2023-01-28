string[] FilterArray(string[] array)
{
     int count = 0;
     for (int i = 0; i < array. Length; i++)

    {

      if (array[i].Length <= 3)
      {
        count++;
      }
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i< array. Length; i++)
    { 

     if (array[i].Length <= 3)

       {
          newArray[j] = array[i];
          j++;
       }
    }

    return newArray;
}   

void PrintArray(string[] array)
{
    Console.Write("[");
  for (int i = 0; i < array.Length -1;i++)
    {
        Console.Write($" '{array[i]}' , ");
    }

Console.Write($" '{array[array.Length-1]}']");
}
string[] myArray = { "hello", "2","world", ":-)","1234","123","-2"};
PrintArray(FilterArray(myArray));


