export function positiveSum(arr:number[]):number {
    return arr.filter(z => z > 0).reduce((sum, current) => sum + current, 0);
}