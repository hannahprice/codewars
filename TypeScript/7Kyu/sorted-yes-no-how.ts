export function isSortedAndHow(array:number[]): string {  
    let sortedAsc = array.slice().sort((a,b) => a - b).toString();
    let sortedDesc = array.slice().sort((a,b) => b - a).toString();
    
    if (array.toString() === sortedAsc) {
      return "yes, ascending";
    } 
    else if (array.toString() === sortedDesc) {
      return "yes, descending";
    }
    return "no";
}