import{ Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'usersort' 
})

export class UserSortPipe implements PipeTransform {
    transform(users : any[], sortValue : any ) : any {
        //console.log(users);
        //console.log(sortValue);
        if (!users || !sortValue)
          return users;

       
        return users.sort((s1: any, s2: any) => {

            if (sortValue == "emp_id")  {
              
                 return s1[sortValue]  - s2[sortValue];
            }
            else {

           
           

            if (s1[sortValue].toUpperCase() < s2[sortValue].toUpperCase()) {
                return -1;
            }
            else if (s1[sortValue].toUpperCase() > s2[sortValue].toUpperCase()) {
                return 1;
            }
            else {
                return 0;
            }
          }
        }
       );  
    }
}