import{ Pipe, PipeTransform } from '@angular/core';



@Pipe({
    name: 'projsort' 
})

export class ProjSortPipe implements PipeTransform {

    

    transform(projs : any[], sortValue : any ) : any {
        console.log(projs);
        console.log(sortValue);
        if (!projs || !sortValue)
          return projs;

           
       

        return projs.sort((s1: any, s2: any) => {
          
          var sv1 = s1[sortValue];
          var sv2 = s2[sortValue];


            if (sortValue == "priority") {
                return sv1 - sv2;
            }
            else  if (sortValue == "start_dt" ||
                  sortValue == "end_dt")
             {
             sv1 =  new Date(s1[sortValue]).toISOString();
            
              sv2 =  new Date(s2[sortValue]).toISOString();
               }


            if (sv1 < sv2 ) {
                return -1;
            }
            else if (sv1 > sv2) {
                return 1;
            }
            else {
                return 0;
            }
        }
       );  
    }
}