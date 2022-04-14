Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(10));
Console.WriteLine(DateTime.Now.AddSeconds(200));
Console.WriteLine(DateTime.Now.AddMonths(2));
Console.WriteLine(DateTime.Now.AddYears(2));
Console.WriteLine(DateTime.Now.AddMilliseconds(600));

//DateFormat
Console.WriteLine(DateTime.Now.ToString("dd"));//günün rakamsal hali 10 gibi
Console.WriteLine(DateTime.Now.ToString("ddd"));//günün kısaltması Thu
Console.WriteLine(DateTime.Now.ToString("dddd"));//günün tam hali Thursday
Console.WriteLine(DateTime.Now.ToString("MM"));//04
Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
Console.WriteLine(DateTime.Now.ToString("MMM"));//April
Console.WriteLine(DateTime.Now.ToString("yy"));//22
Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

//Math Kütüphanesi
Console.WriteLine(Math.Abs(-2));//Mutlak değeri 2

Console.WriteLine(Math.Sin(90.0));
Console.WriteLine(Math.Cos(45.0));
Console.WriteLine(Math.Tan(180));
Console.WriteLine(Math.Round(Math.Tan(180)));

Console.WriteLine(Math.Ceiling(10.50));//Yukarı yuvarlak
Console.WriteLine(Math.Round(10.40));//En yakın tam sayıya yuvarlar
Console.WriteLine(Math.Round(10.60));//
Console.WriteLine(Math.Floor(10.50));//Aşagı yuvarlar

Console.WriteLine(Math.Max(-2,0));
Console.WriteLine(Math.Min(1,2));

Console.WriteLine(Math.Pow(-2,2));//-2nin karesi =4
Console.WriteLine(Math.Sqrt(9));//kök alma
Console.WriteLine(Math.Log(9));//Logaritma e tabanına göre
Console.WriteLine(Math.Log(27,3));//Logaritma 3 tabanına göre
Console.WriteLine(Math.Log10(100));//Logaritma 10 tabanına göre
Console.WriteLine(Math.Log2(64));//Logaritma 2 tabanına göre
Console.WriteLine(Math.Exp(3));//e Üzeri 3
