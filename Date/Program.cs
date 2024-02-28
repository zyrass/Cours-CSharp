using System;
using System.Globalization;

namespace Date
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Présentation des Dates et Heures");

      // DateTime
      DateTime dt0 = new DateTime(); // 01/01/0001 00:00:00
      DateTime dt1 = new DateTime(1984, 1, 7); // 07/01/1984 00:00:00
      DateTime dt2 = new DateTime(1984, 1, 7, 0, 0, 1); // 07/01/1984 00:00:01
      DateTime dt3 = new DateTime(1984, 1, 7, 0, 0, 2, DateTimeKind.Utc); // 07/01/1984 00:00:02
      DateTime dt4 = DateTime.Today; // 28/02/2024 00:00:00
      DateTime dt5 = DateTime.UtcNow; // 28/02/2024 17:47:55

      Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", dt0, dt1, dt2, dt3, dt4, dt5);

      // Durée (intervale de temps) - Décalage UTC
      TimeSpan ts0 = new TimeSpan(); // 00:00:00
      TimeSpan ts1 = new TimeSpan(3, 0, 0); // 03:00:00
      TimeSpan ts2 = new TimeSpan(4, 23, 41, 58); // 4.23:41:58 (jour.hh:mm:ss)
      TimeSpan ts3 = new TimeSpan(4, 23, 41, 62); // 4.23:42:02

      Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", ts0, ts1, ts2, ts3);

      // Date/heures avec décalage par rappoort au temps UTC le TimeSpan ici doit être obligatoirement sur hh:mm seulement
      DateTimeOffset dto0 = new DateTimeOffset(dt0, ts0); // 01/01/01 00:00:00 +00:00
      DateTimeOffset dto1 = new DateTimeOffset(dt1, ts1); // 21/06/30 00:00:00 +03:00
      DateTimeOffset dto2 = new DateTimeOffset(dt2, ts1); // 25/12/30 22:30:00 +03:00

      Console.WriteLine("{0}\n{1}\n{2}", dto0, dto1, dto2);

      // Date seules
      DateOnly do0 = new DateOnly();   // 01/01/0001
      DateOnly do1 = new DateOnly(2030, 09, 22); // 22/09/2030
      DateOnly do2 = DateOnly.FromDateTime(DateTime.Today); // Date du jour

      Console.WriteLine("{0}\n{1}\n{2\n", do0, do1, do2);

      // Heures seules
      TimeOnly to0 = new TimeOnly();   // 00:00:00
      TimeOnly to1 = new TimeOnly(14, 55, 28);  // 14:55:28
      TimeOnly to2 = TimeOnly.FromDateTime(DateTime.Now);   // Heure courante

      Console.WriteLine("{0:T}\n{1:T}\n{2}\n", to0, to1, to2);

      // Exploiter des dates saisie par un utilisateur
      const string erreur = "Impossible d'interpréter la chaîne en date";
      bool res;

      string sdt1 = "25/12/2030 22:30:45"; // Format par défaut de la culture courante (fr-FR)
      res = DateTime.TryParse(sdt1, out DateTime dt10);
      Console.WriteLine(res ? dt10 : erreur); // 25/12/2030 22:30:45

      string sdt11 = "25 12 2030 22:30:45"; // Autre séparateur
      res = DateTime.TryParse(sdt11, out DateTime dt11);
      Console.WriteLine(res ? dt11 : erreur); // 25/12/2030 22:30:45

      string sdt2 = "12/25/2030 10:30:45 PM"; // Format de la culture en-US
      res = DateTime.TryParse(sdt2, CultureInfo.GetCultureInfo("en-US"), out DateTime dt20);
      Console.WriteLine(res ? dt20 : erreur); // 25/12/2030 22:30:45

      string sdt21 = "12-25-2030 22:30:45";  // Autre format accepté
      res = DateTime.TryParse(sdt21, CultureInfo.GetCultureInfo("en-US"), out DateTime dt21);
      Console.WriteLine(res ? dt21 : erreur); // 25/12/2030 22:30:45

      string sdt3 = "12/25/2030 22:30:45"; // Format par défaut de la culture invariante
      res = DateTime.TryParse(sdt3, CultureInfo.InvariantCulture, out DateTime dt30);
      Console.WriteLine(res ? dt30 : erreur); // 25/12/2030 22:30:45

      string sdt31 = "2030-12-25 22:30:45"; // Format moins ambigü
      res = DateTime.TryParse(sdt31, CultureInfo.InvariantCulture, out DateTime dt31);
      Console.WriteLine(res ? dt31 : erreur); // 25/12/2030 22:30:45

      string sdtp = "Mercredi 25 déc. 2030 22:30"; // Format personalisé
      string format = "dddd dd MMM yyyy HH:mm";
      res = DateTime.TryParseExact(sdtp, format, CultureInfo.GetCultureInfo("fr-FR"),
                                 DateTimeStyles.AllowInnerWhite, out DateTime dtp);
      Console.WriteLine(res ? dtp : erreur); // 25/12/30 22:30:00

      string sdto = "2030-12-25 22:30:45 +04:30"; // Format de la culture invariante
      res = DateTimeOffset.TryParse(sdto, CultureInfo.InvariantCulture, out DateTimeOffset dto);
      Console.WriteLine(res ? dto : erreur);

      string sdo = "2030-12-25";
      res = DateOnly.TryParse(sdo, CultureInfo.InvariantCulture, out DateOnly don);
      Console.WriteLine(res ? don : erreur);

      string sto = "22:30:45";
      res = TimeOnly.TryParse(sto, CultureInfo.InvariantCulture, out TimeOnly ton);
      Console.WriteLine(res ? ton : erreur);

      string sts = "1.23:42:50";
      res = TimeSpan.TryParse(sts, CultureInfo.InvariantCulture, out TimeSpan ts);
      Console.WriteLine(res ? ts : erreur);

      string sts2 = "1j 23h 42min 50s";   // Format personnalisé
      string format2 = "d'j 'hh'h 'mm'min 'ss's'";
      res = TimeSpan.TryParseExact(sts2, format2, CultureInfo.GetCultureInfo("fr-FR"), out TimeSpan ts20);
      Console.WriteLine(res ? ts20 : erreur);

      DateTimeOffset dto100 = new DateTimeOffset(2030, 1, 31, 22, 45, 58, new TimeSpan());
      Console.WriteLine($"Date : {dto100.Date}");             // 31/01/30 00:00:00
      Console.WriteLine($"TimeOfDay : {dto100.TimeOfDay}");   // 22:45:58
      Console.WriteLine($"Offset : {dto100.Offset}");         // 00:00:00
      Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}.{6}",
         dto100.Year, dto100.Month, dto100.Day, dto100.Hour, dto100.Minute, dto100.Second, dto100.Millisecond);
      // 2030/1/31 22:45:58.0

      DateTimeOffset dto110 = new DateTimeOffset(2030, 1, 31, 22, 45, 58, new TimeSpan());
      Console.WriteLine(dto110);               // 31/01/30 22:45:58 +00:00
      Console.WriteLine(dto110.DateTime);      // 31/01/30 22:45:58
      Console.WriteLine(dto110.LocalDateTime); // 31/01/30 23:45:58
      Console.WriteLine(dto110.UtcDateTime);   // 31/01/30 22:45:58

      Console.WriteLine(dto110.DayOfWeek);  // Thursday
      Console.WriteLine(dto110.DayOfYear);  // 31
      Console.WriteLine(dto110.Ticks);      // 640317267580000000

      // METHODES

      DateTimeOffset dto111 = new DateTimeOffset(2030, 1, 31, 22, 45, 58, new TimeSpan());
      Console.WriteLine(dto111);   // 31/01/2030 22:45:58 +00:00

      DateTimeOffset dto222 = dto111.AddYears(-1).AddMonths(-1).AddHours(-1);
      Console.WriteLine(dto222);   // 31/12/28 21:45:58 +00:00

      TimeSpan ts11 = new TimeSpan(1, 1, 1, 1); // 1j, 1h, 1min, 1s
      Console.WriteLine(dto111 + ts11);   // 01/02/30 23:46:59 +00:00
      Console.WriteLine(dto111 - ts11);   // 30/01/30 21:44:57 +00:00

      // comparaison
      TimeSpan tsDecalage = new TimeSpan(3, 0, 0);
      DateTimeOffset dto3 = new DateTimeOffset(dto1.DateTime, tsDecalage);
      Console.WriteLine(dto3 < dto1);  // True

      // Conversion dans un système de temps différent
      DateTimeOffset dto11111 = new DateTimeOffset(2030, 1, 31, 22, 45, 58, new TimeSpan());
      Console.WriteLine(dto11111);                     // 31/01/30 22:45:58 +00:00
      Console.WriteLine(dto11111.ToLocalTime());       // 31/01/30 23:45:58 +01:00
      Console.WriteLine(dto11111.ToUniversalTime());   // 31/01/30 22:45:58 +00:00

      Console.WriteLine(dto11111.DateTime);            // 31/01/30 22:45:58
      Console.WriteLine(dto11111.LocalDateTime);       // 31/01/30 23:45:58
      Console.WriteLine(dto11111.UtcDateTime);         // 31/01/30 22:45:58

      // Date/heure correspondant au passage à l'heure d'été en Fance
      DateTime dt = new DateTime(2030, 3, 31, 2, 0, 0); // 31/03/2030 à 2:00
      TimeSpan ts4 = new TimeSpan(1, 0, 0); // décalage de 1h par rapport au temps UTC
      DateTimeOffset dtoHeureEté = new DateTimeOffset(dt, ts4);

      Console.WriteLine(dtoHeureEté.ToLocalTime());      // 31/03/30 03:00:00 +02:00
      Console.WriteLine(dtoHeureEté.ToUniversalTime());  // 31/03/30 01:00:00 +00:00

      // STRUCTURE TIMESPAN

      // Propriétés
      TimeSpan ts1789 = new TimeSpan(2, 23, 45, 58);
      Console.WriteLine($"{ts1789.Days}.{ts1789.Hours}:{ts1789.Minutes}:{ts1789.Seconds}"); // 2.23:45:58

      Console.WriteLine($"TotalDays : {ts1789.TotalDays}");    // 2,99025...
      Console.WriteLine($"TotalHours : {ts1789.TotalHours}");   // 71,76611..
      Console.WriteLine($"TotalMinutes : {ts1789.TotalMinutes}");   // 4305,966..

      // Constantes
      Console.WriteLine(TimeSpan.Zero);      // 00:00:00
      Console.WriteLine(TimeSpan.MinValue);  // -10675199.02:48:05.4775808
      Console.WriteLine(TimeSpan.MaxValue);  // 10675199.02:48:05.4775807
      Console.WriteLine(TimeSpan.TicksPerDay);  // 864000000000

      // Méthodes
      Console.WriteLine(TimeSpan.FromDays(2.990255));    // 2.23:45:58.032
      Console.WriteLine(TimeSpan.FromHours(71.7661111)); // 2.23:45:57.999
      Console.WriteLine(TimeSpan.FromMinutes(4305.9667)); // 2.23:45:58.002

      TimeSpan ts7771 = new TimeSpan(1, 9, 10, 20);
      TimeSpan ts2354 = new TimeSpan(1, 1, 1, 1); // 1.01:01:01
      Console.WriteLine(ts7771.Add(ts2354));       // 2.10:11:21
      Console.WriteLine(ts7771.Subtract(ts2354));  // 08:09:19
      Console.WriteLine(ts7771 + ts2354);   // 2.10:11:21
      Console.WriteLine(ts7771 - ts2354);   // 08:09:19

      TimeSpan ts1454564 = new TimeSpan(1, 9, 10, 20);
      Console.WriteLine(ts1454564.Negate());    // -1.9:10:20
      Console.WriteLine(ts1454564.Duration());  // 1.9:10:20
      Console.WriteLine(ts1454564.Multiply(2)); // 2.18:20:40
      Console.WriteLine(ts1454564.Divide(2));   // 16:35:10

      // Fuseau Horraire

      // Liste des fuseaux horaires
      Console.WriteLine("Id" + new string(' ', 29) + " | E | Nom standard" + new string(' ', 19) + " | Décalage");
      Console.WriteLine(new string('-', 85));

      List<TimeZoneInfo> tzis = TimeZoneInfo.GetSystemTimeZones().ToList();
      foreach (TimeZoneInfo tzi in tzis)
      {
        string desc = $"{tzi.Id,-31} | {(tzi.SupportsDaylightSavingTime ? 'O' : 'N')} | {tzi.StandardName,-31} | {tzi.BaseUtcOffset}";
        Console.WriteLine(desc);
      }

      Console.WriteLine();
      int res2 = tzis.Where(t => t.SupportsDaylightSavingTime).Count();
      Console.WriteLine("{0} fuseaux avec heure d'été et {1} sans", res2, tzis.Count - res2);

      // Convertir une date/heure vers un autre fuseau
      DateTimeOffset dto1456654564 = new DateTimeOffset(2030, 1, 31, 14, 0, 0, new TimeSpan(1, 0, 0));
      string idFuseau = "Canada Central Standard Time"; // le code CST fonctionne aussi

      DateTimeOffset dto165462 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dto1456654564, idFuseau);
      Console.WriteLine($"Conversion de {dto165462} \nvers le fuseau {idFuseau}\n = {dto165462}");

      /* 
       * Conversion de 31/01/30 14:00:00 +01:00 
       * vers le fuseau Canada Central Standard Time
       * = 31/01/30 07:00:00 -06:00 
       */

      DateTime dt1999999999 = new DateTime(2030, 1, 31, 14, 0, 0, DateTimeKind.Utc);
      DateTime dt2999999999 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt1999999999, idFuseau);
      Console.WriteLine($"Conversion de {dt1999999999} \nvers le fuseau {idFuseau}\n = {dt2999999999}");

      /* 
       * Conversion de 31/01/30 14:00:00
       * vers le fuseau Canada Central Standard Time
       * = 31/01/30 08:00:00 
       */

      // Ajouter du temps à une date locale

      DateTimeOffset dtooo = new DateTimeOffset(2030, 3, 30, 23, 0, 0, new TimeSpan(1, 0, 0));

      // Convertit cette date/heure en temps UTC et lui ajoute le temps souhaité
      TimeSpan ajout = new TimeSpan(7, 30, 0);
      DateTimeOffset dtooo2 = dtooo.ToUniversalTime().Add(ajout);

      // Reconvertit le résultat en temps local
      dtooo2 = dtooo2.ToLocalTime();

      // Affiche le résultat
      Console.WriteLine($"{dtooo} + {ajout} = {dtooo2}");
      // 30/03/30 23:00:00 +01:00 + 7:30 = 31/03/30 07:30:00 +02:00
      // Le passage à l'heure d'été a bien été intégré

      DateTimeOffset dtottttt = new DateTimeOffset(2030, 3, 30, 23, 0, 0, new TimeSpan(1, 0, 0));

      TimeSpan ajoutx = new TimeSpan(7, 30, 0);
      DateTimeOffset dto24444 = dto.Add(ajoutx);

      Console.WriteLine($"{dtottttt} + {ajoutx} = {dto24444}");
      // 30/03/30 23:00:00 +01:00 + 07:30:00 = 31/03/30 06:30:00 +01:00
      // Le passage à l'heure d'été n'a pas été intégré
    }
  }
}
