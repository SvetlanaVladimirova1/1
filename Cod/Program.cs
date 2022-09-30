
Console.WriteLine("Первоначальный массив:");
string[]array = new string[5]{"Hello", "*", ":-)", "world", "7"}; 
Console.WriteLine(String.Join("; ", array));
Console.WriteLine("Измененный массив:");                              
 for( int i=0; i<array.Length; i++)
 {  
  if (array[i].Length <= 3)                                               
 Console.Write(array[i]+"; ");                                        
 }

