export function findSmallestInt(args: number[]): number {
    var sorted = args.sort((a,b) => a - b);
    return sorted[0];
}