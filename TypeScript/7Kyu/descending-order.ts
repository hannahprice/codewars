export class Kata {
    static descendingOrder(n: number) {
      let numbers = n.toString().split('');
      let numbersSorted = numbers.sort((a,b) => +b - +a);
      let numbersJoined = numbersSorted.join('');
      return +numbersJoined;
    }
}