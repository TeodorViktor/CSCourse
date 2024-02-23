using System;

public class Car

	
{
    private string _name;
    public Car(string name)
	{
		_name = name;
		Console.WriteLine(name + " is created");
	}
	public void Drive() 
	{
		Console.WriteLine(_name + " took off");
	}
	public void Stop()
	{
		Console.WriteLine(_name + " Stopped");
	}
}
