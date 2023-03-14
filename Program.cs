class MyIntList
{
    private List<int> numbersList = new List<int>();

    public double Average
    {
        get
        {
            return CalculateAverage();
        }
    }

    public int MinValue
    {
        get
        {
            return numbersList.Min();
        }
    }

    public int MaxValue
    {
        get
        {
            return numbersList.Max();
        }
    }

    public void AddNumber(int number)
    {
        numbersList.Add(number);
    }

    public void RemoveNumber(int number)
    {
        numbersList.Remove(number);
    }

    public double CalculateAverage()
    {
        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }
        return sum / (double)numbersList.Count;
    }
}