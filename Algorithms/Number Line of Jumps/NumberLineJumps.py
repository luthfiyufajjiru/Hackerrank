def kangaroo(x1, v1, x2, v2):
  if(v2 > v1 or  (v2 == v1 and x2 > x1)):
    return "NO"
  
  loop = True
  result = "NO"
  time = 0

  while(loop):
    if(time > 9999):
      loop = False

    range1 = x1 + v1 * time
    range2 = x2 + v2 * time
            
    if(range1 == range2):
      result = "YES"
      loop = False

    time += 1
    
  return result