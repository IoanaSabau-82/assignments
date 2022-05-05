import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'removeLetterE'
})

export class RemoveLetterEPipe implements PipeTransform{
  transform(value: string) {
      return value.replace("e","")
  }
}


