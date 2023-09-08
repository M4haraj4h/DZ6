int[] array = new int[8];
int b = 7;
int i = 0;

while(i <= b)
{
    int a = Convert.ToInt32(Console.ReadLine());
    array[i] = a;
    i = i + 1;
}

foreach (int q in array)
{
    Console.Write("{0} ", q);
}
