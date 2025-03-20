class SimpleDataBase<T> 
{
    private List<T> storeData;
    private List<DateTime> inputData = new List<DateTime>();

    public SimpleDataBase() 
    {
        storeData = new List<T>();
    }

    public void addNewData(T data) 
    {
        storeData.Add(data);
        inputData.Add(DateTime.Now);
    }

    public void printAllData() 
    {
        for (int i = 0; i < storeData.Count; i++) 
        {
            Console.WriteLine("Data " + (i + 1) + "berisi: " + storeData[i] + ", yang disimpan pada waktu UTC: " + inputData[i]);
        }
    }
}

class Program 
{
    public static void Main(string[] args) 
    {
        SimpleDataBase<int> simple = new SimpleDataBase<int>();
        simple.addNewData(10);
        simple.addNewData(30);
        simple.addNewData(22);
        simple.printAllData();
    }
} 