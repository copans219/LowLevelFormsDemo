﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormsDemo.Common
{
   public static class Extensions
   {
      public static HashSet<T> ToHashSet<T>(
         this IEnumerable<T> source,
         IEqualityComparer<T> comparer = null)
      {
         return new HashSet<T>(source, comparer);
      }
   }
}
