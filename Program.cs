Console.WriteLine("Выводим в консоль числа от 1 до 5"); 
for (int i = 1; i <= 5; i++)
{
 Console.WriteLine(i);   
}

Console.WriteLine("Выводим в консоль числа от 7 до 2"); 
for (int i = 7; i >= 2; i--)
{
 Console.WriteLine(i);   
}


Console.WriteLine("Определяем является ли n простым"); 
int n = 2; 
bool x = true;

for (int i = 2; i < n; i++)
{   
    if (n % i == 0 )  
    {   
        x = false;

    }
  
}
if (n ==1){x = false;}
Console.WriteLine(x);

Console.WriteLine("Создание и сортировка массивов");

int[] SetArr(int len)
{
int[] arr = new int [len];
Random rnd = new Random();

for (int i = 0; i < len; i++)
{
    arr[i] = rnd.Next(0,100);
}

return arr;
}

void Sort(int[] arr){
    int tmp = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length-i-1; j++)
        {
            if (arr[j]>arr[j+1]){
                tmp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = tmp;
            }
            
        }
    }

}


int[] arr = SetArr(10);
Console.WriteLine("============До Сортировки==================");
foreach (int item in arr)
{
    Console.WriteLine(item);
}
Console.WriteLine("============После Сортировки==================");
Sort(arr);

foreach (int item in arr)
{
    Console.WriteLine(item);
}

