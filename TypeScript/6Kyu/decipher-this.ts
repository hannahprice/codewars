export function decipherThis(str: string): string {
    let words = str.split(' ');
    let sentence = [];
    
    for (let word of words){
      let chars = [...word];
      let numbers = chars.filter(x => !isNaN(+x)).join('');
      
      let firstLetter = String.fromCharCode(+numbers);
      let firstLetterReplaced = word.replace(numbers, firstLetter);
      
      if (firstLetterReplaced.length > 2) {
        let wordChars = [...firstLetterReplaced];
        let secondLetter = wordChars[1];
        let lastLetter = wordChars[wordChars.length - 1];
        
        wordChars[1] = lastLetter;
        wordChars[wordChars.length - 1] = secondLetter;
        
        let allLettersReplaced = wordChars.join('');
        if (words.indexOf(word) != words.length - 1) {
          sentence.push(allLettersReplaced);
        } else {
          sentence.push(allLettersReplaced);
        }
      }
      else {
        if (words.indexOf(word) != words.length - 1) {
          sentence.push(firstLetterReplaced);
        }
        else {
          sentence.push(firstLetterReplaced);
        }
      }
    }
  
    return sentence.join(' ').trim();
}