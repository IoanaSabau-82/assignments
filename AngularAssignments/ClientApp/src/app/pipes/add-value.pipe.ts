import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'addValue'
})

export class AddValuePipe implements PipeTransform{
  transform(value: number) {
      return value + "5"
  }
}
