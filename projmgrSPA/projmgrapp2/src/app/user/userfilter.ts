import{ Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'userfilter',
    pure:false


})

export class UserFilterPipe implements PipeTransform {
    transform(users : any[], filter1 : any ) : any {
        console.log(users);
        console.log(filter1);
        if (!users || !filter1)
          return users;

        return users.filter(item=> item.first_name.toLowerCase().indexOf(filter1.toLowerCase()) !== -1 || item.last_name.toLowerCase().indexOf(filter1.toLowerCase()) !== -1);  
    }
}