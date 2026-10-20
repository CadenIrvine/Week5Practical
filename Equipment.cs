using Equipment;

public class Equipment
{
	public Equipment()
	{
		private int equipmentId;
		private string name;
		private bool isAvailable;

	public int EquipmentId
    {
        get { return equipmentId; }
        set { equipmentId = value; }
    }
	public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public bool IsAvailable
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }
    public Equipment(int equipmentId, string name, bool isAvailable)
    {
        EquipmentId = equipmentId;
        Name = name;
        IsAvailable = isAvailable;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Equipment ID: {EquipmentId}, Name: {Name}, Available: {IsAvailable}");
        Console.WriteLine();
    }
    }
}
