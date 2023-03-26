// Программа, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string[] Newarray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = String($" Значение № {i + 1}");
  }

  Console.WriteLine();
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if( array[i].Length <= 3 && array[i].Length != 0 )
    {
      Console.Write($"{array[i]} ");
      count += 1;
    }
  }

  string[] newarray = new string[count];
  count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if( array[i].Length <= 3 )
    {
      newarray[count] = array[i];
    }
  }
  
  return newarray;
}

int ReadInt(string argument)
{
  Console.Write($"{argument} ");
  int number;

  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Вы ввели недопустимое значение, Повторите еще раз!");
  }

  return number; 
}

string String (string argument)
{
  Console.Write($"{argument}: ");
  string a = "";

  while(a.Length == 0)
  {
    a = Console.ReadLine();

    if(a.Length == 0)
    {
      Console.WriteLine("Вы не ввели значение, Повторите еще раз!");
    }
  }
    
  return a; 
}

string[] array = new string[ReadInt("Задайте длинну массива:")];
Console.WriteLine();
Newarray(array);