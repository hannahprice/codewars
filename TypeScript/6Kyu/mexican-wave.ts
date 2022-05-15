export function wave(str: string): Array<string>{
    let chars = [...str.toLowerCase()];
    let wave = [];
    
    for (let i = 0; i < chars.length; i++) {
      if (chars[i] != ' '){
        chars[i] = chars[i].toUpperCase();
        wave.push(chars.join(''));
        chars[i] = chars[i].toLowerCase();
      }
    }
    
    return wave;
}