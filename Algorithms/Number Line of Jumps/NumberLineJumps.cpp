#include <iostream>

using namespace std;

string kangaroo (int x1, int v1, int x2, int v2) {
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