using System;

public class Car


{
	private string _name;
	private int _hp;

	public Car(string name, int hp = 0)
	{
		_name = name;
		Console.WriteLine(name + " is created");
		_hp = hp;
	}
	public Car()
	{ 
		
	}
	public void Drive()
	{
		Console.WriteLine(_name + " took off");
	}
	public void Stop()
	{
		Console.WriteLine(_name + " Stopped");
	}
	public void Info()
	{
		Console.WriteLine("This Car is {0} and it's power is {1}", _name, _hp);
	}
	public void SetName(string name)
	{
		_name = name == "" ? "Default Name" : name;
	}
	public string GetName()
	{
		return _name;
	}

}
