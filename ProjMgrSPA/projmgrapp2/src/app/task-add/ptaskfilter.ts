import{ Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'ptaskfilter',
    pure:false


})

export class ParentTaskFilterPipe implements PipeTransform {
    transform(ptasks : any[], filterValue : any ) : any {
        //console.log(users);
        //console.log(filterValue);
        if (!ptasks || !filterValue)
          return ptasks;

        return ptasks.filter(item=> item.parent_task1.toLowerCase().indexOf(filterValue.toLowerCase()) !== -1 );  
    }
}