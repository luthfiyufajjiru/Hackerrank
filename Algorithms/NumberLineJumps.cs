using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*
* Let two kangaroo jumping forward from different starting point and different velocity.
* Is there any chance for two kangaroo meets each other without slowing down their velocity?

* The function is expected to return a STRING.
* The function accepts following parameters:
*  1. INTEGER x1
*  2. INTEGER v1
*  3. INTEGER x2
*  4. INTEGER v2
*/

class Result
{  
  public static string kangaroo(int x1, int v1, int x2, int v2)
  {
    if(v2 > v1 || (v2 == v1 && x2 > x1)) return "NO";

    bool loop = true;
    string result = "NO"; 
    int time = 0;
    
    while(loop)
    {
        if(time > 9999) loop = false;
        
        int range1 = x1 + v1 * time,
            range2 = x2 + v2 * time;
            
        if(range1 == range2)
        {
            result = "YES";
            loop = false;
        }

        time++;
    }
    return result;
  }
}