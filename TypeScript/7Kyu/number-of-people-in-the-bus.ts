export function number(busStops:number[][]):number {
    let numberOfPeople = 0;
    for (let busStop of busStops) {
      numberOfPeople += busStop[0];
      numberOfPeople -= busStop[1];
    }
    return numberOfPeople;
}