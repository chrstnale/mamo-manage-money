using System;


class Cashflow
{
	private string _type;
	private float _nominal;
	private string _category;
	private string _notes;
	private string _date;

	public string type
    {
		get { return _type; }
    }
	public float nominal
    {
		get { return _nominal; }
		set { _nominal = value; }
    }
	public string category
    {
		get { return _category; }
		set { _category = value; }
    }
	public string notes
    {
		get { return _notes; }
		set { _notes = value; }
    }
	public string date
    {
		get { return _date; }
		set { _date = value; }
    }
}
