// This JavaScript is not from Ts Compile

function kangaroo(x1, v1, x2, v2) {
  // Write your code here
  if(v2 > v1 || (v2 == v1 && x2 > x1)) return "NO";

    let loop = true;
    let result = "NO"; 
    let time = 0;
    
    while(loop)
    {
        if(time > 9999) loop = false;
        
        let range1 = x1 + v1 * time;
        let range2 = x2 + v2 * time;
            
        if(range1 == range2)
        {
            result = "YES";
            loop = false;
        }

        time++;
    }
    return result;
}