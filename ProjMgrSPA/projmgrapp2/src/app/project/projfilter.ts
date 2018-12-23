import{ Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'projfilter',
    pure:false


})

export class ProjFilterPipe implements PipeTransform {
    transform(projs : any[], filterValue : any ) : any {
        console.log(projs);
        console.log(filterValue);
        if (!projs || !filterValue)
          return projs;

        return projs.filter(item=> item.project1.toLowerCase().indexOf(filterValue.toLowerCase()) !== -1);  
    }
}