int[] a; //описание массива
a = new int[10]; //создание массива
int i;

//Вывести массив на экран
for(i = 0; i < 10; ++i)
{
    Console.WriteLine(a[i]);
}

// Первый способ обнуления массива
int i;
i = 0;
while (i < 10)
{
    a[i] = 0;
    ++i;
}

// Второй способ обнуления массива (название переменной для примера меняем (j))
for(int j = 0; j < 10; ++j)
{
    a[j] = 0;
}

// Ввод массива с клавиатуры
for(int j = 0; j < 10; ++j)
{
    string s = Console.ReadLine();
    a[j] = Convert.ToInt32(s);
}
for(i = 0; i < 10; ++i)
{
    Console.Write(a[i]+" ");
}