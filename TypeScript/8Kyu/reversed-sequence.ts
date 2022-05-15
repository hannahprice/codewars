export const reverseSeq = (n: number): number[] => {
    let array = [];
    for (let i = n; i > 0; i--) {
      array.push(i);
    }
    return array;
};