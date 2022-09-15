class AddressProvider
{
  static AddressProvider instance;
  public static AddressProvider Instance
  {
    get
    {
      if (instance == null) instance = new();
      return instance;
    }
  }

  private AddressProvider() { }

  private bool Choice() => Random.Shared.Next(10) >= 2;

  public Address GetAddress()
  {
    Address address = new();

    bool c = Choice();
    if (!c) return address;
    address.City = new() { Description = "г. Смоленск" };

    c = Choice();
    if (!c) return address;
    address
    .City
    .Street = new() { Description = "ул. Пржевальского" };

    c = Choice();
    if (!c) return address;
    address
    .City
    .Street
    .House = new() { Description = "Дом" };

    c = Choice();
    if (!c) return address;
    address
    .City
    .Street
    .House
    .Number = new()
    {
      Description = "",
      Value = 4
    };

    return address;
  }
}