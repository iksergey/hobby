using static System.Console;

void FailException()
{
  Clear();
  for (int i = 0; i < 5; i++)
  {
    WriteLine(AddressProvider.Instance.GetAddress());
  }
  int failCount = 0;
  for (int i = 0; i < 100; i++)
  {
    try
    {
      var n = AddressProvider
            .Instance
            .GetAddress()
            .City
            .Street
            .House
            .Number
            .Value;
    }
    catch
    {
      failCount++;
    }
  }
  WriteLine($"failCount: {failCount}");
  WriteLine("vvv");
  ReadLine();
}

void FailInfo()
{
  Clear();
  Address address = AddressProvider.Instance.GetAddress();
  string failInfo = String.Empty;

  int value = 0;
  if (address != null)
  {
    var city = address.City;
    if (city != null)
    {
      var street = address.City.Street;
      if (street != null)
      {
        var house = address.City.Street.House;
        if (house != null)
        {
          var number = address.City.Street.House.Number;
          if (number != null)
          {
            value = address.City.Street.House.Number.Value;
          }
          else
          {
            failInfo = "No Number";
          }
        }
        else
        {
          failInfo = "No House";
        }
      }
      else
      {
        failInfo = "No Street";
      }
    }
    else
    {
      failInfo = "No City";
    }
  }
  else
  {
    failInfo = "No Address";
  }

  if (String.IsNullOrEmpty(failInfo))
  {
    WriteLine($"Номер дома: {value}");
  }
  else
  {
    WriteLine($" failInfo: {failInfo}");
  }
  WriteLine("vvv");
  ReadLine();
}

void FailResponse()
{
  Clear();
  Address address = AddressProvider.Instance.GetAddress();
  bool failResponse = false;

  int value = 0;
  if (address != null)
  {
    var city = address.City;
    if (city != null)
    {
      var street = address.City.Street;
      if (street != null)
      {
        var house = address.City.Street.House;
        if (house != null)
        {
          var number = address.City.Street.House.Number;
          if (number != null)
          {
            value = address.City.Street.House.Number.Value;
          }
          else
          {
            failResponse = true;
          }
        }
        else
        {
          failResponse = true;
        }
      }
      else
      {
        failResponse = true;
      }
    }
    else
    {
      failResponse = true;
    }
  }
  else
  {
    failResponse = true;
  }

  if (!failResponse)
  {
    WriteLine($"Номер дома: {value}");
  }
  else
  {
    WriteLine($"Какие-то данные отсутствуют");
  }
  WriteLine("vvv");
  ReadLine();
}

void ElvisOperator()
{
  Clear();
  Address address = AddressProvider.Instance.GetAddress();
  int? n = address?.City?.Street?.House?.Number?.Value;
  WriteLine($"value: {n} {n == null}");

  if (n.HasValue)
  {
    int val = n.Value;
  }
  WriteLine("vvv");
  ReadLine();
}

// warning CS8600: 
// Converting null literal or 
// possible null value to non-nullable type
// string s = ReadLine();
FailException();
FailInfo();
FailResponse();
ElvisOperator();