Console.WriteLine("Первоначальный массив:");
string[]array = new string[3]{"Hello", ":-)", "7"}; 
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
 Console.WriteLine("Измененный массив:");                              //объявляем переменную с именем array  и типом string
for(int i=0; i<array.Length; i++)
{  
 if (array[i].Length <= 3)                                               // создаем экземпляр массива, используя оператор new.
Console.WriteLine(array[i]);                                           // выводим массив на печать
}