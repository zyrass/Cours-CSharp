using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaines
{
  internal class DemoChaineVerbatime
  {
    public static string demo = @"
-- Je suis dans une chaîne Verbatime.
USE movies

SELECT title, release_date
FROM movie
WHERE
  release_date BETWEEN ""1980-01-01"" AND ""2000-01-01""
";

  }
}
