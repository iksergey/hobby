class Number
{
  public string Description { get; set; }
  public int Value { get; set; }
  public override string ToString() => $"{Value} {Description}";
}

class House
{
  public string Description { get; set; }
  public Number Number { get; set; }
  public override string ToString() => $"{Description} {Number}";
}

class Street
{
  public string Description { get; set; }
  public House House { get; set; }
  public override string ToString() => $"{Description} {House}";
}

class City
{
  public string Description { get; set; }
  public Street Street { get; set; }
  public override string ToString() => $"{Description} {Street}";
}

class Address
{
  public string Description { get; set; }
  public City City { get; set; }
  public override string ToString() => $"{Description} {City}";
}