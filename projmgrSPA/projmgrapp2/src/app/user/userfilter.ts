import{ Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'userfilter',
    pure:false


})

export class UserFilterPipe implements PipeTransform {
    transform(users : any[], filterValue : any ) : any {
        //console.log(users);
        //console.log(filterValue);
        if (!users || !filterValue)
          return users;

        return users.filter(item=> item.first_name.toLowerCase().indexOf(filterValue.toLowerCase()) !== -1 || item.last_name.toLowerCase().indexOf(filterValue.toLowerCase()) !== -1);  
    }
}