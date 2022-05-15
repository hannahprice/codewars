export class G964 {
    
    public static accum(s: string):string {
      let result: string = "";
      for (let char = 0; char < s.length; char++){
        result += s[char].toUpperCase()
        result += s[char].repeat(char).toLowerCase();  
        if (char != s.length -1){
        result += "-";
        }
      }
      return result;
    }
}