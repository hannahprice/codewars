export class Kata {
    static xo(str: string) {
      let chars = str.split('');
      let xCount = chars.filter(x => x == 'x' || x == 'X').length;
      let oCount = chars.filter(x => x == 'o' || x == 'O').length;
      return xCount == oCount;
    }
}