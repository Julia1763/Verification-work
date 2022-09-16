/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.  */ 
 Console.WriteLine("Введите длину массива: ");
     int size = int.Parse(Console.ReadLine());
string[] Arr = new string[size];
 string[] array = UserArray(size);
 string[] MyArray = ModifyArray(array);
 Console.WriteLine("Вывод массива, с подходящими элементами: ");
 Console.WriteLine(String.Join(", ", MyArray));
string[] UserArray(int size)
 {
     string[] arr = new string[size];
        for (int i = 0; i < size; i++)
      {
       Console.WriteLine($"Введите элемент под номером {i}");
       arr[i] = Console.ReadLine();

      }
      return arr;

 }
 string[] ModifyArray(string[] arr)
 {
  int k = 0;
        for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i].Length<4)
        {
          Arr[k] = arr[i];
          Console.WriteLine($"Вывод элементов, удовлетворяющих заданию: {arr[i]}");
          k++;
        }
      }
      return Arr;
 }


